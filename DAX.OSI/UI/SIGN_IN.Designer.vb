<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SIGN_IN
    Inherits UI.BlankWindow

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIGN_IN))
        Me.PnlTaskBar = New DAX.OSI.UI.UIPanel()
        Me.LlShutdown = New DAX.OSI.UI.UILinkLabel()
        Me.PnlSignInWindow = New DAX.OSI.UI.UIPanel()
        Me.LblWelcomeUser = New DAX.OSI.UI.UILabel()
        Me.UIProfileImageWidget = New DAX.OSI.UI.UIUserProfileImage()
        Me.txtbUserProfilePassword = New DAX.OSI.UI.UITextBox()
        Me.BtnSignIn = New DAX.OSI.UI.UIButton()
        Me.ClockWidget = New DAX.OSI.UI.UIClockWidget()
        Me.PbDAXOSILogo = New DAX.OSI.UI.UIPictureBox()
        Me.PnlTaskBar.SuspendLayout()
        Me.PnlSignInWindow.SuspendLayout()
        CType(Me.UIProfileImageWidget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbDAXOSILogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTaskBar
        '
        Me.PnlTaskBar.BackColor = System.Drawing.Color.Transparent
        Me.PnlTaskBar.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.shader
        Me.PnlTaskBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTaskBar.Controls.Add(Me.LlShutdown)
        Me.PnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTaskBar.Location = New System.Drawing.Point(0, 0)
        Me.PnlTaskBar.Name = "PnlTaskBar"
        Me.PnlTaskBar.Size = New System.Drawing.Size(640, 20)
        Me.PnlTaskBar.TabIndex = 0
        '
        'LlShutdown
        '
        Me.LlShutdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LlShutdown.AutoSize = True
        Me.LlShutdown.BackColor = System.Drawing.Color.Transparent
        Me.LlShutdown.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LlShutdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlShutdown.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlShutdown.InheritUserProfileColorTheme = True
        Me.LlShutdown.Location = New System.Drawing.Point(579, 3)
        Me.LlShutdown.Name = "LlShutdown"
        Me.LlShutdown.Size = New System.Drawing.Size(61, 13)
        Me.LlShutdown.TabIndex = 3
        Me.LlShutdown.Text = "Shutdown"
        '
        'PnlSignInWindow
        '
        Me.PnlSignInWindow.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PnlSignInWindow.BackColor = System.Drawing.Color.Transparent
        Me.PnlSignInWindow.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.shader
        Me.PnlSignInWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlSignInWindow.Controls.Add(Me.LblWelcomeUser)
        Me.PnlSignInWindow.Controls.Add(Me.UIProfileImageWidget)
        Me.PnlSignInWindow.Controls.Add(Me.txtbUserProfilePassword)
        Me.PnlSignInWindow.Controls.Add(Me.BtnSignIn)
        Me.PnlSignInWindow.Location = New System.Drawing.Point(12, 206)
        Me.PnlSignInWindow.Name = "PnlSignInWindow"
        Me.PnlSignInWindow.Size = New System.Drawing.Size(261, 86)
        Me.PnlSignInWindow.TabIndex = 1
        '
        'LblWelcomeUser
        '
        Me.LblWelcomeUser.BackColor = System.Drawing.Color.Transparent
        Me.LblWelcomeUser.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblWelcomeUser.Location = New System.Drawing.Point(79, 21)
        Me.LblWelcomeUser.Name = "LblWelcomeUser"
        Me.LblWelcomeUser.Size = New System.Drawing.Size(180, 13)
        Me.LblWelcomeUser.TabIndex = 3
        Me.LblWelcomeUser.Text = "Welcome, <Profile.Name>"
        Me.LblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UIProfileImageWidget
        '
        Me.UIProfileImageWidget.BackColor = System.Drawing.Color.Transparent
        Me.UIProfileImageWidget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UIProfileImageWidget.Image = CType(resources.GetObject("UIProfileImageWidget.Image"), System.Drawing.Image)
        Me.UIProfileImageWidget.Location = New System.Drawing.Point(10, 11)
        Me.UIProfileImageWidget.MaximumSize = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.MinimumSize = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.Name = "UIProfileImageWidget"
        Me.UIProfileImageWidget.Size = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UIProfileImageWidget.TabIndex = 3
        Me.UIProfileImageWidget.TabStop = False
        '
        'txtbUserProfilePassword
        '
        Me.txtbUserProfilePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txtbUserProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbUserProfilePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbUserProfilePassword.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtbUserProfilePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbUserProfilePassword.Location = New System.Drawing.Point(110, 26)
        Me.txtbUserProfilePassword.Name = "txtbUserProfilePassword"
        Me.txtbUserProfilePassword.Size = New System.Drawing.Size(116, 22)
        Me.txtbUserProfilePassword.TabIndex = 2
        Me.txtbUserProfilePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbUserProfilePassword.UseSystemPasswordChar = True
        Me.txtbUserProfilePassword.Visible = False
        '
        'BtnSignIn
        '
        Me.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.BtnSignIn.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSignIn.InheritUserProfileColorTheme = True
        Me.BtnSignIn.Location = New System.Drawing.Point(134, 54)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(70, 25)
        Me.BtnSignIn.TabIndex = 1
        Me.BtnSignIn.Text = "Sign In"
        '
        'ClockWidget
        '
        Me.ClockWidget.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClockWidget.BackColor = System.Drawing.Color.Transparent
        Me.ClockWidget.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ClockWidget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClockWidget.Location = New System.Drawing.Point(12, 393)
        Me.ClockWidget.MaximumSize = New System.Drawing.Size(480, 75)
        Me.ClockWidget.MinimumSize = New System.Drawing.Size(480, 75)
        Me.ClockWidget.Name = "ClockWidget"
        Me.ClockWidget.Size = New System.Drawing.Size(480, 75)
        Me.ClockWidget.TabIndex = 2
        Me.ClockWidget.Text = "UiClockWidget1"
        '
        'PbDAXOSILogo
        '
        Me.PbDAXOSILogo.BackColor = System.Drawing.Color.Transparent
        Me.PbDAXOSILogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PbDAXOSILogo.Image = Global.DAX.OSI.My.Resources.Resources.DAXOSI_logo
        Me.PbDAXOSILogo.Location = New System.Drawing.Point(12, 26)
        Me.PbDAXOSILogo.Name = "PbDAXOSILogo"
        Me.PbDAXOSILogo.Size = New System.Drawing.Size(225, 65)
        Me.PbDAXOSILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbDAXOSILogo.TabIndex = 3
        Me.PbDAXOSILogo.TabStop = False
        '
        'SIGN_IN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.vignette
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.PbDAXOSILogo)
        Me.Controls.Add(Me.ClockWidget)
        Me.Controls.Add(Me.PnlSignInWindow)
        Me.Controls.Add(Me.PnlTaskBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.InheritUserProfileColorTheme = True
        Me.Name = "SIGN_IN"
        Me.Text = "SIGN_IN"
        Me.TopMost = False
        Me.PnlTaskBar.ResumeLayout(False)
        Me.PnlTaskBar.PerformLayout()
        Me.PnlSignInWindow.ResumeLayout(False)
        Me.PnlSignInWindow.PerformLayout()
        CType(Me.UIProfileImageWidget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbDAXOSILogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTaskBar As UI.UIPanel
    Friend WithEvents PnlSignInWindow As UI.UIPanel
    Friend WithEvents BtnSignIn As UI.UIButton
    Friend WithEvents ClockWidget As UI.UIClockWidget
    Friend WithEvents txtbUserProfilePassword As UI.UITextBox
    Friend WithEvents LblWelcomeUser As UI.UILabel
    Friend WithEvents LlShutdown As UI.UILinkLabel
    Friend WithEvents UIProfileImageWidget As UI.UIUserProfileImage
    Friend WithEvents PbDAXOSILogo As UI.UIPictureBox
End Class
