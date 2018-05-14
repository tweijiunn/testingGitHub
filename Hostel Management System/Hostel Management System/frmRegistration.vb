Imports System.Data.OleDb

Public Class frmRegistration
    Dim indicator As Integer

    Dim connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Law Twei Jiunn\Desktop\testingGitHub\Hostel Management System\Database\DB\HostelManagementDatabase.mdb")
    Dim command As OleDbCommand


    Private Sub btnExitHomePage1_Click(sender As Object, e As EventArgs) Handles btnExitRegistration.Click
        Me.Hide()
        txtStudentIDRegistration.Clear()
        txtIntakeCode.Clear()
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtContactNumber.Clear()
        txtEmailAddress.Clear()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click
        Me.Hide()
        txtStudentIDRegistration.Clear()
        txtIntakeCode.Clear()
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtContactNumber.Clear()
        txtEmailAddress.Clear()

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtFirstName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFirstName.MouseClick
        txtFirstName.Clear()
        txtFirstName.ForeColor = Color.LightGray


    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveRegistration.Click

        command = New OleDbCommand("Insert into Students ([StudentID],[IntakeCode],[StudentFirstName],[StudentLastName],[ContactNumber],[E-mailAddress]) Values ('@StudentID','@IntakeCode','@FirstName','@LastName','@ContactNumber','@Email')", connection)
        command.Parameters.AddWithValue("@StudentID", txtStudentIDRegistration.Text)
        command.Parameters.AddWithValue("@IntakeCode", txtIntakeCode.Text)
        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
        command.Parameters.AddWithValue("@LastName", txtLastName.Text)
        command.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
        command.Parameters.AddWithValue("@Email", txtEmailAddress.Text)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()



    End Sub

    Private Sub txtLastName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLastName.MouseClick
        txtLastName.Clear()
        txtLastName.ForeColor = Color.LightGray
    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

    End Sub
End Class

