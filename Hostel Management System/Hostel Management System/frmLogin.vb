Imports System.Data.OleDb
Public Class frmLogin

    Dim connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\Law Twei Jiunn\Desktop\testingGitHub\Hostel Management System\Database\DB\HostelManagementDatabase.mdb")
    Dim command As OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmHomePage.btnReport.Hide()
        frmHomePage.btnReportIcon.Hide()
        connection.Open()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        command = New OleDbCommand("Select * From Credentials Where Username ='" + txtUser.Text + "' and Password='" + txtPassword.Text + "'", connection)
        reader = command.ExecuteReader
        If reader.Read() Then
            MessageBox.Show("Login successfully.")
            connection.Close()
            frmRegistration.Show()
            Me.Hide()
            frmRegistration.Show()
        Else
            MessageBox.Show("Wrong username & password.")

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
