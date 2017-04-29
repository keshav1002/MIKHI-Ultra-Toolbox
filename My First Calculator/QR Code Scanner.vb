Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Public Class frmQRCodeScanner
    Private WCDevices As FilterInfoCollection
    Private VideoSource As VideoCaptureDevice

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WCDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In WCDevices
            cmbListofWCDevices.Items.Add(x.Name)
        Next
        cmbListofWCDevices.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Scanning_Timer.Enabled = True

        VideoSource = New VideoCaptureDevice(WCDevices(cmbListofWCDevices.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = VideoSource
        VideoSourcePlayer1.Start()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Scanning_Timer.Enabled = False
        VideoSourcePlayer1.SignalToStop()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Scanning_Timer.Tick

        If VideoSourcePlayer1.GetCurrentVideoFrame() IsNot Nothing Then

            Dim img As New Bitmap(VideoSourcePlayer1.GetCurrentVideoFrame())

            Dim Results As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)

            img.Dispose()

            If Results IsNot Nothing AndAlso Results.Count() > 0 Then

                If Results(0).IndexOf(" ") <> -1 Then
                    Results(0) = Results(0).Replace(" ", "")
                    ListBox_of_Results.Items.Insert(0, Results(0))
                End If

            End If

        End If
    End Sub

    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        ListBox_of_Results.Items.Clear()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        frmMainUI.Visible = True
    End Sub
End Class
