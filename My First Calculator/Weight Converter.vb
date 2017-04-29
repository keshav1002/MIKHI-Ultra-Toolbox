Public Class frmWeightConverter

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Visible = False
        frmUnitConverterMainUI.Visible = True
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim num, input As Double
        input = Val(txtInput.Text)
        If ComboBox1.SelectedItem = "Milligrams" Then
            If ComboBox2.SelectedItem = "Grams" Then
                num = input / 1000
            ElseIf ComboBox2.SelectedItem = "Kilograms" Then
                num = input / 1000000
            ElseIf ComboBox2.SelectedItem = "Tonnes" Then
                num = input / 1000000000
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

        ElseIf ComboBox1.SelectedItem = "Grams" Then
            If ComboBox2.SelectedItem = "Milligrams" Then
                num = input * 1000
            ElseIf ComboBox2.SelectedItem = "Kilograms" Then
                num = input / 1000
            ElseIf ComboBox2.SelectedItem = "Tonnes" Then
                num = input / 1000000
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "Kilograms" Then
            If ComboBox2.SelectedItem = "Milligrams" Then
                num = input * 1000000
            ElseIf ComboBox2.SelectedItem = "Grams" Then
                num = input * 1000
            ElseIf ComboBox2.SelectedItem = "Tonnes" Then
                num = input / 1000
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

        ElseIf ComboBox1.SelectedItem = "Tonnes" Then
            If ComboBox2.SelectedItem = "Milligrams" Then
                num = input * 1000000000
            ElseIf ComboBox2.SelectedItem = "Grams" Then
                num = input * 1000000
            ElseIf ComboBox2.SelectedItem = "Kilograms" Then
                num = input * 1000
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

        ElseIf ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please Select a Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        lblAnswers.Text = num
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnswers.Text = ""
        txtInput.Text = ""
        ComboBox1.ResetText()
        ComboBox2.ResetText()
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

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class