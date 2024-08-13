<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnPlayMinecraft = New System.Windows.Forms.Button()
        Me.InfoLB = New System.Windows.Forms.Label()
        Me.MinecraftTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbClose = New System.Windows.Forms.Label()
        Me.lbMinimize = New System.Windows.Forms.Label()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlayMinecraft
        '
        Me.btnPlayMinecraft.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnPlayMinecraft.BackgroundImage = Global.BetterDragon.My.Resources.Resources.Button
        Me.btnPlayMinecraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayMinecraft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayMinecraft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayMinecraft.Font = New System.Drawing.Font("Minecrafter Alt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayMinecraft.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPlayMinecraft.Location = New System.Drawing.Point(123, 94)
        Me.btnPlayMinecraft.Name = "btnPlayMinecraft"
        Me.btnPlayMinecraft.Size = New System.Drawing.Size(174, 44)
        Me.btnPlayMinecraft.TabIndex = 0
        Me.btnPlayMinecraft.Text = "PLAY"
        Me.btnPlayMinecraft.UseVisualStyleBackColor = False
        '
        'InfoLB
        '
        Me.InfoLB.AutoSize = True
        Me.InfoLB.BackColor = System.Drawing.Color.Transparent
        Me.InfoLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLB.ForeColor = System.Drawing.Color.White
        Me.InfoLB.Location = New System.Drawing.Point(401, 239)
        Me.InfoLB.Name = "InfoLB"
        Me.InfoLB.Size = New System.Drawing.Size(28, 25)
        Me.InfoLB.TabIndex = 12
        Me.InfoLB.Text = "ⓘ"
        '
        'MinecraftTypeComboBox
        '
        Me.MinecraftTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MinecraftTypeComboBox.Font = New System.Drawing.Font("Minecraft", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinecraftTypeComboBox.FormattingEnabled = True
        Me.MinecraftTypeComboBox.Location = New System.Drawing.Point(123, 192)
        Me.MinecraftTypeComboBox.Name = "MinecraftTypeComboBox"
        Me.MinecraftTypeComboBox.Size = New System.Drawing.Size(174, 22)
        Me.MinecraftTypeComboBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minecraft Ten", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(138, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "© 2024 Kenjie / Ken"
        '
        'lbClose
        '
        Me.lbClose.AutoSize = True
        Me.lbClose.BackColor = System.Drawing.Color.Transparent
        Me.lbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClose.ForeColor = System.Drawing.Color.White
        Me.lbClose.Location = New System.Drawing.Point(404, -1)
        Me.lbClose.Name = "lbClose"
        Me.lbClose.Size = New System.Drawing.Size(35, 25)
        Me.lbClose.TabIndex = 15
        Me.lbClose.Text = "✖"
        '
        'lbMinimize
        '
        Me.lbMinimize.AutoSize = True
        Me.lbMinimize.BackColor = System.Drawing.Color.Transparent
        Me.lbMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMinimize.ForeColor = System.Drawing.Color.White
        Me.lbMinimize.Location = New System.Drawing.Point(376, -1)
        Me.lbMinimize.Name = "lbMinimize"
        Me.lbMinimize.Size = New System.Drawing.Size(22, 25)
        Me.lbMinimize.TabIndex = 16
        Me.lbMinimize.Text = "━"
        '
        'btnUnlock
        '
        Me.btnUnlock.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUnlock.BackgroundImage = Global.BetterDragon.My.Resources.Resources.Button
        Me.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnlock.Font = New System.Drawing.Font("Minecrafter Alt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUnlock.Location = New System.Drawing.Point(123, 142)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(174, 44)
        Me.btnUnlock.TabIndex = 17
        Me.btnUnlock.Text = "UNLOCK"
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BetterDragon.My.Resources.Resources.FormBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 265)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.lbMinimize)
        Me.Controls.Add(Me.lbClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MinecraftTypeComboBox)
        Me.Controls.Add(Me.InfoLB)
        Me.Controls.Add(Me.btnPlayMinecraft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetterDragon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlayMinecraft As Button
    Friend WithEvents InfoLB As Label
    Friend WithEvents MinecraftTypeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbClose As Label
    Friend WithEvents lbMinimize As Label
    Friend WithEvents btnUnlock As Button
End Class
