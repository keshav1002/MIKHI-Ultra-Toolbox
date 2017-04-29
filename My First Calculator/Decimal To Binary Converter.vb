Public Class frmDecimalToBinaryConverter

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim X As String
        Dim Y As Integer
        If txtInput.Text = "" Then
            MessageBox.Show("Please Enter a Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Y = txtInput.Text
            X = Convert.ToString(Y, 2)
            txtAnswers.Text = X
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        txtAnswers.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmNumberSystemsMainUI.Visible = True
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAnswers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswers.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class