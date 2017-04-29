Public Class frmLengthConverter

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim num, input As Double
        input = Val(txtInput.Text)
        If ComboBox1.SelectedItem = "Millimetres" Then
            If ComboBox2.SelectedItem = "Centimetres" Then
                num = input / 10
            ElseIf ComboBox2.SelectedItem = "Metres" Then
                num = input / 1000
            ElseIf ComboBox2.SelectedItem = "Kilometres" Then
                num = input / 1000000
            ElseIf ComboBox2.SelectedItem = "Miles" Then
                num = input * 0.000000621371
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "Centimetres" Then
            If ComboBox2.SelectedItem = "Millimetres" Then
                num = input * 10
            ElseIf ComboBox2.SelectedItem = "Metres" Then
                num = input / 100
            ElseIf ComboBox2.SelectedItem = "Kilometres" Then
                num = input / 100000
            ElseIf ComboBox2.SelectedItem = "Miles" Then
                num = input * 0.00000621371
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

        ElseIf ComboBox1.SelectedItem = "Metres" Then
            If ComboBox2.SelectedItem = "Millimetres" Then
                num = input * 1000
            ElseIf ComboBox2.SelectedItem = "Centimetres" Then
                num = input * 100
            ElseIf ComboBox2.SelectedItem = "Kilometres" Then
                num = input / 1000
            ElseIf ComboBox2.SelectedItem = "Miles" Then
                num = input * 0.000621371
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "Kilometres" Then
            If ComboBox2.SelectedItem = "Millimetres" Then
                num = input * 1000000
            ElseIf ComboBox2.SelectedItem = "Centimetres" Then
                num = input * 100000
            ElseIf ComboBox2.SelectedItem = "Metres" Then
                num = input * 1000
            ElseIf ComboBox2.SelectedItem = "Miles" Then
                num = input * 0.621371
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "Miles" Then
            If ComboBox2.SelectedItem = "Millimetres" Then
                num = input * 0.00000160934
            ElseIf ComboBox2.SelectedItem = "Centimetres" Then
                num = input * 0.0000160934
            ElseIf ComboBox2.SelectedItem = "Metres" Then
                num = input * 0.00160934
            ElseIf ComboBox2.SelectedItem = "Kilometres" Then
                num = input * 1.60934
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please Select a Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        lblAnswers.Text = num
    End Sub

    Private Sub BtnMUI_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Visible = False
        frmUnitConverterMainUI.Visible = True
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