<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainUI))
        Me.btnScientificCalculator = New System.Windows.Forms.Button()
        Me.btnQRcodeGen = New System.Windows.Forms.Button()
        Me.btnQRCodeScanner = New System.Windows.Forms.Button()
        Me.btnMultiTable = New System.Windows.Forms.Button()
        Me.btnUnitConverter = New System.Windows.Forms.Button()
        Me.btnNumberSystemsConverter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnScientificCalculator
        '
        Me.btnScientificCalculator.BackColor = System.Drawing.Color.White
        Me.btnScientificCalculator.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScientificCalculator.Location = New System.Drawing.Point(126, 128)
        Me.btnScientificCalculator.Name = "btnScientificCalculator"
        Me.btnScientificCalculator.Size = New System.Drawing.Size(129, 67)
        Me.btnScientificCalculator.TabIndex = 0
        Me.btnScientificCalculator.Text = "Scientific Calculator"
        Me.btnScientificCalculator.UseVisualStyleBackColor = False
        '
        'btnQRcodeGen
        '
        Me.btnQRcodeGen.BackColor = System.Drawing.Color.White
        Me.btnQRcodeGen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRcodeGen.Location = New System.Drawing.Point(346, 129)
        Me.btnQRcodeGen.Name = "btnQRcodeGen"
        Me.btnQRcodeGen.Size = New System.Drawing.Size(129, 67)
        Me.btnQRcodeGen.TabIndex = 2
        Me.btnQRcodeGen.Text = "QR Code Generator"
        Me.btnQRcodeGen.UseVisualStyleBackColor = False
        '
        'btnQRCodeScanner
        '
        Me.btnQRCodeScanner.BackColor = System.Drawing.Color.White
        Me.btnQRCodeScanner.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQRCodeScanner.Location = New System.Drawing.Point(348, 275)
        Me.btnQRCodeScanner.Name = "btnQRCodeScanner"
        Me.btnQRCodeScanner.Size = New System.Drawing.Size(129, 67)
        Me.btnQRCodeScanner.TabIndex = 4
        Me.btnQRCodeScanner.Text = "QR Code Scanner"
        Me.btnQRCodeScanner.UseVisualStyleBackColor = False
        '
        'btnMultiTable
        '
        Me.btnMultiTable.BackColor = System.Drawing.Color.White
        Me.btnMultiTable.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiTable.Location = New System.Drawing.Point(127, 276)
        Me.btnMultiTable.Name = "btnMultiTable"
        Me.btnMultiTable.Size = New System.Drawing.Size(129, 67)
        Me.btnMultiTable.TabIndex = 5
        Me.btnMultiTable.Text = "Multiplication Table"
        Me.btnMultiTable.UseVisualStyleBackColor = False
        '
        'btnUnitConverter
        '
        Me.btnUnitConverter.BackColor = System.Drawing.Color.White
        Me.btnUnitConverter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnitConverter.Location = New System.Drawing.Point(127, 412)
        Me.btnUnitConverter.Name = "btnUnitConverter"
        Me.btnUnitConverter.Size = New System.Drawing.Size(129, 67)
        Me.btnUnitConverter.TabIndex = 6
        Me.btnUnitConverter.Text = "Unit Converter"
        Me.btnUnitConverter.UseVisualStyleBackColor = False
        '
        'btnNumberSystemsConverter
        '
        Me.btnNumberSystemsConverter.BackColor = System.Drawing.Color.White
        Me.btnNumberSystemsConverter.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumberSystemsConverter.Location = New System.Drawing.Point(349, 408)
        Me.btnNumberSystemsConverter.Name = "btnNumberSystemsConverter"
        Me.btnNumberSystemsConverter.Size = New System.Drawing.Size(129, 67)
        Me.btnNumberSystemsConverter.TabIndex = 7
        Me.btnNumberSystemsConverter.Text = "Number Systems Converter"
        Me.btnNumberSystemsConverter.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(486, 554)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 42)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.MAIN_UI_51
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(617, 663)
        Me.Controls.Add(Me.btnNumberSystemsConverter)
        Me.Controls.Add(Me.btnUnitConverter)
        Me.Controls.Add(Me.btnMultiTable)
        Me.Controls.Add(Me.btnQRCodeScanner)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnQRcodeGen)
        Me.Controls.Add(Me.btnScientificCalculator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMainUI"
        Me.Text = "MIKHI Ultra ToolBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnScientificCalculator As System.Windows.Forms.Button
    Friend WithEvents btnQRcodeGen As System.Windows.Forms.Button
    Friend WithEvents btnQRCodeScanner As System.Windows.Forms.Button
    Friend WithEvents btnMultiTable As System.Windows.Forms.Button
    Friend WithEvents btnUnitConverter As System.Windows.Forms.Button
    Friend WithEvents btnNumberSystemsConverter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
