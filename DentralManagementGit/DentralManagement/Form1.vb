Imports System.Data.SqlClient
Public Class Form1

    Dim MaxRe As Boolean = False
    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer
    Dim Default_Gray As Color
    Dim User_ID As String
    Dim User_name As String
    Dim Priv_Class As String

    'SQL SERVER CONNECTION'
    Dim connection As New SqlConnection("Data Source=tcp:192.168.6.2, 1433;Database=sedentral;User ID=se_admin;Password=Dentis1234;")

    'END SQL SERVER CONNECTION'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.uiMode = "none"
        Default_Gray = Color.FromArgb(126, 139, 154)
        btn_admin.BackColor = Default_Gray

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Login_MouseDown(sender As Object, e As MouseEventArgs)
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Down)
    End Sub

    Private Sub btn_Login_MouseUp(sender As Object, e As MouseEventArgs)
        btn_Login.BackgroundImage = New Bitmap(My.Resources.Login_Default)
    End Sub

    Private Sub btn_Exit_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Exit.MouseDown
        btn_Exit.BackgroundImage = New Bitmap(My.Resources.Exit_Down)
    End Sub

    Private Sub btn_Exit_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Exit.MouseUp
        btn_Exit.BackgroundImage = New Bitmap(My.Resources.Exit_Default)
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
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

    Private Sub btn_MaxRe_Click(sender As Object, e As EventArgs) Handles btn_MaxRe.Click
        If MaxRe Then
            Me.WindowState = FormWindowState.Normal
            MaxRe = False
        Else
            Me.WindowState = FormWindowState.Maximized
            MaxRe = True
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X -= (X)
            point.Y -= (Y)
            Me.Location = point
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btn_Min_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Min.MouseDown
        btn_Min.BackgroundImage = New Bitmap(My.Resources.Min_Down)
    End Sub

    Private Sub btn_Min_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Min.MouseUp
        btn_Min.BackgroundImage = New Bitmap(My.Resources.Min_Default)
    End Sub

    Private Sub btn_Min_Click(sender As Object, e As EventArgs) Handles btn_Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        connection.Open()
        Dim load_user As New SqlCommand("Select * from [dbo].[User] Where [User_Pass]='" &, connection)
        Dim read As SqlDataReader = load_user.ExecuteReader()
        While True
            If Username.SelectedValue = Username Then

            End If

        End While




        connection.Close()
    End Sub
End Class