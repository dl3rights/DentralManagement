<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Sedentral_sql = New DentralManagement.sedentral_sql()
        Me.UsereditBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsereditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_editTableAdapter = New DentralManagement.sedentral_sqlTableAdapters.user_editTableAdapter()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New DentralManagement.sedentral_sqlTableAdapters.DataTable1TableAdapter()
        Me.U = New DentralManagement.DblBufferedPanel()
        Me.Admin = New DentralManagement.DblBufferedPanel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cb_add_access = New System.Windows.Forms.ComboBox()
        Me.cb_add_emp = New System.Windows.Forms.ComboBox()
        Me.tb_add_pass = New System.Windows.Forms.TextBox()
        Me.tb_add_user = New System.Windows.Forms.TextBox()
        Me.admin_refresh = New System.Windows.Forms.Button()
        Me.data_User = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.พนักงาน = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserAccessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug = New DentralManagement.DblBufferedPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Employee = New DentralManagement.DblBufferedPanel()
        Me.Finan = New DentralManagement.DblBufferedPanel()
        Me.Record_2 = New DentralManagement.DblBufferedPanel()
        Me.Button_add = New DentralManagement.DblBufferedPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Detail = New DentralManagement.DblBufferedPanel()
        Me.rec_other_relation = New System.Windows.Forms.Label()
        Me.rec_other_tel2 = New System.Windows.Forms.Label()
        Me.rec_other_tel1 = New System.Windows.Forms.Label()
        Me.rec_other_lname = New System.Windows.Forms.Label()
        Me.rec_other_fname = New System.Windows.Forms.Label()
        Me.rec_access_health = New System.Windows.Forms.Label()
        Me.rec_allergic = New System.Windows.Forms.Label()
        Me.rec_tel_job = New System.Windows.Forms.Label()
        Me.rec_address_job = New System.Windows.Forms.Label()
        Me.rec_tel2 = New System.Windows.Forms.Label()
        Me.rec_tel1 = New System.Windows.Forms.Label()
        Me.rec_address = New System.Windows.Forms.Label()
        Me.rec_religion = New System.Windows.Forms.Label()
        Me.rac_nation = New System.Windows.Forms.Label()
        Me.rec_race = New System.Windows.Forms.Label()
        Me.rec_relationship = New System.Windows.Forms.Label()
        Me.rec_job = New System.Windows.Forms.Label()
        Me.rec_blood = New System.Windows.Forms.Label()
        Me.rec_age = New System.Windows.Forms.Label()
        Me.rec_birth = New System.Windows.Forms.Label()
        Me.rec_sex = New System.Windows.Forms.Label()
        Me.rec_lname = New System.Windows.Forms.Label()
        Me.rec_fname = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rec_id_card = New System.Windows.Forms.Label()
        Me.label00123 = New System.Windows.Forms.Label()
        Me.Record_3 = New DentralManagement.DblBufferedPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ชื่อ = New System.Windows.Forms.Label()
        Me.Record_1 = New DentralManagement.DblBufferedPanel()
        Me.btn_search_rec = New System.Windows.Forms.Button()
        Me.tb_idcard_search = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Record_4 = New DentralManagement.DblBufferedPanel()
        Me.Home = New DentralManagement.DblBufferedPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Menu_Tool = New DentralManagement.DblBufferedPanel()
        Me.sub_menu = New DentralManagement.DblBufferedPanel()
        Me.btn_admin = New System.Windows.Forms.PictureBox()
        Me.btn_emp = New System.Windows.Forms.PictureBox()
        Me.btn_finan = New System.Windows.Forms.PictureBox()
        Me.btn_drug = New System.Windows.Forms.PictureBox()
        Me.btn_record = New System.Windows.Forms.PictureBox()
        Me.User_g = New DentralManagement.DblBufferedPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.usern = New System.Windows.Forms.Label()
        Me.UsereditBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_p = New DentralManagement.DblBufferedPanel()
        Me.Login_gui = New DentralManagement.DblBufferedPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.Taskbar = New DentralManagement.DblBufferedPanel()
        Me.Tool = New DentralManagement.DblBufferedPanel()
        Me.btn_Min = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_MaxRe = New System.Windows.Forms.Button()
        CType(Me.Sedentral_sql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsereditBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsereditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.U.SuspendLayout()
        Me.Admin.SuspendLayout()
        CType(Me.data_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Drug.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Record_2.SuspendLayout()
        Me.Button_add.SuspendLayout()
        Me.Detail.SuspendLayout()
        Me.Record_3.SuspendLayout()
        Me.Record_1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_Tool.SuspendLayout()
        Me.sub_menu.SuspendLayout()
        CType(Me.btn_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_finan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_drug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_record, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_g.SuspendLayout()
        CType(Me.UsereditBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Login_p.SuspendLayout()
        Me.Login_gui.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Taskbar.SuspendLayout()
        Me.Tool.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sedentral_sql
        '
        Me.Sedentral_sql.DataSetName = "sedentral_sql"
        Me.Sedentral_sql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsereditBindingSource1
        '
        Me.UsereditBindingSource1.DataMember = "user_edit"
        Me.UsereditBindingSource1.DataSource = Me.Sedentral_sql
        '
        'UsereditBindingSource
        '
        Me.UsereditBindingSource.DataMember = "user_edit"
        Me.UsereditBindingSource.DataSource = Me.Sedentral_sql
        '
        'User_editTableAdapter
        '
        Me.User_editTableAdapter.ClearBeforeFill = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Sedentral_sql
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'U
        '
        Me.U.Controls.Add(Me.Admin)
        Me.U.Controls.Add(Me.Drug)
        Me.U.Controls.Add(Me.Employee)
        Me.U.Controls.Add(Me.Finan)
        Me.U.Controls.Add(Me.Record_2)
        Me.U.Controls.Add(Me.Record_3)
        Me.U.Controls.Add(Me.Record_1)
        Me.U.Controls.Add(Me.Record_4)
        Me.U.Controls.Add(Me.Home)
        Me.U.Controls.Add(Me.Menu_Tool)
        Me.U.Dock = System.Windows.Forms.DockStyle.Fill
        Me.U.Location = New System.Drawing.Point(0, 45)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(1024, 723)
        Me.U.TabIndex = 1
        Me.U.Visible = False
        '
        'Admin
        '
        Me.Admin.Controls.Add(Me.Label36)
        Me.Admin.Controls.Add(Me.btn_add)
        Me.Admin.Controls.Add(Me.cb_add_access)
        Me.Admin.Controls.Add(Me.cb_add_emp)
        Me.Admin.Controls.Add(Me.tb_add_pass)
        Me.Admin.Controls.Add(Me.tb_add_user)
        Me.Admin.Controls.Add(Me.admin_refresh)
        Me.Admin.Controls.Add(Me.data_User)
        Me.Admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Admin.Location = New System.Drawing.Point(200, 0)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(824, 723)
        Me.Admin.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(60, 306)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 27)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "Label36"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(698, 324)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(103, 35)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add/Save"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cb_add_access
        '
        Me.cb_add_access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_add_access.FormattingEnabled = True
        Me.cb_add_access.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cb_add_access.Location = New System.Drawing.Point(698, 283)
        Me.cb_add_access.Name = "cb_add_access"
        Me.cb_add_access.Size = New System.Drawing.Size(102, 35)
        Me.cb_add_access.TabIndex = 5
        '
        'cb_add_emp
        '
        Me.cb_add_emp.DataSource = Me.DataTable1BindingSource
        Me.cb_add_emp.DisplayMember = "พนักงาน"
        Me.cb_add_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_add_emp.FormattingEnabled = True
        Me.cb_add_emp.Location = New System.Drawing.Point(537, 284)
        Me.cb_add_emp.Name = "cb_add_emp"
        Me.cb_add_emp.Size = New System.Drawing.Size(155, 35)
        Me.cb_add_emp.TabIndex = 4
        Me.cb_add_emp.ValueMember = "Emp_ID"
        '
        'tb_add_pass
        '
        Me.tb_add_pass.Location = New System.Drawing.Point(431, 286)
        Me.tb_add_pass.Multiline = True
        Me.tb_add_pass.Name = "tb_add_pass"
        Me.tb_add_pass.Size = New System.Drawing.Size(100, 32)
        Me.tb_add_pass.TabIndex = 3
        '
        'tb_add_user
        '
        Me.tb_add_user.Location = New System.Drawing.Point(328, 286)
        Me.tb_add_user.Multiline = True
        Me.tb_add_user.Name = "tb_add_user"
        Me.tb_add_user.Size = New System.Drawing.Size(100, 32)
        Me.tb_add_user.TabIndex = 2
        '
        'admin_refresh
        '
        Me.admin_refresh.Location = New System.Drawing.Point(214, 30)
        Me.admin_refresh.Name = "admin_refresh"
        Me.admin_refresh.Size = New System.Drawing.Size(78, 35)
        Me.admin_refresh.TabIndex = 1
        Me.admin_refresh.Text = "Refresh"
        Me.admin_refresh.UseVisualStyleBackColor = True
        '
        'data_User
        '
        Me.data_User.AllowUserToAddRows = False
        Me.data_User.AutoGenerateColumns = False
        Me.data_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserPassDataGridViewTextBoxColumn, Me.พนักงาน, Me.UserAccessDataGridViewTextBoxColumn})
        Me.data_User.DataSource = Me.UsereditBindingSource
        Me.data_User.Location = New System.Drawing.Point(304, 23)
        Me.data_User.Name = "data_User"
        Me.data_User.Size = New System.Drawing.Size(493, 257)
        Me.data_User.TabIndex = 0
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'UserPassDataGridViewTextBoxColumn
        '
        Me.UserPassDataGridViewTextBoxColumn.DataPropertyName = "User_Pass"
        Me.UserPassDataGridViewTextBoxColumn.HeaderText = "User_Pass"
        Me.UserPassDataGridViewTextBoxColumn.Name = "UserPassDataGridViewTextBoxColumn"
        '
        'พนักงาน
        '
        Me.พนักงาน.DataPropertyName = "Emp_ID"
        Me.พนักงาน.DataSource = Me.DataTable1BindingSource1
        Me.พนักงาน.DisplayMember = "พนักงาน"
        Me.พนักงาน.HeaderText = "พนักงาน"
        Me.พนักงาน.Name = "พนักงาน"
        Me.พนักงาน.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.พนักงาน.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.พนักงาน.ValueMember = "Emp_ID"
        Me.พนักงาน.Width = 150
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.Sedentral_sql
        '
        'UserAccessDataGridViewTextBoxColumn
        '
        Me.UserAccessDataGridViewTextBoxColumn.DataPropertyName = "User_Access"
        Me.UserAccessDataGridViewTextBoxColumn.HeaderText = "User_Access"
        Me.UserAccessDataGridViewTextBoxColumn.Name = "UserAccessDataGridViewTextBoxColumn"
        '
        'Drug
        '
        Me.Drug.Controls.Add(Me.DataGridView1)
        Me.Drug.Controls.Add(Me.DateTimePicker1)
        Me.Drug.Controls.Add(Me.Label34)
        Me.Drug.Controls.Add(Me.CheckBox1)
        Me.Drug.Controls.Add(Me.Button6)
        Me.Drug.Controls.Add(Me.Button7)
        Me.Drug.Controls.Add(Me.Button8)
        Me.Drug.Controls.Add(Me.TextBox2)
        Me.Drug.Controls.Add(Me.Label35)
        Me.Drug.Controls.Add(Me.Button9)
        Me.Drug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Drug.Location = New System.Drawing.Point(200, 0)
        Me.Drug.Name = "Drug"
        Me.Drug.Size = New System.Drawing.Size(824, 723)
        Me.Drug.TabIndex = 166
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(273, 395)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 34)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(230, 392)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(37, 27)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "วันที่"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(43, 391)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 31)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "ลงเวลานัดหมายครั้งต่อไป"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(631, 436)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 34)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "เสร็จสิ้น"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("RSU TEXT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(140, 340)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 30)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "ลบรายการ"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("RSU TEXT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(43, 340)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 30)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "เพิ่มรายการ"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 34)
        Me.TextBox2.TabIndex = 16
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(38, 147)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 27)
        Me.Label35.TabIndex = 15
        Me.Label35.Text = "ใบรายการเลขที่"
        '
        'Button9
        '
        Me.Button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(30, 24)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(104, 33)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "ย้อนกลับ"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Employee.Location = New System.Drawing.Point(200, 0)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(824, 723)
        Me.Employee.TabIndex = 1
        '
        'Finan
        '
        Me.Finan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Finan.Location = New System.Drawing.Point(200, 0)
        Me.Finan.Name = "Finan"
        Me.Finan.Size = New System.Drawing.Size(824, 723)
        Me.Finan.TabIndex = 23
        '
        'Record_2
        '
        Me.Record_2.BackColor = System.Drawing.Color.Transparent
        Me.Record_2.Controls.Add(Me.Button_add)
        Me.Record_2.Controls.Add(Me.Detail)
        Me.Record_2.Controls.Add(Me.rec_id_card)
        Me.Record_2.Controls.Add(Me.label00123)
        Me.Record_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_2.Location = New System.Drawing.Point(200, 0)
        Me.Record_2.Name = "Record_2"
        Me.Record_2.Size = New System.Drawing.Size(824, 723)
        Me.Record_2.TabIndex = 1
        '
        'Button_add
        '
        Me.Button_add.Controls.Add(Me.Button1)
        Me.Button_add.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_add.Location = New System.Drawing.Point(516, 0)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(308, 150)
        Me.Button_add.TabIndex = 122
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "เพิ่มแฟ้มข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Detail
        '
        Me.Detail.Controls.Add(Me.rec_other_relation)
        Me.Detail.Controls.Add(Me.rec_other_tel2)
        Me.Detail.Controls.Add(Me.rec_other_tel1)
        Me.Detail.Controls.Add(Me.rec_other_lname)
        Me.Detail.Controls.Add(Me.rec_other_fname)
        Me.Detail.Controls.Add(Me.rec_access_health)
        Me.Detail.Controls.Add(Me.rec_allergic)
        Me.Detail.Controls.Add(Me.rec_tel_job)
        Me.Detail.Controls.Add(Me.rec_address_job)
        Me.Detail.Controls.Add(Me.rec_tel2)
        Me.Detail.Controls.Add(Me.rec_tel1)
        Me.Detail.Controls.Add(Me.rec_address)
        Me.Detail.Controls.Add(Me.rec_religion)
        Me.Detail.Controls.Add(Me.rac_nation)
        Me.Detail.Controls.Add(Me.rec_race)
        Me.Detail.Controls.Add(Me.rec_relationship)
        Me.Detail.Controls.Add(Me.rec_job)
        Me.Detail.Controls.Add(Me.rec_blood)
        Me.Detail.Controls.Add(Me.rec_age)
        Me.Detail.Controls.Add(Me.rec_birth)
        Me.Detail.Controls.Add(Me.rec_sex)
        Me.Detail.Controls.Add(Me.rec_lname)
        Me.Detail.Controls.Add(Me.rec_fname)
        Me.Detail.Controls.Add(Me.Label24)
        Me.Detail.Controls.Add(Me.Label10)
        Me.Detail.Controls.Add(Me.Label15)
        Me.Detail.Controls.Add(Me.Label27)
        Me.Detail.Controls.Add(Me.Label5)
        Me.Detail.Controls.Add(Me.Label26)
        Me.Detail.Controls.Add(Me.Label4)
        Me.Detail.Controls.Add(Me.Label25)
        Me.Detail.Controls.Add(Me.Label8)
        Me.Detail.Controls.Add(Me.Label21)
        Me.Detail.Controls.Add(Me.Label7)
        Me.Detail.Controls.Add(Me.Label20)
        Me.Detail.Controls.Add(Me.Label11)
        Me.Detail.Controls.Add(Me.Label6)
        Me.Detail.Controls.Add(Me.Label9)
        Me.Detail.Controls.Add(Me.Label23)
        Me.Detail.Controls.Add(Me.Label12)
        Me.Detail.Controls.Add(Me.Label14)
        Me.Detail.Controls.Add(Me.Label13)
        Me.Detail.Controls.Add(Me.Label19)
        Me.Detail.Controls.Add(Me.Label16)
        Me.Detail.Controls.Add(Me.Label18)
        Me.Detail.Controls.Add(Me.Label22)
        Me.Detail.Controls.Add(Me.Label17)
        Me.Detail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Detail.Location = New System.Drawing.Point(0, 150)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(824, 573)
        Me.Detail.TabIndex = 121
        '
        'rec_other_relation
        '
        Me.rec_other_relation.AutoSize = True
        Me.rec_other_relation.Location = New System.Drawing.Point(143, 476)
        Me.rec_other_relation.Name = "rec_other_relation"
        Me.rec_other_relation.Size = New System.Drawing.Size(33, 27)
        Me.rec_other_relation.TabIndex = 165
        Me.rec_other_relation.Text = "Test"
        '
        'rec_other_tel2
        '
        Me.rec_other_tel2.AutoSize = True
        Me.rec_other_tel2.Location = New System.Drawing.Point(363, 444)
        Me.rec_other_tel2.Name = "rec_other_tel2"
        Me.rec_other_tel2.Size = New System.Drawing.Size(33, 27)
        Me.rec_other_tel2.TabIndex = 164
        Me.rec_other_tel2.Text = "Test"
        '
        'rec_other_tel1
        '
        Me.rec_other_tel1.AutoSize = True
        Me.rec_other_tel1.Location = New System.Drawing.Point(110, 445)
        Me.rec_other_tel1.Name = "rec_other_tel1"
        Me.rec_other_tel1.Size = New System.Drawing.Size(33, 27)
        Me.rec_other_tel1.TabIndex = 163
        Me.rec_other_tel1.Text = "Test"
        '
        'rec_other_lname
        '
        Me.rec_other_lname.AutoSize = True
        Me.rec_other_lname.Location = New System.Drawing.Point(336, 414)
        Me.rec_other_lname.Name = "rec_other_lname"
        Me.rec_other_lname.Size = New System.Drawing.Size(33, 27)
        Me.rec_other_lname.TabIndex = 162
        Me.rec_other_lname.Text = "Test"
        '
        'rec_other_fname
        '
        Me.rec_other_fname.AutoSize = True
        Me.rec_other_fname.Location = New System.Drawing.Point(79, 413)
        Me.rec_other_fname.Name = "rec_other_fname"
        Me.rec_other_fname.Size = New System.Drawing.Size(33, 27)
        Me.rec_other_fname.TabIndex = 161
        Me.rec_other_fname.Text = "Test"
        '
        'rec_access_health
        '
        Me.rec_access_health.AutoSize = True
        Me.rec_access_health.Location = New System.Drawing.Point(143, 311)
        Me.rec_access_health.Name = "rec_access_health"
        Me.rec_access_health.Size = New System.Drawing.Size(33, 27)
        Me.rec_access_health.TabIndex = 160
        Me.rec_access_health.Text = "Test"
        '
        'rec_allergic
        '
        Me.rec_allergic.AutoSize = True
        Me.rec_allergic.Location = New System.Drawing.Point(159, 281)
        Me.rec_allergic.Name = "rec_allergic"
        Me.rec_allergic.Size = New System.Drawing.Size(33, 27)
        Me.rec_allergic.TabIndex = 159
        Me.rec_allergic.Text = "Test"
        '
        'rec_tel_job
        '
        Me.rec_tel_job.AutoSize = True
        Me.rec_tel_job.Location = New System.Drawing.Point(159, 249)
        Me.rec_tel_job.Name = "rec_tel_job"
        Me.rec_tel_job.Size = New System.Drawing.Size(33, 27)
        Me.rec_tel_job.TabIndex = 158
        Me.rec_tel_job.Text = "Test"
        '
        'rec_address_job
        '
        Me.rec_address_job.AutoSize = True
        Me.rec_address_job.Location = New System.Drawing.Point(143, 219)
        Me.rec_address_job.Name = "rec_address_job"
        Me.rec_address_job.Size = New System.Drawing.Size(33, 27)
        Me.rec_address_job.TabIndex = 157
        Me.rec_address_job.Text = "Test"
        '
        'rec_tel2
        '
        Me.rec_tel2.AutoSize = True
        Me.rec_tel2.Location = New System.Drawing.Point(363, 187)
        Me.rec_tel2.Name = "rec_tel2"
        Me.rec_tel2.Size = New System.Drawing.Size(33, 27)
        Me.rec_tel2.TabIndex = 156
        Me.rec_tel2.Text = "Test"
        '
        'rec_tel1
        '
        Me.rec_tel1.AutoSize = True
        Me.rec_tel1.Location = New System.Drawing.Point(111, 187)
        Me.rec_tel1.Name = "rec_tel1"
        Me.rec_tel1.Size = New System.Drawing.Size(33, 27)
        Me.rec_tel1.TabIndex = 155
        Me.rec_tel1.Text = "Test"
        '
        'rec_address
        '
        Me.rec_address.AutoSize = True
        Me.rec_address.Location = New System.Drawing.Point(131, 156)
        Me.rec_address.Name = "rec_address"
        Me.rec_address.Size = New System.Drawing.Size(33, 27)
        Me.rec_address.TabIndex = 154
        Me.rec_address.Text = "Test"
        '
        'rec_religion
        '
        Me.rec_religion.AutoSize = True
        Me.rec_religion.Location = New System.Drawing.Point(581, 125)
        Me.rec_religion.Name = "rec_religion"
        Me.rec_religion.Size = New System.Drawing.Size(33, 27)
        Me.rec_religion.TabIndex = 153
        Me.rec_religion.Text = "Test"
        '
        'rac_nation
        '
        Me.rac_nation.AutoSize = True
        Me.rac_nation.Location = New System.Drawing.Point(336, 125)
        Me.rac_nation.Name = "rac_nation"
        Me.rac_nation.Size = New System.Drawing.Size(33, 27)
        Me.rac_nation.TabIndex = 152
        Me.rac_nation.Text = "Test"
        '
        'rec_race
        '
        Me.rec_race.AutoSize = True
        Me.rec_race.Location = New System.Drawing.Point(115, 125)
        Me.rec_race.Name = "rec_race"
        Me.rec_race.Size = New System.Drawing.Size(33, 27)
        Me.rec_race.TabIndex = 151
        Me.rec_race.Text = "Test"
        '
        'rec_relationship
        '
        Me.rec_relationship.AutoSize = True
        Me.rec_relationship.Location = New System.Drawing.Point(595, 95)
        Me.rec_relationship.Name = "rec_relationship"
        Me.rec_relationship.Size = New System.Drawing.Size(33, 27)
        Me.rec_relationship.TabIndex = 150
        Me.rec_relationship.Text = "Test"
        '
        'rec_job
        '
        Me.rec_job.AutoSize = True
        Me.rec_job.Location = New System.Drawing.Point(320, 95)
        Me.rec_job.Name = "rec_job"
        Me.rec_job.Size = New System.Drawing.Size(33, 27)
        Me.rec_job.TabIndex = 149
        Me.rec_job.Text = "Test"
        '
        'rec_blood
        '
        Me.rec_blood.AutoSize = True
        Me.rec_blood.Location = New System.Drawing.Point(115, 94)
        Me.rec_blood.Name = "rec_blood"
        Me.rec_blood.Size = New System.Drawing.Size(33, 27)
        Me.rec_blood.TabIndex = 148
        Me.rec_blood.Text = "Test"
        '
        'rec_age
        '
        Me.rec_age.AutoSize = True
        Me.rec_age.Location = New System.Drawing.Point(564, 63)
        Me.rec_age.Name = "rec_age"
        Me.rec_age.Size = New System.Drawing.Size(33, 27)
        Me.rec_age.TabIndex = 147
        Me.rec_age.Text = "Test"
        '
        'rec_birth
        '
        Me.rec_birth.AutoSize = True
        Me.rec_birth.Location = New System.Drawing.Point(373, 63)
        Me.rec_birth.Name = "rec_birth"
        Me.rec_birth.Size = New System.Drawing.Size(33, 27)
        Me.rec_birth.TabIndex = 146
        Me.rec_birth.Text = "Test"
        '
        'rec_sex
        '
        Me.rec_sex.AutoSize = True
        Me.rec_sex.Location = New System.Drawing.Point(80, 63)
        Me.rec_sex.Name = "rec_sex"
        Me.rec_sex.Size = New System.Drawing.Size(33, 27)
        Me.rec_sex.TabIndex = 145
        Me.rec_sex.Text = "Test"
        '
        'rec_lname
        '
        Me.rec_lname.AutoSize = True
        Me.rec_lname.Location = New System.Drawing.Point(336, 32)
        Me.rec_lname.Name = "rec_lname"
        Me.rec_lname.Size = New System.Drawing.Size(33, 27)
        Me.rec_lname.TabIndex = 144
        Me.rec_lname.Text = "Test"
        '
        'rec_fname
        '
        Me.rec_fname.AutoSize = True
        Me.rec_fname.Location = New System.Drawing.Point(75, 32)
        Me.rec_fname.Name = "rec_fname"
        Me.rec_fname.Size = New System.Drawing.Size(33, 27)
        Me.rec_fname.TabIndex = 143
        Me.rec_fname.Text = "Test"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label24.Location = New System.Drawing.Point(37, 472)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 31)
        Me.Label24.TabIndex = 142
        Me.Label24.Text = "เกี่ยวข้องเป็น :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(257, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 31)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "สัญชาติ : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label15.Location = New System.Drawing.Point(36, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 31)
        Me.Label15.TabIndex = 141
        Me.Label15.Text = "สถานที่ทำงาน :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label27.Location = New System.Drawing.Point(36, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 31)
        Me.Label27.TabIndex = 140
        Me.Label27.Text = "ชื่อ : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(510, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 31)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "อายุ :               ปี "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label26.Location = New System.Drawing.Point(257, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 31)
        Me.Label26.TabIndex = 120
        Me.Label26.Text = "นามสกุล : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(257, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 31)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "วัน เดือน ปีเกิด : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label25.Location = New System.Drawing.Point(37, 410)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 31)
        Me.Label25.TabIndex = 121
        Me.Label25.Text = "ชื่อ : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(510, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 31)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "สถานภาพ : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label21.Location = New System.Drawing.Point(258, 410)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 31)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "นามสกุล : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(258, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 31)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "อาชีพ : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label20.Location = New System.Drawing.Point(36, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 31)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "เพศ : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label11.Location = New System.Drawing.Point(510, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 31)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "ศาสนา : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(36, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 31)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "หมู่เลือด : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label9.Location = New System.Drawing.Point(36, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 31)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "เชื้อชาติ : "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label23.Location = New System.Drawing.Point(258, 441)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 31)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "โทรศัพท์มือถือ :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label12.Location = New System.Drawing.Point(36, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 31)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "ที่อยู่ปัจจุบัน :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label14.Location = New System.Drawing.Point(257, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 31)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "โทรศัพท์มือถือ :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label13.Location = New System.Drawing.Point(36, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 31)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "โทรศัพท์ :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label19.Location = New System.Drawing.Point(36, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(172, 31)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "บุคคลที่สามารถติดต่อได้ :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label16.Location = New System.Drawing.Point(36, 246)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 31)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "โทรศัพท์ที่ทำงาน :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label18.Location = New System.Drawing.Point(36, 308)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 31)
        Me.Label18.TabIndex = 119
        Me.Label18.Text = "สิทธิการรักษา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label22.Location = New System.Drawing.Point(37, 441)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 31)
        Me.Label22.TabIndex = 129
        Me.Label22.Text = "โทรศัพท์ :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label17.Location = New System.Drawing.Point(36, 277)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 31)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "ประวัติการเเพ้ยา :"
        '
        'rec_id_card
        '
        Me.rec_id_card.AutoSize = True
        Me.rec_id_card.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.rec_id_card.Location = New System.Drawing.Point(174, 70)
        Me.rec_id_card.Name = "rec_id_card"
        Me.rec_id_card.Size = New System.Drawing.Size(37, 27)
        Me.rec_id_card.TabIndex = 120
        Me.rec_id_card.Text = "Test"
        '
        'label00123
        '
        Me.label00123.AutoSize = True
        Me.label00123.Location = New System.Drawing.Point(46, 69)
        Me.label00123.Name = "label00123"
        Me.label00123.Size = New System.Drawing.Size(118, 27)
        Me.label00123.TabIndex = 119
        Me.label00123.Text = "เลขบัตรประชาชน :"
        '
        'Record_3
        '
        Me.Record_3.Controls.Add(Me.Button4)
        Me.Record_3.Controls.Add(Me.Button2)
        Me.Record_3.Controls.Add(Me.Button5)
        Me.Record_3.Controls.Add(Me.Label31)
        Me.Record_3.Controls.Add(Me.Label32)
        Me.Record_3.Controls.Add(Me.lname)
        Me.Record_3.Controls.Add(Me.fname)
        Me.Record_3.Controls.Add(Me.Label33)
        Me.Record_3.Controls.Add(Me.ชื่อ)
        Me.Record_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_3.Location = New System.Drawing.Point(200, 0)
        Me.Record_3.Name = "Record_3"
        Me.Record_3.Size = New System.Drawing.Size(824, 723)
        Me.Record_3.TabIndex = 167
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(645, 654)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 38)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "ต่อไป"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(508, 654)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 38)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "บันทึก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(645, 31)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 38)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "ประวัติการรักษา"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label31.Location = New System.Drawing.Point(49, 228)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(122, 31)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "ใบรายการเลขที่ :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label32.Location = New System.Drawing.Point(71, 124)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 29)
        Me.Label32.TabIndex = 14
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lname.Location = New System.Drawing.Point(358, 104)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(0, 29)
        Me.lname.TabIndex = 13
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.fname.Location = New System.Drawing.Point(100, 100)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(0, 29)
        Me.fname.TabIndex = 12
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.Label33.Location = New System.Drawing.Point(269, 102)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 31)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "นามสกุล"
        '
        'ชื่อ
        '
        Me.ชื่อ.AutoSize = True
        Me.ชื่อ.Font = New System.Drawing.Font("RSU TEXT", 20.0!)
        Me.ชื่อ.Location = New System.Drawing.Point(49, 102)
        Me.ชื่อ.Name = "ชื่อ"
        Me.ชื่อ.Size = New System.Drawing.Size(32, 31)
        Me.ชื่อ.TabIndex = 11
        Me.ชื่อ.Text = "ชื่อ"
        '
        'Record_1
        '
        Me.Record_1.Controls.Add(Me.btn_search_rec)
        Me.Record_1.Controls.Add(Me.tb_idcard_search)
        Me.Record_1.Controls.Add(Me.Label28)
        Me.Record_1.Controls.Add(Me.Label29)
        Me.Record_1.Controls.Add(Me.PictureBox4)
        Me.Record_1.Controls.Add(Me.PictureBox5)
        Me.Record_1.Controls.Add(Me.Button3)
        Me.Record_1.Controls.Add(Me.TextBox1)
        Me.Record_1.Controls.Add(Me.Label30)
        Me.Record_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_1.Location = New System.Drawing.Point(200, 0)
        Me.Record_1.Name = "Record_1"
        Me.Record_1.Size = New System.Drawing.Size(824, 723)
        Me.Record_1.TabIndex = 166
        '
        'btn_search_rec
        '
        Me.btn_search_rec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search_rec.Location = New System.Drawing.Point(633, 134)
        Me.btn_search_rec.Name = "btn_search_rec"
        Me.btn_search_rec.Size = New System.Drawing.Size(127, 33)
        Me.btn_search_rec.TabIndex = 16
        Me.btn_search_rec.Text = "ค้นหาเเฟ้มข้อมูล"
        Me.btn_search_rec.UseVisualStyleBackColor = True
        '
        'tb_idcard_search
        '
        Me.tb_idcard_search.Location = New System.Drawing.Point(254, 134)
        Me.tb_idcard_search.Name = "tb_idcard_search"
        Me.tb_idcard_search.Size = New System.Drawing.Size(360, 34)
        Me.tb_idcard_search.TabIndex = 15
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(76, 229)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 27)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "รายการดำเนินการ"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(76, 138)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(178, 27)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "รหัสบัตรประจำตัวประชาชน : "
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(20, 203)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(774, 2)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(20, 99)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(774, 2)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(633, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ค้นหา"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(254, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 34)
        Me.TextBox1.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(148, 41)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 27)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "ใบรายการนัด : "
        '
        'Record_4
        '
        Me.Record_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record_4.Location = New System.Drawing.Point(200, 0)
        Me.Record_4.Name = "Record_4"
        Me.Record_4.Size = New System.Drawing.Size(824, 723)
        Me.Record_4.TabIndex = 168
        '
        'Home
        '
        Me.Home.Controls.Add(Me.PictureBox2)
        Me.Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home.Location = New System.Drawing.Point(200, 0)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(824, 723)
        Me.Home.TabIndex = 72
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.DentralManagement.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(824, 723)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Menu_Tool
        '
        Me.Menu_Tool.BackColor = System.Drawing.Color.Transparent
        Me.Menu_Tool.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Menu
        Me.Menu_Tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Menu_Tool.Controls.Add(Me.sub_menu)
        Me.Menu_Tool.Controls.Add(Me.User_g)
        Me.Menu_Tool.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu_Tool.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Tool.Name = "Menu_Tool"
        Me.Menu_Tool.Size = New System.Drawing.Size(200, 723)
        Me.Menu_Tool.TabIndex = 2
        '
        'sub_menu
        '
        Me.sub_menu.Controls.Add(Me.btn_admin)
        Me.sub_menu.Controls.Add(Me.btn_emp)
        Me.sub_menu.Controls.Add(Me.btn_finan)
        Me.sub_menu.Controls.Add(Me.btn_drug)
        Me.sub_menu.Controls.Add(Me.btn_record)
        Me.sub_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.sub_menu.Location = New System.Drawing.Point(0, 150)
        Me.sub_menu.Name = "sub_menu"
        Me.sub_menu.Size = New System.Drawing.Size(200, 288)
        Me.sub_menu.TabIndex = 3
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_admin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_admin.Location = New System.Drawing.Point(0, 224)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(200, 63)
        Me.btn_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_admin.TabIndex = 9
        Me.btn_admin.TabStop = False
        '
        'btn_emp
        '
        Me.btn_emp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_emp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_emp.Location = New System.Drawing.Point(0, 168)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.Size = New System.Drawing.Size(200, 56)
        Me.btn_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_emp.TabIndex = 8
        Me.btn_emp.TabStop = False
        '
        'btn_finan
        '
        Me.btn_finan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_finan.Location = New System.Drawing.Point(0, 112)
        Me.btn_finan.Name = "btn_finan"
        Me.btn_finan.Size = New System.Drawing.Size(200, 56)
        Me.btn_finan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_finan.TabIndex = 7
        Me.btn_finan.TabStop = False
        '
        'btn_drug
        '
        Me.btn_drug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_drug.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_drug.Location = New System.Drawing.Point(0, 56)
        Me.btn_drug.Name = "btn_drug"
        Me.btn_drug.Size = New System.Drawing.Size(200, 56)
        Me.btn_drug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_drug.TabIndex = 6
        Me.btn_drug.TabStop = False
        '
        'btn_record
        '
        Me.btn_record.BackColor = System.Drawing.Color.Transparent
        Me.btn_record.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_record.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_record.Location = New System.Drawing.Point(0, 0)
        Me.btn_record.Name = "btn_record"
        Me.btn_record.Size = New System.Drawing.Size(200, 56)
        Me.btn_record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_record.TabIndex = 5
        Me.btn_record.TabStop = False
        '
        'User_g
        '
        Me.User_g.Controls.Add(Me.btn_logout)
        Me.User_g.Controls.Add(Me.usern)
        Me.User_g.Dock = System.Windows.Forms.DockStyle.Top
        Me.User_g.Location = New System.Drawing.Point(0, 0)
        Me.User_g.Name = "User_g"
        Me.User_g.Size = New System.Drawing.Size(200, 150)
        Me.User_g.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(119, 109)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 35)
        Me.btn_logout.TabIndex = 1
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'usern
        '
        Me.usern.AutoSize = True
        Me.usern.Font = New System.Drawing.Font("RSU TEXT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.usern.Location = New System.Drawing.Point(23, 61)
        Me.usern.Name = "usern"
        Me.usern.Size = New System.Drawing.Size(39, 27)
        Me.usern.TabIndex = 0
        Me.usern.Text = "user"
        '
        'UsereditBindingSource2
        '
        Me.UsereditBindingSource2.DataMember = "user_edit"
        Me.UsereditBindingSource2.DataSource = Me.Sedentral_sql
        '
        'Login_p
        '
        Me.Login_p.AutoSize = True
        Me.Login_p.BackColor = System.Drawing.Color.Transparent
        Me.Login_p.Controls.Add(Me.Login_gui)
        Me.Login_p.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Login_p.Location = New System.Drawing.Point(0, 45)
        Me.Login_p.Name = "Login_p"
        Me.Login_p.Size = New System.Drawing.Size(1024, 723)
        Me.Login_p.TabIndex = 0
        '
        'Login_gui
        '
        Me.Login_gui.Controls.Add(Me.PictureBox1)
        Me.Login_gui.Controls.Add(Me.Label1)
        Me.Login_gui.Controls.Add(Me.Username)
        Me.Login_gui.Controls.Add(Me.Label2)
        Me.Login_gui.Controls.Add(Me.Label3)
        Me.Login_gui.Controls.Add(Me.Password)
        Me.Login_gui.Controls.Add(Me.PictureBox3)
        Me.Login_gui.Controls.Add(Me.btn_Login)
        Me.Login_gui.Dock = System.Windows.Forms.DockStyle.Right
        Me.Login_gui.Location = New System.Drawing.Point(498, 0)
        Me.Login_gui.Name = "Login_gui"
        Me.Login_gui.Size = New System.Drawing.Size(526, 723)
        Me.Login_gui.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Line
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 289)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 1)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RSU TEXT", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(143, 223)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 60)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ลงชื่อเข้าสู่ระบบ"
        '
        'Username
        '
        Me.Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Username.FormattingEnabled = True
        Me.Username.Location = New System.Drawing.Point(203, 333)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(247, 35)
        Me.Username.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(88, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 36)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ชื่อผู้ใช้งาน :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(88, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 36)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "รหัสผ่าน :"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(203, 392)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(247, 34)
        Me.Password.TabIndex = 23
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Line
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(6, 499)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(515, 1)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.btn_Login.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Login_Default
        Me.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Login.FlatAppearance.BorderSize = 0
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Login.Location = New System.Drawing.Point(333, 437)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(117, 43)
        Me.btn_Login.TabIndex = 25
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'Taskbar
        '
        Me.Taskbar.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Taskbar
        Me.Taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Taskbar.Controls.Add(Me.Tool)
        Me.Taskbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Taskbar.Location = New System.Drawing.Point(0, 0)
        Me.Taskbar.Name = "Taskbar"
        Me.Taskbar.Size = New System.Drawing.Size(1024, 45)
        Me.Taskbar.TabIndex = 2
        '
        'Tool
        '
        Me.Tool.BackColor = System.Drawing.Color.Transparent
        Me.Tool.Controls.Add(Me.btn_Min)
        Me.Tool.Controls.Add(Me.btn_Exit)
        Me.Tool.Controls.Add(Me.btn_MaxRe)
        Me.Tool.Dock = System.Windows.Forms.DockStyle.Right
        Me.Tool.Location = New System.Drawing.Point(910, 0)
        Me.Tool.Name = "Tool"
        Me.Tool.Size = New System.Drawing.Size(114, 45)
        Me.Tool.TabIndex = 0
        '
        'btn_Min
        '
        Me.btn_Min.BackColor = System.Drawing.Color.Transparent
        Me.btn_Min.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Min_Default
        Me.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Min.FlatAppearance.BorderSize = 0
        Me.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Min.Location = New System.Drawing.Point(5, 5)
        Me.btn_Min.Name = "btn_Min"
        Me.btn_Min.Size = New System.Drawing.Size(31, 30)
        Me.btn_Min.TabIndex = 2
        Me.btn_Min.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Exit.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Exit_Default
        Me.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Location = New System.Drawing.Point(79, 5)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(31, 30)
        Me.btn_Exit.TabIndex = 0
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_MaxRe
        '
        Me.btn_MaxRe.BackColor = System.Drawing.Color.Transparent
        Me.btn_MaxRe.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Max_Default
        Me.btn_MaxRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_MaxRe.FlatAppearance.BorderSize = 0
        Me.btn_MaxRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MaxRe.Location = New System.Drawing.Point(42, 5)
        Me.btn_MaxRe.Name = "btn_MaxRe"
        Me.btn_MaxRe.Size = New System.Drawing.Size(31, 30)
        Me.btn_MaxRe.TabIndex = 1
        Me.btn_MaxRe.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.U)
        Me.Controls.Add(Me.Login_p)
        Me.Controls.Add(Me.Taskbar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("RSU TEXT", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Sedentral_sql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsereditBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsereditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.U.ResumeLayout(False)
        Me.Admin.ResumeLayout(False)
        Me.Admin.PerformLayout()
        CType(Me.data_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Drug.ResumeLayout(False)
        Me.Drug.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Record_2.ResumeLayout(False)
        Me.Record_2.PerformLayout()
        Me.Button_add.ResumeLayout(False)
        Me.Detail.ResumeLayout(False)
        Me.Detail.PerformLayout()
        Me.Record_3.ResumeLayout(False)
        Me.Record_3.PerformLayout()
        Me.Record_1.ResumeLayout(False)
        Me.Record_1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_Tool.ResumeLayout(False)
        Me.sub_menu.ResumeLayout(False)
        CType(Me.btn_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_finan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_drug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_record, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_g.ResumeLayout(False)
        Me.User_g.PerformLayout()
        CType(Me.UsereditBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Login_p.ResumeLayout(False)
        Me.Login_gui.ResumeLayout(False)
        Me.Login_gui.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Taskbar.ResumeLayout(False)
        Me.Tool.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login_p As DblBufferedPanel
    Friend WithEvents Login_gui As DblBufferedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_Login As Button
    Friend WithEvents sub_menu As DblBufferedPanel
    Friend WithEvents btn_admin As PictureBox
    Friend WithEvents btn_emp As PictureBox
    Friend WithEvents btn_finan As PictureBox
    Friend WithEvents btn_drug As PictureBox
    Friend WithEvents btn_record As PictureBox
    Friend WithEvents User_g As DblBufferedPanel
    Friend WithEvents usern As Label
    Friend WithEvents U As DblBufferedPanel
    Friend WithEvents Home As DblBufferedPanel
    Friend WithEvents Menu_Tool As DblBufferedPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Record_2 As DblBufferedPanel
    Friend WithEvents Button_add As DblBufferedPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Detail As DblBufferedPanel
    Friend WithEvents rec_other_relation As Label
    Friend WithEvents rec_other_tel2 As Label
    Friend WithEvents rec_other_tel1 As Label
    Friend WithEvents rec_other_lname As Label
    Friend WithEvents rec_other_fname As Label
    Friend WithEvents rec_access_health As Label
    Friend WithEvents rec_allergic As Label
    Friend WithEvents rec_tel_job As Label
    Friend WithEvents rec_address_job As Label
    Friend WithEvents rec_tel2 As Label
    Friend WithEvents rec_tel1 As Label
    Friend WithEvents rec_address As Label
    Friend WithEvents rec_religion As Label
    Friend WithEvents rac_nation As Label
    Friend WithEvents rec_race As Label
    Friend WithEvents rec_relationship As Label
    Friend WithEvents rec_job As Label
    Friend WithEvents rec_blood As Label
    Friend WithEvents rec_age As Label
    Friend WithEvents rec_birth As Label
    Friend WithEvents rec_sex As Label
    Friend WithEvents rec_lname As Label
    Friend WithEvents rec_fname As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents rec_id_card As Label
    Friend WithEvents label00123 As Label
    Friend WithEvents Record_1 As DblBufferedPanel
    Friend WithEvents btn_search_rec As Button
    Friend WithEvents tb_idcard_search As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Record_4 As DblBufferedPanel
    Friend WithEvents Record_3 As DblBufferedPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents lname As Label
    Friend WithEvents fname As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents ชื่อ As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Drug As DblBufferedPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Finan As DblBufferedPanel
    Friend WithEvents Admin As DblBufferedPanel
    Friend WithEvents Taskbar As DblBufferedPanel
    Friend WithEvents Tool As DblBufferedPanel
    Friend WithEvents btn_Min As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_MaxRe As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Employee As DblBufferedPanel
    Friend WithEvents Sedentral_sql As sedentral_sql
    Friend WithEvents data_User As DataGridView
    Friend WithEvents admin_refresh As Button
    Friend WithEvents UsereditBindingSource As BindingSource
    Friend WithEvents User_editTableAdapter As sedentral_sqlTableAdapters.user_editTableAdapter
    Friend WithEvents btn_add As Button
    Friend WithEvents cb_add_access As ComboBox
    Friend WithEvents cb_add_emp As ComboBox
    Friend WithEvents UsereditBindingSource1 As BindingSource
    Friend WithEvents tb_add_pass As TextBox
    Friend WithEvents tb_add_user As TextBox
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As sedentral_sqlTableAdapters.DataTable1TableAdapter
    Friend WithEvents Label36 As Label
    Friend WithEvents UsereditBindingSource2 As BindingSource
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserPassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents พนักงาน As DataGridViewComboBoxColumn
    Friend WithEvents DataTable1BindingSource1 As BindingSource
    Friend WithEvents UserAccessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
