<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MD5_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MD5_Form))
        Me.TextBox_Phrase = New System.Windows.Forms.TextBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Instruction = New System.Windows.Forms.Label()
        Me.Label_Progress = New System.Windows.Forms.Label()
        Me.btn_Generate = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label_MD5Gend = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_Phrase
        '
        Me.TextBox_Phrase.Location = New System.Drawing.Point(12, 46)
        Me.TextBox_Phrase.Name = "TextBox_Phrase"
        Me.TextBox_Phrase.Size = New System.Drawing.Size(260, 20)
        Me.TextBox_Phrase.TabIndex = 0
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(13, 13)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(133, 13)
        Me.Label_Title.TabIndex = 1
        Me.Label_Title.Text = "MD5 Encryption Generator"
        '
        'Label_Instruction
        '
        Me.Label_Instruction.AutoSize = True
        Me.Label_Instruction.Location = New System.Drawing.Point(13, 30)
        Me.Label_Instruction.Name = "Label_Instruction"
        Me.Label_Instruction.Size = New System.Drawing.Size(174, 13)
        Me.Label_Instruction.TabIndex = 2
        Me.Label_Instruction.Text = "Please insert your ""special phrase"":"
        '
        'Label_Progress
        '
        Me.Label_Progress.AutoSize = True
        Me.Label_Progress.Location = New System.Drawing.Point(12, 73)
        Me.Label_Progress.Name = "Label_Progress"
        Me.Label_Progress.Size = New System.Drawing.Size(57, 13)
        Me.Label_Progress.TabIndex = 3
        Me.Label_Progress.Text = "Progress : "
        '
        'btn_Generate
        '
        Me.btn_Generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Generate.Location = New System.Drawing.Point(16, 118)
        Me.btn_Generate.Name = "btn_Generate"
        Me.btn_Generate.Size = New System.Drawing.Size(75, 23)
        Me.btn_Generate.TabIndex = 4
        Me.btn_Generate.Text = "Generate"
        Me.btn_Generate.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Location = New System.Drawing.Point(197, 118)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 5
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'Label_MD5Gend
        '
        Me.Label_MD5Gend.AutoSize = True
        Me.Label_MD5Gend.Location = New System.Drawing.Point(13, 86)
        Me.Label_MD5Gend.Name = "Label_MD5Gend"
        Me.Label_MD5Gend.Size = New System.Drawing.Size(39, 13)
        Me.Label_MD5Gend.TabIndex = 6
        Me.Label_MD5Gend.Text = "MD5 : "
        '
        'MD5_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 153)
        Me.Controls.Add(Me.Label_MD5Gend)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Generate)
        Me.Controls.Add(Me.Label_Progress)
        Me.Controls.Add(Me.Label_Instruction)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.TextBox_Phrase)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MD5_Form"
        Me.Text = "MD5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Phrase As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Instruction As Label
    Friend WithEvents Label_Progress As Label
    Friend WithEvents btn_Generate As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents Label_MD5Gend As Label
End Class
