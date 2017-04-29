Public Class frmQRcodeGen

    Private Sub txtUserText_TextChanged(sender As Object, e As EventArgs) Handles txtUserText.TextChanged
        QrCodeImgControl1.Text = txtUserText.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Image As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)
        Dim Save As New SaveFileDialog
        Save.AddExtension = True
        Save.Filter = "JPG (*.jpg)|*.jpg"
        Save.ShowDialog()
        If Not String.IsNullOrEmpty(Save.FileName) Then
            Image.Save(Save.FileName)
        End If
        Image.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        frmMainUI.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserText.Text = ""
    End Sub
End Class