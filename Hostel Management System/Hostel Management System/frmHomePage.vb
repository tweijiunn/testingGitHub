Public Class frmHomePage
    Private Sub pnlExtendedMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlExtendedMenu.Paint

    End Sub

    Private Sub btnExitHomePage_Click(sender As Object, e As EventArgs) Handles btnExitHomePage.Click
        Application.Exit()
    End Sub

    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTimeHomePage.Enabled = True
        pnlExtendedMenu.Hide()
        picDropDown.Hide()
        btnEditEntry.Hide()
        btnNewEntry.Hide()

    End Sub

    Private Sub tmrTimeHomePage_Tick(sender As Object, e As EventArgs) Handles tmrTimeHomePage.Tick
        lblTimeHomePage.Text = Now.ToLongTimeString
        lblDateHomePage.Text = Now.ToLongDateString
    End Sub

    Private Sub btnExtendMenu_Click(sender As Object, e As EventArgs) Handles btnExtendMenu2.Click
        If pnlExtendedMenu.Visible = False Then
            pnlExtendedMenu.Show()
        Else
            pnlExtendedMenu.Hide()

        End If

    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        frmRegistration.Show()

    End Sub

    Private Sub btnRegistrationIcon_Click(sender As Object, e As EventArgs) Handles btnRegistrationIcon.Click
        frmRegistration.Show()

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If picDropDown.Visible = False And btnNewEntry.Visible = False And btnEditEntry.Visible = False Then
            picDropDown.Show()
            btnNewEntry.Show()
            btnEditEntry.Show()
        Else
            picDropDown.Hide()
            btnNewEntry.Hide()
            btnEditEntry.Hide()
        End If
    End Sub

    Private Sub btnPaymentIcon_Click(sender As Object, e As EventArgs) Handles btnPaymentIcon.Click
        frmPayment.Show()
    End Sub

    Private Sub btnNewEntry_Click(sender As Object, e As EventArgs)
        frmPayment.Show()
    End Sub
End Class

