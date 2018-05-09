Public Class frmLogin


    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmHomePage.btnReport.Hide()
        frmHomePage.btnReportIcon.Hide()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "TP045928" And txtPassword.Text = "321" Then
            Me.Hide()
            frmHomePage.Show()
        ElseIf txtUser.Text = "TP046118" And txtPassword.Text = "321" Then
            Me.Hide()
            frmHomePage.Show()
            frmHomePage.btnReportIcon.Show()
            frmHomePage.btnReport.Show()
        Else
            Console.Beep()
            MessageBox.Show("Login failed! Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnExitLogin_Click(sender As Object, e As EventArgs) Handles btnExitLogin.Click
        Application.Exit()
    End Sub

    Private Sub txtUser_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUser.MouseClick
        If txtUser.Text = "Username" Then
            txtUser.Clear()
            txtUser.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        If txtPassword.Text = "Password" Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.White
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
