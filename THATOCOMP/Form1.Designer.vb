<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboModHDD = New System.Windows.Forms.ComboBox()
        Me.cboModRAM = New System.Windows.Forms.ComboBox()
        Me.chkStandard = New System.Windows.Forms.CheckBox()
        Me.chkHDD = New System.Windows.Forms.CheckBox()
        Me.chkRAM = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMouse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSpeaker = New System.Windows.Forms.TextBox()
        Me.txtKeyboard = New System.Windows.Forms.TextBox()
        Me.txtMonitor = New System.Windows.Forms.TextBox()
        Me.chkSpeaker = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkMonitor = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.lstQuote = New System.Windows.Forms.ListBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.chkPrices = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.THATOCOMP.My.Resources.Resources._68984377806c969d9504f0faaaede75f_computer_silhouette_by_vexels
        Me.PictureBox1.Location = New System.Drawing.Point(430, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T H A T O " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        C O M P U T E R S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSurname)
        Me.Panel1.Controls.Add(Me.lblSurname)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(12, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 43)
        Me.Panel1.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSurname.Location = New System.Drawing.Point(390, 10)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(160, 20)
        Me.txtSurname.TabIndex = 5
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(284, 10)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(91, 18)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "SURNAME :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtName.Location = New System.Drawing.Point(88, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 20)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "NAME :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboModHDD)
        Me.GroupBox1.Controls.Add(Me.cboModRAM)
        Me.GroupBox1.Controls.Add(Me.chkStandard)
        Me.GroupBox1.Controls.Add(Me.chkHDD)
        Me.GroupBox1.Controls.Add(Me.chkRAM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computers"
        '
        'cboModHDD
        '
        Me.cboModHDD.FormattingEnabled = True
        Me.cboModHDD.Location = New System.Drawing.Point(127, 78)
        Me.cboModHDD.Name = "cboModHDD"
        Me.cboModHDD.Size = New System.Drawing.Size(45, 21)
        Me.cboModHDD.TabIndex = 9
        '
        'cboModRAM
        '
        Me.cboModRAM.FormattingEnabled = True
        Me.cboModRAM.Location = New System.Drawing.Point(127, 51)
        Me.cboModRAM.Name = "cboModRAM"
        Me.cboModRAM.Size = New System.Drawing.Size(45, 21)
        Me.cboModRAM.TabIndex = 8
        '
        'chkStandard
        '
        Me.chkStandard.AutoSize = True
        Me.chkStandard.Location = New System.Drawing.Point(18, 28)
        Me.chkStandard.Name = "chkStandard"
        Me.chkStandard.Size = New System.Drawing.Size(117, 17)
        Me.chkStandard.TabIndex = 5
        Me.chkStandard.Text = "Standard Computer"
        Me.chkStandard.UseVisualStyleBackColor = True
        '
        'chkHDD
        '
        Me.chkHDD.AutoSize = True
        Me.chkHDD.Location = New System.Drawing.Point(36, 77)
        Me.chkHDD.Name = "chkHDD"
        Me.chkHDD.Size = New System.Drawing.Size(93, 17)
        Me.chkHDD.TabIndex = 7
        Me.chkHDD.Text = "HDD Modules"
        Me.chkHDD.UseVisualStyleBackColor = True
        '
        'chkRAM
        '
        Me.chkRAM.AutoSize = True
        Me.chkRAM.Location = New System.Drawing.Point(36, 51)
        Me.chkRAM.Name = "chkRAM"
        Me.chkRAM.Size = New System.Drawing.Size(93, 17)
        Me.chkRAM.TabIndex = 6
        Me.chkRAM.Text = "RAM Modules"
        Me.chkRAM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMouse)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSpeaker)
        Me.GroupBox2.Controls.Add(Me.txtKeyboard)
        Me.GroupBox2.Controls.Add(Me.txtMonitor)
        Me.GroupBox2.Controls.Add(Me.chkSpeaker)
        Me.GroupBox2.Controls.Add(Me.chkMouse)
        Me.GroupBox2.Controls.Add(Me.chkMonitor)
        Me.GroupBox2.Controls.Add(Me.chkKeyboard)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Peripherals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Number :"
        '
        'txtMouse
        '
        Me.txtMouse.Location = New System.Drawing.Point(60, 48)
        Me.txtMouse.Name = "txtMouse"
        Me.txtMouse.Size = New System.Drawing.Size(32, 20)
        Me.txtMouse.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Number :"
        '
        'txtSpeaker
        '
        Me.txtSpeaker.Location = New System.Drawing.Point(162, 96)
        Me.txtSpeaker.Name = "txtSpeaker"
        Me.txtSpeaker.Size = New System.Drawing.Size(32, 20)
        Me.txtSpeaker.TabIndex = 15
        '
        'txtKeyboard
        '
        Me.txtKeyboard.Location = New System.Drawing.Point(60, 96)
        Me.txtKeyboard.Name = "txtKeyboard"
        Me.txtKeyboard.Size = New System.Drawing.Size(32, 20)
        Me.txtKeyboard.TabIndex = 14
        '
        'txtMonitor
        '
        Me.txtMonitor.Location = New System.Drawing.Point(162, 48)
        Me.txtMonitor.Name = "txtMonitor"
        Me.txtMonitor.Size = New System.Drawing.Size(32, 20)
        Me.txtMonitor.TabIndex = 13
        '
        'chkSpeaker
        '
        Me.chkSpeaker.AutoSize = True
        Me.chkSpeaker.Location = New System.Drawing.Point(113, 74)
        Me.chkSpeaker.Name = "chkSpeaker"
        Me.chkSpeaker.Size = New System.Drawing.Size(71, 17)
        Me.chkSpeaker.TabIndex = 11
        Me.chkSpeaker.Text = "Speakers"
        Me.chkSpeaker.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Location = New System.Drawing.Point(12, 28)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(58, 17)
        Me.chkMouse.TabIndex = 8
        Me.chkMouse.Text = "Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkMonitor
        '
        Me.chkMonitor.AutoSize = True
        Me.chkMonitor.Location = New System.Drawing.Point(113, 28)
        Me.chkMonitor.Name = "chkMonitor"
        Me.chkMonitor.Size = New System.Drawing.Size(61, 17)
        Me.chkMonitor.TabIndex = 10
        Me.chkMonitor.Text = "Monitor"
        Me.chkMonitor.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(12, 74)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(71, 17)
        Me.chkKeyboard.TabIndex = 9
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'lstQuote
        '
        Me.lstQuote.ForeColor = System.Drawing.Color.Green
        Me.lstQuote.FormattingEnabled = True
        Me.lstQuote.Location = New System.Drawing.Point(13, 359)
        Me.lstQuote.Name = "lstQuote"
        Me.lstQuote.Size = New System.Drawing.Size(579, 277)
        Me.lstQuote.TabIndex = 5
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(248, 316)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(110, 35)
        Me.btnQuote.TabIndex = 6
        Me.btnQuote.Text = "GET QUOTE"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(263, 642)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(507, 642)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 642)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 35)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save Quote"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SaveToolStripMenuItem.Text = "Save File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColourToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ColourToolStripMenuItem
        '
        Me.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem"
        Me.ColourToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColourToolStripMenuItem.Text = "Colour"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'lblPrices
        '
        Me.lblPrices.Location = New System.Drawing.Point(218, 217)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(168, 94)
        Me.lblPrices.TabIndex = 12
        Me.lblPrices.Text = "HDD - R 940.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RAM - R 429.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mouse - R 99.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyboard - R 125.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monitor -" &
    " R 1120.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Speaker - R 289.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkPrices
        '
        Me.chkPrices.AutoSize = True
        Me.chkPrices.Location = New System.Drawing.Point(12, 134)
        Me.chkPrices.Name = "chkPrices"
        Me.chkPrices.Size = New System.Drawing.Size(81, 17)
        Me.chkPrices.TabIndex = 13
        Me.chkPrices.Text = "View Prices"
        Me.chkPrices.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(606, 690)
        Me.Controls.Add(Me.chkPrices)
        Me.Controls.Add(Me.lblPrices)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.lstQuote)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "THATO COMPUTERS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkStandard As CheckBox
    Friend WithEvents chkHDD As CheckBox
    Friend WithEvents chkRAM As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSpeaker As CheckBox
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents chkMonitor As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents lstQuote As ListBox
    Friend WithEvents btnQuote As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cboModHDD As ComboBox
    Friend WithEvents cboModRAM As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txtMouse As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSpeaker As TextBox
    Friend WithEvents txtKeyboard As TextBox
    Friend WithEvents txtMonitor As TextBox
    Friend WithEvents lblPrices As Label
    Friend WithEvents chkPrices As CheckBox
End Class
