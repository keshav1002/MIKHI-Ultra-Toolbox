Option Explicit On
Public Class frmScientificCalculator
    Dim FirstNum, SecondNum, Ans As Double
    Dim ArithemticProcess As String
    Dim ToRadians As Double = System.Math.PI / 180
    Dim ToDegrees As Double = 180 / System.Math.PI
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text & "0"
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        txtDisplay.Text = txtDisplay.Text & "."
    End Sub
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        txtDisplay.Text = "-" & txtDisplay.Text
    End Sub
    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click
        txtDisplay.Text = "3.142"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
        txtProcess.Text = ""
        txtDisplay.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "+"
        txtProcess.Text = FirstNum.ToString + "+"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "*"
        txtProcess.Text = FirstNum.ToString + "*"
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "-"
        txtProcess.Text = FirstNum.ToString + "-"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "/"
        txtProcess.Text = FirstNum.ToString + "/"
    End Sub
    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "√"
        txtProcess.Text = "√" + FirstNum.ToString
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "X^Y"
        txtProcess.Text = FirstNum.ToString + "^"
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "X^2"
        txtProcess.Text = FirstNum.ToString + "^2"
    End Sub

    Private Sub btnNegativePower_Click(sender As Object, e As EventArgs) Handles btnNegativePower.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "X^(-1)"
        txtProcess.Text = FirstNum.ToString + "^(-1)"
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "sin"
        txtProcess.Text = "sin(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "cos"
        txtProcess.Text = "cos(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "tan"
        txtProcess.Text = "tan(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "log"
        txtProcess.Text = "log(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnSinH_Click(sender As Object, e As EventArgs) Handles btnSinH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "sinh"
        txtProcess.Text = "sinh(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnCosH_Click(sender As Object, e As EventArgs) Handles btnCosH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "cosh"
        txtProcess.Text = "cosh(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnTanH_Click(sender As Object, e As EventArgs) Handles btnTanH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "tanh"
        txtProcess.Text = "tanh(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnLn_Click(sender As Object, e As EventArgs) Handles btnLn.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "ln"
        txtProcess.Text = "ln(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseSin_Click(sender As Object, e As EventArgs) Handles btnInverseSin.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvSin"
        txtProcess.Text = "sin^(-1)(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseCos_Click(sender As Object, e As EventArgs) Handles btnInverseCos.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvCos"
        txtProcess.Text = "cos^(-1)(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseTan_Click(sender As Object, e As EventArgs) Handles btnInverseTan.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvTan"
        txtProcess.Text = "tan^(-1)(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseSinH_Click(sender As Object, e As EventArgs) Handles btnInverseSinH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvSinH"
        txtProcess.Text = "sinh^(-1)(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseCosH_Click(sender As Object, e As EventArgs) Handles btnInverseCosH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvCosH"
        txtProcess.Text = "cosh^(-1)(" + FirstNum.ToString + ")"
    End Sub

    Private Sub btnInverseTanH_Click(sender As Object, e As EventArgs) Handles btnInverseTanH.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "InvTanH"
        txtProcess.Text = "tanh^(-1)(" + FirstNum.ToString + ")"
    End Sub


    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "Mod"
        txtProcess.Text = FirstNum.ToString + " Mod"
    End Sub

    Private Sub btnIntegerDivision_Click(sender As Object, e As EventArgs) Handles btnIntegerDivision.Click
        FirstNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        txtDisplay.Focus()
        ArithemticProcess = "Div"
        txtProcess.Text = FirstNum.ToString + " \"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SecondNum = Val(txtDisplay.Text)
        If ArithemticProcess = "+" Then
            Ans = FirstNum + SecondNum
            txtProcess.Text = txtProcess.Text + SecondNum.ToString
        ElseIf ArithemticProcess = "-" Then
            Ans = FirstNum - SecondNum
            txtProcess.Text = txtProcess.Text + SecondNum.ToString
        ElseIf ArithemticProcess = "*" Then
            Ans = FirstNum * SecondNum
            txtProcess.Text = txtProcess.Text + SecondNum.ToString
        ElseIf ArithemticProcess = "/" Then
            Ans = FirstNum / SecondNum
            txtProcess.Text = txtProcess.Text + SecondNum.ToString
        ElseIf ArithemticProcess = "X^Y" Then
            Ans = (FirstNum) ^ (SecondNum)
        ElseIf ArithemticProcess = "Mod" Then
            Ans = FirstNum Mod SecondNum
            txtProcess.Text = txtProcess.Text + " " + SecondNum.ToString
        ElseIf ArithemticProcess = "Div" Then
            Ans = FirstNum \ SecondNum
            txtProcess.Text = txtProcess.Text + " " + SecondNum.ToString
        ElseIf ArithemticProcess = "√" Then
            Ans = FirstNum ^ (1 / 2)
        ElseIf ArithemticProcess = "X^2" Then
            Ans = FirstNum ^ 2
        ElseIf ArithemticProcess = "X^(-1)" Then
            Ans = FirstNum ^ (-1)

        ElseIf ArithemticProcess = "sin" Then
            If rdbDegrees.Checked Then
                Ans = Math.Sin(FirstNum * (Math.PI / 180))
            Else
                Ans = Math.Sin(FirstNum)
            End If

        ElseIf ArithemticProcess = "cos" Then
            If rdbDegrees.Checked Then
                Ans = Math.Cos(FirstNum * (Math.PI / 180))
            Else
                Ans = Math.Cos(FirstNum)
            End If

        ElseIf ArithemticProcess = "tan" Then
            If rdbDegrees.Checked Then
                Ans = Math.Tan(FirstNum * (Math.PI / 180))
            Else
                Ans = Math.Tan(FirstNum)
            End If

        ElseIf ArithemticProcess = "InvSin" Then
            If rdbDegrees.Checked Then
                Ans = Math.Asin(FirstNum) * (180 / Math.PI)
            Else
                Ans = Math.Asin(FirstNum)
            End If
        ElseIf ArithemticProcess = "InvCos" Then
            If rdbDegrees.Checked Then
                Ans = Math.Acos(FirstNum) * (180 / Math.PI)
            Else
                Ans = Math.Acos(FirstNum)
            End If
        ElseIf ArithemticProcess = "InvTan" Then
            If rdbDegrees.Checked Then
                Ans = Math.Atan(FirstNum) * (180 / Math.PI)
            Else
                Ans = Math.Atan(FirstNum)
            End If


        ElseIf ArithemticProcess = "sinh" Then
            Ans = Math.Sinh(FirstNum)
        ElseIf ArithemticProcess = "cosh" Then
            Ans = Math.Cosh(FirstNum)
        ElseIf ArithemticProcess = "tanh" Then
            Ans = Math.Tanh(FirstNum)
        ElseIf ArithemticProcess = "InvSinH" Then
            Ans = Math.Log(FirstNum + Math.Sqrt(FirstNum * (FirstNum + 1)))
        ElseIf ArithemticProcess = "InvCosH" Then
            Ans = Math.Log(FirstNum + Math.Sqrt(FirstNum * (FirstNum - 1)))
        ElseIf ArithemticProcess = "InvTanH" Then
            Ans = Math.Log((1 + FirstNum) / (1 - FirstNum)) / 2
        ElseIf ArithemticProcess = "log" Then
            Ans = Math.Log10(FirstNum)
        ElseIf ArithemticProcess = "ln" Then
            Ans = Math.Log(FirstNum)
        End If
        txtDisplay.Text = Ans
    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        frmMainUI.Visible = True
    End Sub


    Private Sub txtDisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisplay.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtProcess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProcess.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                       Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class
