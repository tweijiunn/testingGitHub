Public Class frmPayment
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpPaymentDate.ValueChanged

    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTimePayment.Enabled = True

    End Sub

    Private Sub tmrTimePayment_Tick(sender As Object, e As EventArgs) Handles tmrTimePayment.Tick
        lblDatePayment.Text = Now.ToLongDateString
        lblTimePayment.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs) Handles btnSavePayment.Click

    End Sub

    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        Me.Hide()
    End Sub

    Private Sub btnExitPayment_Click(sender As Object, e As EventArgs) Handles btnExitPayment.Click
        Me.Hide()
    End Sub
End Class