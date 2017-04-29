Public Class frmMainUI

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnScientificCalculator.Click
        Me.Visible = False
        frmScientificCalculator.Visible = True
    End Sub

    Private Sub btnQRcodeGen_Click(sender As Object, e As EventArgs) Handles btnQRcodeGen.Click
        Me.Visible = False
        frmQRcodeGen.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnQRCodeScanner_Click(sender As Object, e As EventArgs) Handles btnQRCodeScanner.Click
        Me.Visible = False
        frmQRCodeScanner.Visible = True
    End Sub

    Private Sub btnMultiTable_Click(sender As Object, e As EventArgs) Handles btnMultiTable.Click
        Me.Visible = False
        frmMultiplicationTable.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUnitConverter.Click
        Me.Visible = False
        frmUnitConverterMainUI.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNumberSystemsConverter.Click
        Me.Visible = False
        frmNumberSystemsMainUI.Visible = True
    End Sub

    Private Sub frmMainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class