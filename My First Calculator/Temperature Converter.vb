Public Class frmTemperatureConverter

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim num, input As Double
        input = Val(txtInput.Text)

        If ComboBox1.SelectedItem = "Celsius" Then
            If ComboBox2.SelectedItem = "Fahrenheit" Then
                num = (input * 1.8) + 32
            ElseIf ComboBox2.SelectedItem = "Kelvin" Then
                num = input + 273.15
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        ElseIf ComboBox1.SelectedItem = "Fahrenheit" Then
            If ComboBox2.SelectedItem = "Celsius" Then

                num = (5 / 9) * (input - 32)

            ElseIf ComboBox2.SelectedItem = "Kelvin" Then
                num = ((5 / 9) * (input - 32)) + 273.15
            Else
                MessageBox.Show("Incorrect Selection", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            End If
        ElseIf ComboBox1.SelectedItem = "Kelvin" Then

            If ComboBox2.SelectedItem = "Celsius" Then
                num = input - 273.15

            ElseIf ComboBox2.SelectedItem = "Fahrenheit" Then

                num = input - 273.15
                num = (num * 1.8) + 32

            End If
        ElseIf ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please Select a Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        lblAnswers.Text = num
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
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