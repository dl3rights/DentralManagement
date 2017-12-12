Public Class Record
    Dim point As New System.Drawing.Point()
    Dim X, Y As Integer

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransparencyKey = Color.LightGray
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub Record_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub record_enter_Click(sender As Object, e As EventArgs) Handles record_enter.Click

    End Sub

    Private Sub Record_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X -= (X)
            point.Y -= (Y)
            Me.Location = point
        End If
    End Sub

    Private Sub record_enter_MouseDown(sender As Object, e As MouseEventArgs) Handles record_enter.MouseDown
        record_enter.BackgroundImage = New Bitmap(My.Resources.Enter_Downs)
    End Sub

    Private Sub record_enter_MouseUp(sender As Object, e As MouseEventArgs) Handles record_enter.MouseUp
        record_enter.BackgroundImage = New Bitmap(My.Resources.Enter_Default)
    End Sub

    Private Sub record_cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles record_cancel.MouseDown
        record_cancel.BackgroundImage = New Bitmap(My.Resources.Cancel_Down)
    End Sub

    Private Sub record_cancel_Click(sender As Object, e As EventArgs) Handles record_cancel.Click
        Me.Close()
    End Sub

    Private Sub record_cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles record_cancel.MouseUp
        record_cancel.BackgroundImage = New Bitmap(My.Resources.Cancel)
    End Sub
End Class