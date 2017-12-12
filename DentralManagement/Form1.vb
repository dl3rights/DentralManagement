﻿Imports System.Data.SqlClient
Imports System.Threading
Imports System.Threading.Thread
Public Class Form1

    Dim MaxRe As Boolean = False
    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer
    Dim Default_Gray As Color
    Dim User_ID As String
    Dim User_name As String
    Dim Priv_Class As String
    'Dim Menu_Selected As String

    'SQL SERVER CONNECTION'
    Dim connection As New SqlConnection("Data Source=tcp:192.168.6.11, 1433;Database=sedentral;User ID=se_admin;Password=Dentis1234;")

    'END SQL SERVER CONNECTION'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        UpdateStyles()

        Default_Gray = Color.FromArgb(126, 139, 154)
        btn_admin.BackColor = Default_Gray


        'Thread
        Dim thrd As New Thread(AddressOf LoadBackgroundImage)
        thrd.IsBackground = True
        thrd.Start()
        'End Thread
        connection.Open()
        'Login Load'
        Dim username_load_command As New SqlCommand("Select [User_ID] from [dbo].[User]", connection)
        Dim username_load As New SqlDataAdapter(username_load_command)
        Dim username_table As New DataTable()

        username_load.Fill(username_table)
        Username.DataSource = username_table
        Username.DisplayMember = "User_ID"
        Username.ValueMember = "User_ID"
        'End Login Load'
        connection.Close()
    End Sub

    Private Sub LoadBackgroundImage()
        Menu_Tool.BackgroundImage = New Bitmap(My.Resources.Menu)
        U.BackgroundImage = New Bitmap(My.Resources.Background1)
        Taskbar.BackgroundImage = New Bitmap(My.Resources.Taskbar)
    End Sub

    Private Sub btn_Login_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Login.MouseDown
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Down)
    End Sub

    Private Sub btn_Login_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Login.MouseUp
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Default)
    End Sub

    Private Sub btn_Exit_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Exit.MouseDown
        btn_Exit.BackgroundImage = New Bitmap(My.Resources.Exit_Down)
    End Sub

    Private Sub btn_Exit_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Exit.MouseUp
        btn_Exit.BackgroundImage = New Bitmap(My.Resources.Exit_Default)
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.MouseClick
        Close()
    End Sub

    Private Sub btn_MaxRe_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_MaxRe.MouseDown
        If MaxRe Then
            btn_MaxRe.BackgroundImage = New Bitmap(My.Resources.Restore_Down)
        Else
            btn_MaxRe.BackgroundImage = New Bitmap(My.Resources.Max_Down)
        End If
    End Sub

    Private Sub btn_MaxRe_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_MaxRe.MouseUp
        If MaxRe Then
            btn_MaxRe.BackgroundImage = New Bitmap(My.Resources.Restore_Default)
        Else
            btn_MaxRe.BackgroundImage = New Bitmap(My.Resources.Max_Default)
        End If
    End Sub

    Private Sub btn_MaxRe_Click(sender As Object, e As EventArgs) Handles btn_MaxRe.MouseClick
        If MaxRe Then
            Me.WindowState = FormWindowState.Normal
            MaxRe = False
        Else
            Me.WindowState = FormWindowState.Maximized
            MaxRe = True
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Taskbar.MouseMove
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X -= (X)
            point.Y -= (Y)
            Me.Location = point
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Taskbar.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btn_Min_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Min.MouseDown
        btn_Min.BackgroundImage = New Bitmap(My.Resources.Min_Down)
    End Sub

    Private Sub btn_Min_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Min.MouseUp
        btn_Min.BackgroundImage = New Bitmap(My.Resources.Min_Default)
    End Sub

    Private Sub btn_Min_Click(sender As Object, e As EventArgs) Handles btn_Min.MouseClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_search_rec_Click(sender As Object, e As EventArgs) Handles btn_search_rec.Click
        Dim text_search As String = tb_idcard_search.Text
        connection.Open()
        Dim tb_search_command As New SqlCommand("Select * from [dbo].[Patient] where [patient_id_card] = '" & text_search & "'", connection)
        Dim read_record As SqlDataReader = tb_search_command.ExecuteReader()

        If read_record.Read() Then
            rec_fname.Text = read_record("patient_Fname").ToString
        Else

        End If
        Record_1.Visible = False
        Record_2.Visible = True
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        connection.Open()
        Dim load_user As New SqlCommand("Select * from [dbo].[User] Where ([User_ID]='" & Username.SelectedValue & "') AND ([User_Pass] = '" & Password.Text & "')", connection)
        Dim read As SqlDataReader = load_user.ExecuteReader()

        If read.Read() Then

            User_ID = read("User_ID").ToString()
            If read("User_Access").ToString() = 2 Then
                Priv_Class = 2
                btn_admin.BackColor = TransparencyKey
                btn_admin.Cursor = Cursors.Hand
            End If

            Dim load_name As New SqlCommand("Select [Emp_Fname],[Emp_Lname] from [dbo].[Employee] Where [Emp_ID] = '" & read("Fori_User_Id").ToString & "'", connection)
            read.Close()
            Dim read_emp As SqlDataReader = load_name.ExecuteReader()
            If read_emp.Read() Then
                Dim fname As String = read_emp("Emp_Fname").ToString()
                Dim lname As String = read_emp("Emp_Lname").ToString()
                User_name = fname + " " + lname
                usern.Text = User_name
                Login(True)
            End If
            read_emp.Close()
        Else
            MessageBox.Show("กรอกรหัสผ่านผิด.", "Wrong Password.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        connection.Close()
    End Sub

    Private Sub btn_record_Click(sender As Object, e As EventArgs) Handles btn_record.Click
        Set_Button_Hold(1)
        Set_Panel(Record_1)
    End Sub

    Private Sub btn_drug_Click(sender As Object, e As EventArgs) Handles btn_drug.Click
        Set_Button_Hold(2)
        Set_Panel(Drug)
    End Sub

    Private Sub btn_finan_Click(sender As Object, e As EventArgs) Handles btn_finan.Click
        Set_Button_Hold(3)
        Set_Panel(Finan)
    End Sub

    Private Sub btn_emp_Click(sender As Object, e As EventArgs) Handles btn_emp.Click
        Set_Button_Hold(4)
        Set_Panel(Employee)
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        If Priv_Class = 2 Then
            Set_Button_Hold(5)
            Set_Panel(Admin)
        End If
    End Sub

    Private Sub Set_Panel(P_name As DblBufferedPanel)
        Record_1.Visible = False
        Record_2.Visible = False
        Record_3.Visible = False
        Record_4.Visible = False
        Admin.Visible = False
        Drug.Visible = False
        Finan.Visible = False
        Admin.Visible = False
        Home.Visible = False
        Employee.Visible = False

        P_name.Visible = True
    End Sub

    Private Sub Login(Status As Boolean)
        If Status Then
            U.Visible = True
            Login_p.Visible = False
        Else
            Login_p.Visible = True
            U.Visible = False
        End If
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        User_ID = ""
        User_name = ""
        Priv_Class = 0
        Password.Text = ""
        Login(False)
    End Sub

    Private Sub Set_Button_Hold(Menu_Selected As String)

        If Menu_Selected = 1 Then
            btn_record.Image = New Bitmap(My.Resources.Record_Hold)
        Else
            btn_record.Image = Nothing
        End If

        If Menu_Selected = 2 Then
            btn_drug.Image = New Bitmap(My.Resources.Drug_Hold)
        Else
            btn_drug.Image = Nothing
        End If

        If Menu_Selected = 3 Then
            btn_finan.Image = New Bitmap(My.Resources.Finan_Hold)
        Else
            btn_finan.Image = Nothing
        End If

        If Menu_Selected = 4 Then
            btn_emp.Image = New Bitmap(My.Resources.Emp_Hold)
        Else
            btn_emp.Image = Nothing
        End If

        If Menu_Selected = 5 Then
            btn_admin.Image = New Bitmap(My.Resources.Admin_Hold)
        Else
            btn_admin.Image = Nothing
        End If
    End Sub
End Class

Public Class DblBufferedPanel
    Inherits Panel
    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
End Class