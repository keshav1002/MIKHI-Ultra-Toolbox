<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberSystemsMainUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNumberSystemsMainUI))
        Me.btnDecimalToBinaryConverter = New System.Windows.Forms.Button()
        Me.btnDecimalToHexadecimalConverter = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDecimalToBinaryConverter
        '
        Me.btnDecimalToBinaryConverter.BackColor = System.Drawing.SystemColors.Control
        Me.btnDecimalToBinaryConverter.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.brushedsteel5
        Me.btnDecimalToBinaryConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDecimalToBinaryConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimalToBinaryConverter.ForeColor = System.Drawing.Color.Black
        Me.btnDecimalToBinaryConverter.Location = New System.Drawing.Point(26, 61)
        Me.btnDecimalToBinaryConverter.Name = "btnDecimalToBinaryConverter"
        Me.btnDecimalToBinaryConverter.Size = New System.Drawing.Size(158, 93)
        Me.btnDecimalToBinaryConverter.TabIndex = 0
        Me.btnDecimalToBinaryConverter.Text = "Decimal To Binary Converter"
        Me.btnDecimalToBinaryConverter.UseVisualStyleBackColor = False
        '
        'btnDecimalToHexadecimalConverter
        '
        Me.btnDecimalToHexadecimalConverter.BackColor = System.Drawing.SystemColors.Control
        Me.btnDecimalToHexadecimalConverter.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.brushedsteel5
        Me.btnDecimalToHexadecimalConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDecimalToHexadecimalConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimalToHexadecimalConverter.ForeColor = System.Drawing.Color.Black
        Me.btnDecimalToHexadecimalConverter.Location = New System.Drawing.Point(215, 61)
        Me.btnDecimalToHexadecimalConverter.Name = "btnDecimalToHexadecimalConverter"
        Me.btnDecimalToHexadecimalConverter.Size = New System.Drawing.Size(170, 93)
        Me.btnDecimalToHexadecimalConverter.TabIndex = 1
        Me.btnDecimalToHexadecimalConverter.Text = "Decimal To Hexadecimal Converter"
        Me.btnDecimalToHexadecimalConverter.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Moccasin
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(121, 220)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(160, 67)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmNumberSystemsMainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 345)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDecimalToHexadecimalConverter)
        Me.Controls.Add(Me.btnDecimalToBinaryConverter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNumberSystemsMainUI"
        Me.Text = "Number Systems Converter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDecimalToBinaryConverter As System.Windows.Forms.Button
    Friend WithEvents btnDecimalToHexadecimalConverter As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
