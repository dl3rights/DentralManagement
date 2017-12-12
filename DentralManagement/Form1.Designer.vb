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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_MaxRe = New System.Windows.Forms.Button()
        Me.btn_Min = New System.Windows.Forms.Button()
        Me.Login_p = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Username = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.U = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Menu_Tool = New System.Windows.Forms.Panel()
        Me.Smenu = New System.Windows.Forms.Panel()
        Me.btn_admin = New System.Windows.Forms.PictureBox()
        Me.btn_emp = New System.Windows.Forms.PictureBox()
        Me.btn_finan = New System.Windows.Forms.PictureBox()
        Me.btn_drug = New System.Windows.Forms.PictureBox()
        Me.btn_record = New System.Windows.Forms.PictureBox()
        Me.namesuser = New System.Windows.Forms.Panel()
        Me.label_name = New System.Windows.Forms.Label()
        Me.Record = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Login_p.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.U.SuspendLayout()
        Me.Home.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_Tool.SuspendLayout()
        Me.Smenu.SuspendLayout()
        CType(Me.btn_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_finan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_drug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_record, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.namesuser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Taskbar
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 45)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_Exit)
        Me.Panel3.Controls.Add(Me.btn_MaxRe)
        Me.Panel3.Controls.Add(Me.btn_Min)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(911, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(113, 45)
        Me.Panel3.TabIndex = 3
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Exit.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Exit_Default
        Me.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Location = New System.Drawing.Point(76, 6)
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
        Me.btn_MaxRe.Location = New System.Drawing.Point(39, 6)
        Me.btn_MaxRe.Name = "btn_MaxRe"
        Me.btn_MaxRe.Size = New System.Drawing.Size(31, 30)
        Me.btn_MaxRe.TabIndex = 1
        Me.btn_MaxRe.UseVisualStyleBackColor = False
        '
        'btn_Min
        '
        Me.btn_Min.BackColor = System.Drawing.Color.Transparent
        Me.btn_Min.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Min_Default
        Me.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Min.FlatAppearance.BorderSize = 0
        Me.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Min.Location = New System.Drawing.Point(2, 6)
        Me.btn_Min.Name = "btn_Min"
        Me.btn_Min.Size = New System.Drawing.Size(31, 30)
        Me.btn_Min.TabIndex = 2
        Me.btn_Min.UseVisualStyleBackColor = False
        '
        'Login_p
        '
        Me.Login_p.BackColor = System.Drawing.Color.Transparent
        Me.Login_p.Controls.Add(Me.Panel2)
        Me.Login_p.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Login_p.Location = New System.Drawing.Point(0, 45)
        Me.Login_p.Name = "Login_p"
        Me.Login_p.Size = New System.Drawing.Size(1024, 723)
        Me.Login_p.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Username)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Password)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.btn_Login)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(500, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 723)
        Me.Panel2.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Line
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 270)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 1)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Username
        '
        Me.Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Username.FormattingEnabled = True
        Me.Username.Location = New System.Drawing.Point(202, 314)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(247, 35)
        Me.Username.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RSU TEXT", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(142, 204)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 60)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ลงชื่อเข้าสู้ระบบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(87, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 36)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ชื่อผู้ใช้งาน :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("RSU TEXT", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(87, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 36)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "รหัสผ่าน :"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(202, 373)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(247, 34)
        Me.Password.TabIndex = 15
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Line
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(5, 480)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(515, 1)
        Me.PictureBox3.TabIndex = 16
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
        Me.btn_Login.Location = New System.Drawing.Point(332, 418)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(117, 43)
        Me.btn_Login.TabIndex = 17
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'U
        '
        Me.U.AutoSize = True
        Me.U.Controls.Add(Me.Record)
        Me.U.Controls.Add(Me.Home)
        Me.U.Controls.Add(Me.Menu_Tool)
        Me.U.Dock = System.Windows.Forms.DockStyle.Fill
        Me.U.Location = New System.Drawing.Point(0, 45)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(1024, 723)
        Me.U.TabIndex = 19
        Me.U.Visible = False
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Transparent
        Me.Home.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home.Location = New System.Drawing.Point(251, 0)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(773, 723)
        Me.Home.TabIndex = 1
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(773, 723)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Menu_Tool
        '
        Me.Menu_Tool.AutoSize = True
        Me.Menu_Tool.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Menu
        Me.Menu_Tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Menu_Tool.Controls.Add(Me.Smenu)
        Me.Menu_Tool.Controls.Add(Me.namesuser)
        Me.Menu_Tool.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu_Tool.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Tool.MaximumSize = New System.Drawing.Size(355, 1080)
        Me.Menu_Tool.MinimumSize = New System.Drawing.Size(251, 723)
        Me.Menu_Tool.Name = "Menu_Tool"
        Me.Menu_Tool.Size = New System.Drawing.Size(251, 723)
        Me.Menu_Tool.TabIndex = 0
        '
        'Smenu
        '
        Me.Smenu.BackColor = System.Drawing.Color.Transparent
        Me.Smenu.Controls.Add(Me.btn_admin)
        Me.Smenu.Controls.Add(Me.btn_emp)
        Me.Smenu.Controls.Add(Me.btn_finan)
        Me.Smenu.Controls.Add(Me.btn_drug)
        Me.Smenu.Controls.Add(Me.btn_record)
        Me.Smenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Smenu.Location = New System.Drawing.Point(0, 153)
        Me.Smenu.Name = "Smenu"
        Me.Smenu.Size = New System.Drawing.Size(251, 287)
        Me.Smenu.TabIndex = 1
        '
        'btn_admin
        '
        Me.btn_admin.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_admin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_admin.Location = New System.Drawing.Point(0, 224)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(251, 63)
        Me.btn_admin.TabIndex = 4
        Me.btn_admin.TabStop = False
        '
        'btn_emp
        '
        Me.btn_emp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_emp.Location = New System.Drawing.Point(0, 168)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.Size = New System.Drawing.Size(251, 56)
        Me.btn_emp.TabIndex = 3
        Me.btn_emp.TabStop = False
        '
        'btn_finan
        '
        Me.btn_finan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_finan.Location = New System.Drawing.Point(0, 112)
        Me.btn_finan.Name = "btn_finan"
        Me.btn_finan.Size = New System.Drawing.Size(251, 56)
        Me.btn_finan.TabIndex = 2
        Me.btn_finan.TabStop = False
        '
        'btn_drug
        '
        Me.btn_drug.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_drug.Location = New System.Drawing.Point(0, 56)
        Me.btn_drug.Name = "btn_drug"
        Me.btn_drug.Size = New System.Drawing.Size(251, 56)
        Me.btn_drug.TabIndex = 1
        Me.btn_drug.TabStop = False
        '
        'btn_record
        '
        Me.btn_record.BackColor = System.Drawing.Color.Transparent
        Me.btn_record.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_record.Location = New System.Drawing.Point(0, 0)
        Me.btn_record.Name = "btn_record"
        Me.btn_record.Size = New System.Drawing.Size(251, 56)
        Me.btn_record.TabIndex = 0
        Me.btn_record.TabStop = False
        '
        'namesuser
        '
        Me.namesuser.BackColor = System.Drawing.Color.Transparent
        Me.namesuser.Controls.Add(Me.label_name)
        Me.namesuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.namesuser.Location = New System.Drawing.Point(0, 0)
        Me.namesuser.Name = "namesuser"
        Me.namesuser.Size = New System.Drawing.Size(251, 153)
        Me.namesuser.TabIndex = 0
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.Font = New System.Drawing.Font("RSU TEXT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.label_name.Location = New System.Drawing.Point(39, 60)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(164, 31)
        Me.label_name.TabIndex = 0
        Me.label_name.Text = "นาย รัชกร ภัทรนาวิก"
        '
        'Record
        '
        Me.Record.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Record.Location = New System.Drawing.Point(251, 0)
        Me.Record.Name = "Record"
        Me.Record.Size = New System.Drawing.Size(773, 723)
        Me.Record.TabIndex = 1
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
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("RSU TEXT", 18.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Login_p.ResumeLayout(False)
        Me.Login_p.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.U.ResumeLayout(False)
        Me.U.PerformLayout()
        Me.Home.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_Tool.ResumeLayout(False)
        Me.Smenu.ResumeLayout(False)
        CType(Me.btn_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_finan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_drug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_record, System.ComponentModel.ISupportInitialize).EndInit()
        Me.namesuser.ResumeLayout(False)
        Me.namesuser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Min As Button
    Friend WithEvents btn_MaxRe As Button
    Friend WithEvents Login_p As Panel
    Friend WithEvents btn_Login As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents U As Panel
    Friend WithEvents Home As Panel
    Friend WithEvents Menu_Tool As Panel
    Friend WithEvents namesuser As Panel
    Friend WithEvents label_name As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Smenu As Panel
    Friend WithEvents btn_admin As PictureBox
    Friend WithEvents btn_emp As PictureBox
    Friend WithEvents btn_finan As PictureBox
    Friend WithEvents btn_drug As PictureBox
    Friend WithEvents btn_record As PictureBox
    Friend WithEvents Record As Panel
End Class
