Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        Me.WindowState = FormWindowState.Normal

        Me.MinimumSize = Me.Size

        Me.MaximumSize = Me.Size

    End Sub
End Class
