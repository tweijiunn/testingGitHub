Public Class frmRegistration
    Dim indicator As Integer
    Private Sub btnExitHomePage1_Click(sender As Object, e As EventArgs) Handles btnExitRegistration.Click
        Me.Hide()
        txtStudentIDRegistration.Clear()
        txtIntakeCode.Clear()
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtContactNumber.Clear()
        txtEmailAddress.Clear()
        txtUnitID.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelRegistration.Click
        Me.Hide()
        txtStudentIDRegistration.Clear()
        txtIntakeCode.Clear()
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtContactNumber.Clear()
        txtEmailAddress.Clear()
        txtUnitID.Clear()
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
        If txtFirstName.Text = "" And txtLastName.Text = "" Then
            txtFirstName.Text = "First Name"
            txtLastName.Text = "Last Name"
        End If
    End Sub

    Private Sub txtLastName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLastName.MouseClick
        txtLastName.Clear()
        txtLastName.ForeColor = Color.LightGray
    End Sub
End Class

