<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MESSAGE_UI
    Inherits UI.Window

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
        Me.PbIcon = New DAX.OSI.UI.UIPictureBox()
        Me.LblMessage = New DAX.OSI.UI.UILabel()
        Me.BtnOkay = New DAX.OSI.UI.UIButton()
        CType(Me.PbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbIcon
        '
        Me.PbIcon.BackColor = System.Drawing.Color.Transparent
        Me.PbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PbIcon.Location = New System.Drawing.Point(8, 26)
        Me.PbIcon.MaximumSize = New System.Drawing.Size(90, 70)
        Me.PbIcon.MinimumSize = New System.Drawing.Size(90, 70)
        Me.PbIcon.Name = "PbIcon"
        Me.PbIcon.Size = New System.Drawing.Size(90, 70)
        Me.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbIcon.TabIndex = 1
        Me.PbIcon.TabStop = False
        '
        'LblMessage
        '
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblMessage.Location = New System.Drawing.Point(101, 26)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(225, 70)
        Me.LblMessage.TabIndex = 2
        Me.LblMessage.Text = "Hello World!"
        Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOkay
        '
        Me.BtnOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnOkay.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BtnOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOkay.InheritUserProfileColorTheme = True
        Me.BtnOkay.Location = New System.Drawing.Point(128, 105)
        Me.BtnOkay.Name = "BtnOkay"
        Me.BtnOkay.Size = New System.Drawing.Size(75, 28)
        Me.BtnOkay.TabIndex = 3
        Me.BtnOkay.Text = "Okay"
        '
        'MESSAGE_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 141)
        Me.Controls.Add(Me.BtnOkay)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.PbIcon)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.Name = "MESSAGE_UI"
        Me.ShowIcon = False
        Me.Text = "Message UI"
        CType(Me.PbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbIcon As UI.UIPictureBox
    Friend WithEvents LblMessage As UI.UILabel
    Friend WithEvents BtnOkay As UI.UIButton
End Class
