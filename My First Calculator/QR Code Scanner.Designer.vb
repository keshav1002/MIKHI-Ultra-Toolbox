<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeScanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQRCodeScanner))
        Me.ListBox_of_Results = New System.Windows.Forms.ListBox()
        Me.lblScan_Results = New System.Windows.Forms.Label()
        Me.cmbListofWCDevices = New System.Windows.Forms.ComboBox()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.Scanning_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox_of_Results
        '
        Me.ListBox_of_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_of_Results.FormattingEnabled = True
        Me.ListBox_of_Results.ItemHeight = 25
        Me.ListBox_of_Results.Location = New System.Drawing.Point(712, 197)
        Me.ListBox_of_Results.Name = "ListBox_of_Results"
        Me.ListBox_of_Results.Size = New System.Drawing.Size(386, 29)
        Me.ListBox_of_Results.TabIndex = 10
        '
        'lblScan_Results
        '
        Me.lblScan_Results.AutoSize = True
        Me.lblScan_Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScan_Results.Location = New System.Drawing.Point(709, 165)
        Me.lblScan_Results.Name = "lblScan_Results"
        Me.lblScan_Results.Size = New System.Drawing.Size(127, 25)
        Me.lblScan_Results.TabIndex = 9
        Me.lblScan_Results.Text = "Scan Results"
        '
        'cmbListofWCDevices
        '
        Me.cmbListofWCDevices.FormattingEnabled = True
        Me.cmbListofWCDevices.Location = New System.Drawing.Point(12, 21)
        Me.cmbListofWCDevices.Name = "cmbListofWCDevices"
        Me.cmbListofWCDevices.Size = New System.Drawing.Size(679, 24)
        Me.cmbListofWCDevices.TabIndex = 6
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(12, 68)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(679, 358)
        Me.VideoSourcePlayer1.TabIndex = 12
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        '
        'Scanning_Timer
        '
        Me.Scanning_Timer.Interval = 50
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Moccasin
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(816, 364)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(153, 62)
        Me.btnMainMenu.TabIndex = 13
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'bntClear
        '
        Me.bntClear.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.clear_button_png_hi
        Me.bntClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntClear.Location = New System.Drawing.Point(826, 276)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(135, 67)
        Me.bntClear.TabIndex = 11
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.Stop_Normal_Red_icon
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.Location = New System.Drawing.Point(943, 59)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(86, 81)
        Me.btnStop.TabIndex = 8
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.Start_Scan
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Location = New System.Drawing.Point(730, 68)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(189, 57)
        Me.btnStart.TabIndex = 7
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmQRCodeScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.QR_Scanner_Background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1110, 446)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.VideoSourcePlayer1)
        Me.Controls.Add(Me.bntClear)
        Me.Controls.Add(Me.ListBox_of_Results)
        Me.Controls.Add(Me.lblScan_Results)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cmbListofWCDevices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmQRCodeScanner"
        Me.Text = "QR Code Scanner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntClear As System.Windows.Forms.Button
    Friend WithEvents ListBox_of_Results As System.Windows.Forms.ListBox
    Friend WithEvents lblScan_Results As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents cmbListofWCDevices As System.Windows.Forms.ComboBox
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
    Friend WithEvents Scanning_Timer As System.Windows.Forms.Timer
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
