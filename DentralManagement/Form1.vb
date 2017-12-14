Imports System.Data.SqlClient
Public Class Form1

    Dim MaxRe As Boolean = False
    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer
    Dim Default_Gray As Color
    Dim User_ID As String
    Dim User_name As String
    Dim Priv_Class As String
    Dim tble_ucp As New DataTable("Table")

    Dim index As Integer
    'Dim Menu_Selected As String

    'SQL SERVER CONNECTION'
    Dim connection As New SqlConnection("Data Source=tcp:192.168.6.11, 1433;Database=sedentral;User ID=se_admin;Password=Dentis1234;")

    'END SQL SERVER CONNECTION'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Se_dentral_sql3.Finan' table. You can move, or remove it, as needed.
        Me.FinanTableAdapter.Fillless(Me.Se_dentral_sql3.Finan)
        'TODO: This line of code loads data into the 'Se_dentral_sql1.Medi_supplies' table. You can move, or remove it, as needed.
        Me.Medi_suppliesTableAdapter.Fill(Me.Se_dentral_sql1.Medi_supplies)

        'TODO: This line of code loads data into the 'Se_dentral_sql1.Finan' table. You can move, or remove it, as needed.
        Me.FinanTableAdapter.FillBy(Me.Se_dentral_sql1.Finan)

        'TODO: This line of code loads data into the 'Se_dentral_sql.Emp_dept' table. You can move, or remove it, as needed.
        Me.Emp_deptTableAdapter.Fill(Me.Se_dentral_sql.Emp_dept)
        'TODO: This line of code loads data into the 'Se_dentral_sql.Emp_list' table. You can move, or remove it, as needed.
        Me.Emp_listTableAdapter.Fill(Me.Se_dentral_sql.Emp_list)
        'TODO: This line of code loads data into the 'Se_dentral_sql.User_data' table. You can move, or remove it, as needed.
        Me.User_dataTableAdapter.Fill(Me.Se_dentral_sql.User_data)
        'TODO: This line of code loads data into the 'Se_dentral_sql.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter1.FillEmpDep(Me.Se_dentral_sql.DataTable1)
        'User_dataTableAdapter.Fill(Se_dentral_sql.User_data)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        UpdateStyles()

        tble_ucp = Se_dentral_sql.User_data.CopyToDataTable

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
            rec_id_card.Text = text_search
            rec_fname.Text = read_record("patient_Fname").ToString
            rec_lname.Text = read_record("patient_Lname").ToString
            cb_rec_sex.Text = read_record("patient_Grender").ToString
            rec_fname.Text = read_record("patient_Wight").ToString
            rec_fname.Text = read_record("patient_Height").ToString
            rec_fname.Text = read_record("patient_allergic_druge").ToString
            rec_fname.Text = read_record("patient_id_card").ToString
            rec_fname.Text = read_record("patient_nation").ToString
            rec_fname.Text = read_record("patient_ethicty").ToString
            rec_fname.Text = read_record("patient_regal").ToString
            rec_fname.Text = read_record("patient_tel").ToString
            rec_fname.Text = read_record("patient_tel_home").ToString
            rec_fname.Text = read_record("contact_fname").ToString
            rec_fname.Text = read_record("contact_lname").ToString
            rec_fname.Text = read_record("contact_tel").ToString
            rec_fname.Text = read_record("contact_relation").ToString
        Else
            rec_id_card.Text = text_search + " ไม่พบในรายการ จะเพิ่มรายการหรือไม่?"
            Button_add.Visible = True
        End If
        Set_Panel(Record_2)
        connection.Close()

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
            Else
                btn_admin.BackColor = Default_Gray
                btn_admin.Cursor = Cursors.Default
            End If

            Dim load_name As New SqlCommand("Select [Emp_Fname],[Emp_Lname] from [dbo].[Employee] Where [Emp_ID] = '" & read("Fori_User_Id").ToString & "'", connection)
            read.Close()
            Dim read_emp As SqlDataReader = load_name.ExecuteReader()
            If read_emp.Read() Then
                Dim fname As String = read_emp("Emp_Fname").ToString()
                Dim lname As String = read_emp("Emp_Lname").ToString()
                User_name = fname + " " + lname
                usern.Text = User_name
                Set_Panel(Home)
                Set_Button_Hold(0)
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
        Set_Panel(Drug1)
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
        Drug1.Visible = False
        Record_5.Visible = False
        Drug2.Visible = False
        Admin.Visible = False
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

    Private Sub admin_refresh_Click(sender As Object, e As EventArgs) Handles admin_refresh.Click
        data_User.DataSource = Nothing
        data_User.DataSource = Se_dentral_sql.User_data.CopyToDataTable
        tble_ucp = Se_dentral_sql.User_data.CopyToDataTable
        data_User.Refresh()
    End Sub

    Private Sub UserBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Min_Click(sender As Object, e As MouseEventArgs) Handles btn_Min.MouseClick

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As MouseEventArgs) Handles btn_Exit.MouseClick

    End Sub

    Private Sub btn_MaxRe_Click(sender As Object, e As MouseEventArgs) Handles btn_MaxRe.MouseClick

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (IsInDatagridview(tb_add_user.Text, tb_add_pass.Text, 0, 1, data_User)) Then

            ''// Code to display message.
            MsgBox("Record Exists!", MsgBoxStyle.Information)

        Else
            tble_ucp.Rows.Add(tb_add_user.Text, tb_add_pass.Text, cb_add_emp.DisplayMember, cb_add_access.SelectedIndex)

        End If
        data_User.DataSource = tble_ucp
    End Sub

    Private Sub data_User_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_User.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = data_User.Rows(index)
        tb_add_user.Text = selectedRow.Cells(0).Value.ToString()
        tb_add_pass.Text = selectedRow.Cells(1).Value.ToString()
        cb_add_emp.SelectedText = selectedRow.Cells(2).Value.ToString()
        cb_add_access.SelectedIndex = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub rec_relationship_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles rec_tel2.TextChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles search_emp.TextChanged
        Me.Emp_deptTableAdapter.FillBy(Me.Se_dentral_sql.Emp_dept, search_emp.Text, search_emp.Text, search_emp.Text, search_emp.Text)
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

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

    Private Sub user_update_Click(sender As Object, e As EventArgs) Handles user_update.Click
        'data_User.Update((DataTable) UserdataBindingSource.DataSource)
    End Sub

    Private Sub user_edits_1(sender As Object, e As EventArgs) Handles user_edits.Click
        Dim newData As DataGridViewRow
        newData = data_User.Rows(index)
        newData.Cells(0).Value = tb_add_user.Text
        newData.Cells(1).Value = tb_add_pass.Text
        newData.Cells(2).Value = cb_add_emp.SelectedText
        newData.Cells(3).Value = cb_add_access.SelectedIndex
    End Sub

    Private Sub user_remove_Click(sender As Object, e As EventArgs) Handles user_remove.Click
        Dim nD As DataGridViewRow = data_User.Rows(index)
    End Sub

    Private Sub rec_btn_add_Click(sender As Object, e As EventArgs) Handles rec_btn_add.Click
        Detail.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim text_search As String = tb_list.Text
        connection.Open()
        Dim tb_search_command As New SqlCommand("Select * from [dbo].[report] where [report_id] = '" & text_search & "'", connection)
        Dim read_report As SqlDataReader = tb_search_command.ExecuteReader()

        If read_report.Read() Then
            tb_detail.Text = read_report("report_detail").ToString()
            Set_Panel(Record_3)
        Else
            MsgBox("ไม่พบรายการรักษารหัสนี้")
        End If
        connection.Close()

    End Sub

    Private Sub rec_next_Click(sender As Object, e As EventArgs) Handles rec_next.Click

        connection.Open()
        Dim rec_3_1 As New SqlCommand("SELECT count(*) FROM report", connection)
        Dim read_report As Int16 = rec_3_1.ExecuteScalar()

        Label33.Text = read_report + 1


        connection.Close()
        Set_Panel(Record_3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Set_Panel(Record_5)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connection.Open()
        Dim rec_3_1 As New SqlCommand("SELECT count(*) FROM report", connection)
        Dim read_report As Int16 = rec_3_1.ExecuteScalar()

        Label33.Text = read_report + 1


        connection.Close()
        Set_Panel(Record_3)
    End Sub

    Private Sub CountToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ReportTableAdapter.Count(Me.Se_dentral_sql3.report)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Function IsInDatagridview(ByVal cell1 As String, ByVal cell2 As String, ByVal rowCell1_ID As Integer, ByVal rowCell2_ID As Integer, ByRef dgv As DataGridView)

        Dim isFound As Boolean = False

        For Each rw As DataGridViewRow In dgv.Rows
            If rw.Cells(rowCell1_ID).Value.ToString = cell1 Then
                If rw.Cells(rowCell2_ID).Value.ToString = cell2 Then

                    isFound = True
                    Return isFound


                End If
            End If
        Next

        Return isFound

    End Function

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