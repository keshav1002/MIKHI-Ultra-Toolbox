Public Class frmNumberSystemsMainUI

    Private Sub btnDecimalToBinaryConverter_Click(sender As Object, e As EventArgs) Handles btnDecimalToBinaryConverter.Click
        Me.Visible = False
        frmDecimalToBinaryConverter.Visible = True
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        frmMainUI.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDecimalToHexadecimalConverter.Click
        Me.Visible = False
        frmDecimalToHexadecimalConverter.Visible = True
    End Sub
End Class