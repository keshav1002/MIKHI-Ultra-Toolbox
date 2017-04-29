<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiplicationTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiplicationTable))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Moccasin
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(373, 564)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(168, 54)
        Me.btnMainMenu.TabIndex = 11
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.clear_button_png_hi
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Location = New System.Drawing.Point(383, 80)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 73)
        Me.btnClear.TabIndex = 10
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisplay.Location = New System.Drawing.Point(22, 159)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdisplay.Size = New System.Drawing.Size(519, 389)
        Me.txtdisplay.TabIndex = 9
        '
        'btngenerate
        '
        Me.btngenerate.BackColor = System.Drawing.Color.SkyBlue
        Me.btngenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.Location = New System.Drawing.Point(22, 80)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(175, 73)
        Me.btngenerate.TabIndex = 8
        Me.btngenerate.Text = "Generate Table"
        Me.btngenerate.UseVisualStyleBackColor = False
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(278, 28)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(263, 26)
        Me.txtnum.TabIndex = 7
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.BackColor = System.Drawing.Color.LightYellow
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(17, 27)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(219, 25)
        Me.lblValue.TabIndex = 6
        Me.lblValue.Text = "Insert Desired Number:-"
        '
        'frmMultiplicationTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MIKHI_Ultra_ToolBox.My.Resources.Resources.Multiplication_Table_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 630)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMultiplicationTable"
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtdisplay As System.Windows.Forms.TextBox
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents lblValue As System.Windows.Forms.Label
End Class
