<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.btn_Scan = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkamaiTerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_Status = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label_Progress = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Start
        '
        Me.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Start.Location = New System.Drawing.Point(13, 27)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(75, 23)
        Me.btn_Start.TabIndex = 0
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'btn_Check
        '
        Me.btn_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Check.Location = New System.Drawing.Point(94, 27)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(75, 23)
        Me.btn_Check.TabIndex = 1
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'btn_Scan
        '
        Me.btn_Scan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Scan.Location = New System.Drawing.Point(175, 27)
        Me.btn_Scan.Name = "btn_Scan"
        Me.btn_Scan.Size = New System.Drawing.Size(75, 23)
        Me.btn_Scan.TabIndex = 2
        Me.btn_Scan.Text = "Scan"
        Me.btn_Scan.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OptionToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(262, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.CLIModeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.ExpertToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ModeToolStripMenuItem.Text = "GUI mode"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'ExpertToolStripMenuItem
        '
        Me.ExpertToolStripMenuItem.Name = "ExpertToolStripMenuItem"
        Me.ExpertToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ExpertToolStripMenuItem.Text = "Expert"
        '
        'CLIModeToolStripMenuItem
        '
        Me.CLIModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkamaiTerminalToolStripMenuItem})
        Me.CLIModeToolStripMenuItem.Name = "CLIModeToolStripMenuItem"
        Me.CLIModeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CLIModeToolStripMenuItem.Text = "CLI mode"
        '
        'AkamaiTerminalToolStripMenuItem
        '
        Me.AkamaiTerminalToolStripMenuItem.Name = "AkamaiTerminalToolStripMenuItem"
        Me.AkamaiTerminalToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AkamaiTerminalToolStripMenuItem.Text = "Akamai Terminal"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptionTypeToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'EncryptionTypeToolStripMenuItem
        '
        Me.EncryptionTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5ToolStripMenuItem})
        Me.EncryptionTypeToolStripMenuItem.Name = "EncryptionTypeToolStripMenuItem"
        Me.EncryptionTypeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EncryptionTypeToolStripMenuItem.Text = "Encryption Type"
        '
        'MD5ToolStripMenuItem
        '
        Me.MD5ToolStripMenuItem.Name = "MD5ToolStripMenuItem"
        Me.MD5ToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MD5ToolStripMenuItem.Text = "MD5"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Location = New System.Drawing.Point(10, 68)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(48, 13)
        Me.Label_Version.TabIndex = 5
        Me.Label_Version.Text = "Version :"
        '
        'Label_Status
        '
        Me.Label_Status.AutoSize = True
        Me.Label_Status.Location = New System.Drawing.Point(9, 53)
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(58, 13)
        Me.Label_Status.TabIndex = 6
        Me.Label_Status.Text = "Started in :"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 84)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(157, 19)
        Me.ProgressBar.TabIndex = 7
        '
        'Label_Progress
        '
        Me.Label_Progress.AutoSize = True
        Me.Label_Progress.Location = New System.Drawing.Point(172, 90)
        Me.Label_Progress.Name = "Label_Progress"
        Me.Label_Progress.Size = New System.Drawing.Size(64, 13)
        Me.Label_Progress.TabIndex = 8
        Me.Label_Progress.Text = "% complete."
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 107)
        Me.Controls.Add(Me.Label_Progress)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label_Status)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.btn_Scan)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.btn_Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Form"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock & Go"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Check As Button
    Friend WithEvents btn_Scan As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptionTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MD5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_Version As Label
    Friend WithEvents Label_Status As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label_Progress As Label
    Friend WithEvents CLIModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AkamaiTerminalToolStripMenuItem As ToolStripMenuItem
End Class
