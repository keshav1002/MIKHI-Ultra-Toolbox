Public Class frmMultiplicationTable

    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Dim num, multiplier As Double
        num = Val(txtnum.Text)

        If (num >= 1) Then
            For multiplier = 1 To 100
                txtdisplay.Text = txtdisplay.Text + num.ToString + " x" + " " + multiplier.ToString + " " + "=" + " " + (num * multiplier).ToString + vbNewLine
            Next
        Else
            txtdisplay.Text = "ERROR"
            MessageBox.Show("Error! Please enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        frmMainUI.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtdisplay.Text = ""
        txtnum.Text = ""
    End Sub

    Private Sub txtdisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisplay.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

End Class