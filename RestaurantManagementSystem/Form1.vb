Public Class Form1

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim Username As String = "admin"
        Dim password As String = "@Password123"

        If txtUsername.Text = Username AndAlso txtPassword.Text = password Then
            Me.Hide()
            Dim mainForm As New Form2
            mainForm.Show()

        Else
            lblStatus.Text = "Invalid password ,Try Again."
            lblStatus.ForeColor = Color.Red

        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class