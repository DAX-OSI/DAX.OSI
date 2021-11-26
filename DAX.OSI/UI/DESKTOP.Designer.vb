<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DESKTOP
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
        Me.PnlTaskBar = New DAX.OSI.UI.UIPanel()
        Me.LlOpenApplicationsMenu = New DAX.OSI.UI.UILinkLabel()
        Me.ClockWidget = New DAX.OSI.UI.UIClockWidget()
        Me.PnlApplicationsWindow = New DAX.OSI.UI.UIPanel()
        Me.LlOpenProfileManagerApplication = New DAX.OSI.UI.UILinkLabel()
        Me.LlOpenConsoleApplication = New DAX.OSI.UI.UILinkLabel()
        Me.UIProfileImageWidget = New DAX.OSI.UI.UIUserProfileImage()
        Me.LlShutdown = New DAX.OSI.UI.UILinkLabel()
        Me.LlSignout = New DAX.OSI.UI.UILinkLabel()
        Me.PnlTaskBar.SuspendLayout()
        Me.PnlApplicationsWindow.SuspendLayout()
        CType(Me.UIProfileImageWidget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTaskBar
        '
        Me.PnlTaskBar.BackColor = System.Drawing.Color.Transparent
        Me.PnlTaskBar.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.shader
        Me.PnlTaskBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTaskBar.Controls.Add(Me.LlOpenApplicationsMenu)
        Me.PnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTaskBar.Location = New System.Drawing.Point(0, 0)
        Me.PnlTaskBar.Name = "PnlTaskBar"
        Me.PnlTaskBar.Size = New System.Drawing.Size(640, 20)
        Me.PnlTaskBar.TabIndex = 0
        '
        'LlOpenApplicationsMenu
        '
        Me.LlOpenApplicationsMenu.AutoSize = True
        Me.LlOpenApplicationsMenu.BackColor = System.Drawing.Color.Transparent
        Me.LlOpenApplicationsMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlOpenApplicationsMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlOpenApplicationsMenu.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlOpenApplicationsMenu.InheritUserProfileColorTheme = True
        Me.LlOpenApplicationsMenu.Location = New System.Drawing.Point(0, 3)
        Me.LlOpenApplicationsMenu.Name = "LlOpenApplicationsMenu"
        Me.LlOpenApplicationsMenu.Size = New System.Drawing.Size(77, 13)
        Me.LlOpenApplicationsMenu.TabIndex = 1
        Me.LlOpenApplicationsMenu.Text = "Applications |"
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
        Me.ClockWidget.TabIndex = 1
        Me.ClockWidget.Text = "UiClockWidget1"
        '
        'PnlApplicationsWindow
        '
        Me.PnlApplicationsWindow.BackColor = System.Drawing.Color.Transparent
        Me.PnlApplicationsWindow.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.shader
        Me.PnlApplicationsWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlApplicationsWindow.Controls.Add(Me.LlOpenProfileManagerApplication)
        Me.PnlApplicationsWindow.Controls.Add(Me.LlOpenConsoleApplication)
        Me.PnlApplicationsWindow.Controls.Add(Me.UIProfileImageWidget)
        Me.PnlApplicationsWindow.Controls.Add(Me.LlShutdown)
        Me.PnlApplicationsWindow.Controls.Add(Me.LlSignout)
        Me.PnlApplicationsWindow.Location = New System.Drawing.Point(0, 20)
        Me.PnlApplicationsWindow.Name = "PnlApplicationsWindow"
        Me.PnlApplicationsWindow.Size = New System.Drawing.Size(250, 270)
        Me.PnlApplicationsWindow.TabIndex = 2
        Me.PnlApplicationsWindow.Visible = False
        '
        'LlOpenProfileManagerApplication
        '
        Me.LlOpenProfileManagerApplication.AutoSize = True
        Me.LlOpenProfileManagerApplication.BackColor = System.Drawing.Color.Transparent
        Me.LlOpenProfileManagerApplication.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LlOpenProfileManagerApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlOpenProfileManagerApplication.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlOpenProfileManagerApplication.InheritUserProfileColorTheme = True
        Me.LlOpenProfileManagerApplication.Location = New System.Drawing.Point(3, 240)
        Me.LlOpenProfileManagerApplication.Name = "LlOpenProfileManagerApplication"
        Me.LlOpenProfileManagerApplication.Size = New System.Drawing.Size(30, 24)
        Me.LlOpenProfileManagerApplication.TabIndex = 6
        Me.LlOpenProfileManagerApplication.Text = "@"
        '
        'LlOpenConsoleApplication
        '
        Me.LlOpenConsoleApplication.AutoSize = True
        Me.LlOpenConsoleApplication.BackColor = System.Drawing.Color.Transparent
        Me.LlOpenConsoleApplication.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LlOpenConsoleApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlOpenConsoleApplication.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlOpenConsoleApplication.InheritUserProfileColorTheme = True
        Me.LlOpenConsoleApplication.Location = New System.Drawing.Point(81, 6)
        Me.LlOpenConsoleApplication.Name = "LlOpenConsoleApplication"
        Me.LlOpenConsoleApplication.Size = New System.Drawing.Size(60, 13)
        Me.LlOpenConsoleApplication.TabIndex = 5
        Me.LlOpenConsoleApplication.Text = "+ Console"
        '
        'UIProfileImageWidget
        '
        Me.UIProfileImageWidget.BackColor = System.Drawing.Color.Transparent
        Me.UIProfileImageWidget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UIProfileImageWidget.Location = New System.Drawing.Point(7, 6)
        Me.UIProfileImageWidget.MaximumSize = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.MinimumSize = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.Name = "UIProfileImageWidget"
        Me.UIProfileImageWidget.Size = New System.Drawing.Size(68, 64)
        Me.UIProfileImageWidget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UIProfileImageWidget.TabIndex = 4
        Me.UIProfileImageWidget.TabStop = False
        '
        'LlShutdown
        '
        Me.LlShutdown.AutoSize = True
        Me.LlShutdown.BackColor = System.Drawing.Color.Transparent
        Me.LlShutdown.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LlShutdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlShutdown.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlShutdown.InheritUserProfileColorTheme = True
        Me.LlShutdown.Location = New System.Drawing.Point(186, 251)
        Me.LlShutdown.Name = "LlShutdown"
        Me.LlShutdown.Size = New System.Drawing.Size(61, 13)
        Me.LlShutdown.TabIndex = 1
        Me.LlShutdown.Text = "Shutdown"
        '
        'LlSignout
        '
        Me.LlSignout.AutoSize = True
        Me.LlSignout.BackColor = System.Drawing.Color.Transparent
        Me.LlSignout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LlSignout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LlSignout.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LlSignout.InheritUserProfileColorTheme = True
        Me.LlSignout.Location = New System.Drawing.Point(194, 233)
        Me.LlSignout.Name = "LlSignout"
        Me.LlSignout.Size = New System.Drawing.Size(53, 13)
        Me.LlSignout.TabIndex = 0
        Me.LlSignout.Text = "Sign Out"
        '
        'DESKTOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DAX.OSI.My.Resources.Resources.vignette
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.PnlApplicationsWindow)
        Me.Controls.Add(Me.ClockWidget)
        Me.Controls.Add(Me.PnlTaskBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.InheritUserProfileColorTheme = True
        Me.Name = "DESKTOP"
        Me.Text = "DESKTOP"
        Me.TopMost = False
        Me.PnlTaskBar.ResumeLayout(False)
        Me.PnlTaskBar.PerformLayout()
        Me.PnlApplicationsWindow.ResumeLayout(False)
        Me.PnlApplicationsWindow.PerformLayout()
        CType(Me.UIProfileImageWidget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTaskBar As UI.UIPanel
    Friend WithEvents LlOpenApplicationsMenu As UI.UILinkLabel
    Friend WithEvents ClockWidget As UI.UIClockWidget
    Friend WithEvents PnlApplicationsWindow As UI.UIPanel
    Friend WithEvents LlSignout As UI.UILinkLabel
    Friend WithEvents LlShutdown As UI.UILinkLabel
    Friend WithEvents UIProfileImageWidget As UI.UIUserProfileImage
    Friend WithEvents LlOpenProfileManagerApplication As UI.UILinkLabel
    Friend WithEvents LlOpenConsoleApplication As UI.UILinkLabel
End Class
