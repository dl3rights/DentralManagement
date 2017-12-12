<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record))
        Me.record_enter = New System.Windows.Forms.Button()
        Me.record_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'record_enter
        '
        Me.record_enter.BackColor = System.Drawing.Color.Transparent
        Me.record_enter.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Enter_Default
        Me.record_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.record_enter.FlatAppearance.BorderSize = 0
        Me.record_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.record_enter.Location = New System.Drawing.Point(49, 191)
        Me.record_enter.Name = "record_enter"
        Me.record_enter.Size = New System.Drawing.Size(131, 47)
        Me.record_enter.TabIndex = 0
        Me.record_enter.UseVisualStyleBackColor = False
        '
        'record_cancel
        '
        Me.record_cancel.BackColor = System.Drawing.Color.Transparent
        Me.record_cancel.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Cancel
        Me.record_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.record_cancel.FlatAppearance.BorderSize = 0
        Me.record_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.record_cancel.Location = New System.Drawing.Point(234, 191)
        Me.record_cancel.Name = "record_cancel"
        Me.record_cancel.Size = New System.Drawing.Size(131, 47)
        Me.record_cancel.TabIndex = 1
        Me.record_cancel.UseVisualStyleBackColor = False
        '
        'Record
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.DentralManagement.My.Resources.Resources.Record_Dialog01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(415, 261)
        Me.Controls.Add(Me.record_cancel)
        Me.Controls.Add(Me.record_enter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents record_enter As Button
    Friend WithEvents record_cancel As Button
End Class
