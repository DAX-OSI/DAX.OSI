<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BOOT_MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOOT_MENU))
        Me.PnlHeaderBar = New DAX.OSI.UI.UIPanel()
        Me.LblUICaption = New DAX.OSI.UI.UILabel()
        Me.PnlMainWindow = New DAX.OSI.UI.UIPanel()
        Me.BtnOpenConsoleWindow = New DAX.OSI.UI.UIButton()
        Me.BtnRunDAXOSI = New DAX.OSI.UI.UIButton()
        Me.PnlConsoleWindow = New DAX.OSI.UI.UIPanel()
        Me.Console = New DAX.OSI.UI.UIConsole()
        Me.PnlConsoleWindowHeader = New DAX.OSI.UI.UIPanel()
        Me.LblConsoleWindowCaption = New DAX.OSI.UI.UILabel()
        Me.PnlSetupWindow2 = New DAX.OSI.UI.UIPanel()
        Me.txtbSetUserProfilePassword = New DAX.OSI.UI.UITextBox()
        Me.BtnSetup2Next = New DAX.OSI.UI.UIButton()
        Me.LblSetupMessage2 = New DAX.OSI.UI.UILabel()
        Me.LblSetupWindow2Caption = New DAX.OSI.UI.UILabel()
        Me.PnlSetupWindow1 = New DAX.OSI.UI.UIPanel()
        Me.BtnSetup1Next = New DAX.OSI.UI.UIButton()
        Me.LblSetupMessage1 = New DAX.OSI.UI.UILabel()
        Me.LblSetupWindow1Caption = New DAX.OSI.UI.UILabel()
        Me.PnlSetupWindow3 = New DAX.OSI.UI.UIPanel()
        Me.BtnSetup3Next = New DAX.OSI.UI.UIButton()
        Me.LblSetupMessage3 = New DAX.OSI.UI.UILabel()
        Me.LblSetupWindow3Caption = New DAX.OSI.UI.UILabel()
        Me.PnlHeaderBar.SuspendLayout()
        Me.PnlMainWindow.SuspendLayout()
        Me.PnlConsoleWindow.SuspendLayout()
        Me.PnlConsoleWindowHeader.SuspendLayout()
        Me.PnlSetupWindow2.SuspendLayout()
        Me.PnlSetupWindow1.SuspendLayout()
        Me.PnlSetupWindow3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeaderBar
        '
        Me.PnlHeaderBar.BackColor = System.Drawing.Color.Gray
        Me.PnlHeaderBar.Controls.Add(Me.LblUICaption)
        Me.PnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeaderBar.Name = "PnlHeaderBar"
        Me.PnlHeaderBar.Size = New System.Drawing.Size(640, 20)
        Me.PnlHeaderBar.TabIndex = 0
        '
        'LblUICaption
        '
        Me.LblUICaption.AutoSize = True
        Me.LblUICaption.BackColor = System.Drawing.Color.Transparent
        Me.LblUICaption.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUICaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblUICaption.Location = New System.Drawing.Point(0, 4)
        Me.LblUICaption.Name = "LblUICaption"
        Me.LblUICaption.Size = New System.Drawing.Size(151, 13)
        Me.LblUICaption.TabIndex = 1
        Me.LblUICaption.Text = "DAX OSI: BOOT MENU"
        '
        'PnlMainWindow
        '
        Me.PnlMainWindow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlMainWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMainWindow.Controls.Add(Me.BtnOpenConsoleWindow)
        Me.PnlMainWindow.Controls.Add(Me.BtnRunDAXOSI)
        Me.PnlMainWindow.Location = New System.Drawing.Point(215, 205)
        Me.PnlMainWindow.Name = "PnlMainWindow"
        Me.PnlMainWindow.Size = New System.Drawing.Size(210, 70)
        Me.PnlMainWindow.TabIndex = 1
        '
        'BtnOpenConsoleWindow
        '
        Me.BtnOpenConsoleWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOpenConsoleWindow.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenConsoleWindow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOpenConsoleWindow.InheritUserProfileColorTheme = False
        Me.BtnOpenConsoleWindow.Location = New System.Drawing.Point(44, 36)
        Me.BtnOpenConsoleWindow.Name = "BtnOpenConsoleWindow"
        Me.BtnOpenConsoleWindow.Size = New System.Drawing.Size(120, 25)
        Me.BtnOpenConsoleWindow.TabIndex = 1
        Me.BtnOpenConsoleWindow.Text = "OPEN: CONSOLE"
        '
        'BtnRunDAXOSI
        '
        Me.BtnRunDAXOSI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRunDAXOSI.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunDAXOSI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRunDAXOSI.InheritUserProfileColorTheme = False
        Me.BtnRunDAXOSI.Location = New System.Drawing.Point(44, 8)
        Me.BtnRunDAXOSI.Name = "BtnRunDAXOSI"
        Me.BtnRunDAXOSI.Size = New System.Drawing.Size(120, 25)
        Me.BtnRunDAXOSI.TabIndex = 0
        Me.BtnRunDAXOSI.Text = "RUN: DAX OSI"
        '
        'PnlConsoleWindow
        '
        Me.PnlConsoleWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PnlConsoleWindow.Controls.Add(Me.Console)
        Me.PnlConsoleWindow.Controls.Add(Me.PnlConsoleWindowHeader)
        Me.PnlConsoleWindow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlConsoleWindow.Location = New System.Drawing.Point(0, 316)
        Me.PnlConsoleWindow.Name = "PnlConsoleWindow"
        Me.PnlConsoleWindow.Size = New System.Drawing.Size(640, 164)
        Me.PnlConsoleWindow.TabIndex = 2
        Me.PnlConsoleWindow.Visible = False
        '
        'Console
        '
        Me.Console.BackColor = System.Drawing.Color.Transparent
        Me.Console.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Console.Location = New System.Drawing.Point(0, 20)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(640, 144)
        Me.Console.TabIndex = 1
        '
        'PnlConsoleWindowHeader
        '
        Me.PnlConsoleWindowHeader.BackColor = System.Drawing.Color.Gray
        Me.PnlConsoleWindowHeader.Controls.Add(Me.LblConsoleWindowCaption)
        Me.PnlConsoleWindowHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlConsoleWindowHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlConsoleWindowHeader.Name = "PnlConsoleWindowHeader"
        Me.PnlConsoleWindowHeader.Size = New System.Drawing.Size(640, 20)
        Me.PnlConsoleWindowHeader.TabIndex = 0
        '
        'LblConsoleWindowCaption
        '
        Me.LblConsoleWindowCaption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblConsoleWindowCaption.AutoSize = True
        Me.LblConsoleWindowCaption.BackColor = System.Drawing.Color.Transparent
        Me.LblConsoleWindowCaption.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsoleWindowCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblConsoleWindowCaption.Location = New System.Drawing.Point(289, 4)
        Me.LblConsoleWindowCaption.Name = "LblConsoleWindowCaption"
        Me.LblConsoleWindowCaption.Size = New System.Drawing.Size(63, 13)
        Me.LblConsoleWindowCaption.TabIndex = 2
        Me.LblConsoleWindowCaption.Text = "CONSOLE"
        '
        'PnlSetupWindow2
        '
        Me.PnlSetupWindow2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlSetupWindow2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlSetupWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSetupWindow2.Controls.Add(Me.txtbSetUserProfilePassword)
        Me.PnlSetupWindow2.Controls.Add(Me.BtnSetup2Next)
        Me.PnlSetupWindow2.Controls.Add(Me.LblSetupMessage2)
        Me.PnlSetupWindow2.Controls.Add(Me.LblSetupWindow2Caption)
        Me.PnlSetupWindow2.Location = New System.Drawing.Point(45, 170)
        Me.PnlSetupWindow2.Name = "PnlSetupWindow2"
        Me.PnlSetupWindow2.Size = New System.Drawing.Size(550, 140)
        Me.PnlSetupWindow2.TabIndex = 4
        Me.PnlSetupWindow2.Visible = False
        '
        'txtbSetUserProfilePassword
        '
        Me.txtbSetUserProfilePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbSetUserProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbSetUserProfilePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbSetUserProfilePassword.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSetUserProfilePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbSetUserProfilePassword.Location = New System.Drawing.Point(235, 82)
        Me.txtbSetUserProfilePassword.Name = "txtbSetUserProfilePassword"
        Me.txtbSetUserProfilePassword.Size = New System.Drawing.Size(78, 13)
        Me.txtbSetUserProfilePassword.TabIndex = 5
        Me.txtbSetUserProfilePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbSetUserProfilePassword.UseSystemPasswordChar = True
        '
        'BtnSetup2Next
        '
        Me.BtnSetup2Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSetup2Next.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetup2Next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSetup2Next.InheritUserProfileColorTheme = False
        Me.BtnSetup2Next.Location = New System.Drawing.Point(244, 113)
        Me.BtnSetup2Next.Name = "BtnSetup2Next"
        Me.BtnSetup2Next.Size = New System.Drawing.Size(60, 20)
        Me.BtnSetup2Next.TabIndex = 4
        Me.BtnSetup2Next.Text = "NEXT"
        '
        'LblSetupMessage2
        '
        Me.LblSetupMessage2.AutoSize = True
        Me.LblSetupMessage2.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupMessage2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupMessage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupMessage2.Location = New System.Drawing.Point(1, 25)
        Me.LblSetupMessage2.Name = "LblSetupMessage2"
        Me.LblSetupMessage2.Size = New System.Drawing.Size(481, 55)
        Me.LblSetupMessage2.TabIndex = 1
        Me.LblSetupMessage2.Text = resources.GetString("LblSetupMessage2.Text")
        '
        'LblSetupWindow2Caption
        '
        Me.LblSetupWindow2Caption.AutoSize = True
        Me.LblSetupWindow2Caption.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupWindow2Caption.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupWindow2Caption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupWindow2Caption.Location = New System.Drawing.Point(2, 4)
        Me.LblSetupWindow2Caption.Name = "LblSetupWindow2Caption"
        Me.LblSetupWindow2Caption.Size = New System.Drawing.Size(286, 15)
        Me.LblSetupWindow2Caption.TabIndex = 0
        Me.LblSetupWindow2Caption.Text = "PROFILE NAME: EVNIRONTMENT.USER"
        '
        'PnlSetupWindow1
        '
        Me.PnlSetupWindow1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlSetupWindow1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlSetupWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSetupWindow1.Controls.Add(Me.BtnSetup1Next)
        Me.PnlSetupWindow1.Controls.Add(Me.LblSetupMessage1)
        Me.PnlSetupWindow1.Controls.Add(Me.LblSetupWindow1Caption)
        Me.PnlSetupWindow1.Location = New System.Drawing.Point(45, 170)
        Me.PnlSetupWindow1.Name = "PnlSetupWindow1"
        Me.PnlSetupWindow1.Size = New System.Drawing.Size(550, 140)
        Me.PnlSetupWindow1.TabIndex = 3
        Me.PnlSetupWindow1.Visible = False
        '
        'BtnSetup1Next
        '
        Me.BtnSetup1Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSetup1Next.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetup1Next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSetup1Next.InheritUserProfileColorTheme = False
        Me.BtnSetup1Next.Location = New System.Drawing.Point(244, 113)
        Me.BtnSetup1Next.Name = "BtnSetup1Next"
        Me.BtnSetup1Next.Size = New System.Drawing.Size(60, 20)
        Me.BtnSetup1Next.TabIndex = 4
        Me.BtnSetup1Next.Text = "NEXT"
        '
        'LblSetupMessage1
        '
        Me.LblSetupMessage1.AutoSize = True
        Me.LblSetupMessage1.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupMessage1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupMessage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupMessage1.Location = New System.Drawing.Point(1, 25)
        Me.LblSetupMessage1.Name = "LblSetupMessage1"
        Me.LblSetupMessage1.Size = New System.Drawing.Size(530, 88)
        Me.LblSetupMessage1.TabIndex = 1
        Me.LblSetupMessage1.Text = resources.GetString("LblSetupMessage1.Text")
        '
        'LblSetupWindow1Caption
        '
        Me.LblSetupWindow1Caption.AutoSize = True
        Me.LblSetupWindow1Caption.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupWindow1Caption.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupWindow1Caption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupWindow1Caption.Location = New System.Drawing.Point(2, 4)
        Me.LblSetupWindow1Caption.Name = "LblSetupWindow1Caption"
        Me.LblSetupWindow1Caption.Size = New System.Drawing.Size(133, 15)
        Me.LblSetupWindow1Caption.TabIndex = 0
        Me.LblSetupWindow1Caption.Text = "DAX OSI: SETUP"
        '
        'PnlSetupWindow3
        '
        Me.PnlSetupWindow3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlSetupWindow3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlSetupWindow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSetupWindow3.Controls.Add(Me.BtnSetup3Next)
        Me.PnlSetupWindow3.Controls.Add(Me.LblSetupMessage3)
        Me.PnlSetupWindow3.Controls.Add(Me.LblSetupWindow3Caption)
        Me.PnlSetupWindow3.Location = New System.Drawing.Point(45, 170)
        Me.PnlSetupWindow3.Name = "PnlSetupWindow3"
        Me.PnlSetupWindow3.Size = New System.Drawing.Size(550, 140)
        Me.PnlSetupWindow3.TabIndex = 5
        Me.PnlSetupWindow3.Visible = False
        '
        'BtnSetup3Next
        '
        Me.BtnSetup3Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSetup3Next.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetup3Next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSetup3Next.InheritUserProfileColorTheme = False
        Me.BtnSetup3Next.Location = New System.Drawing.Point(244, 113)
        Me.BtnSetup3Next.Name = "BtnSetup3Next"
        Me.BtnSetup3Next.Size = New System.Drawing.Size(60, 20)
        Me.BtnSetup3Next.TabIndex = 4
        Me.BtnSetup3Next.Text = "FINISH"
        '
        'LblSetupMessage3
        '
        Me.LblSetupMessage3.AutoSize = True
        Me.LblSetupMessage3.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupMessage3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupMessage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupMessage3.Location = New System.Drawing.Point(1, 25)
        Me.LblSetupMessage3.Name = "LblSetupMessage3"
        Me.LblSetupMessage3.Size = New System.Drawing.Size(551, 66)
        Me.LblSetupMessage3.TabIndex = 1
        Me.LblSetupMessage3.Text = resources.GetString("LblSetupMessage3.Text")
        '
        'LblSetupWindow3Caption
        '
        Me.LblSetupWindow3Caption.AutoSize = True
        Me.LblSetupWindow3Caption.BackColor = System.Drawing.Color.Transparent
        Me.LblSetupWindow3Caption.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSetupWindow3Caption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblSetupWindow3Caption.Location = New System.Drawing.Point(2, 4)
        Me.LblSetupWindow3Caption.Name = "LblSetupWindow3Caption"
        Me.LblSetupWindow3Caption.Size = New System.Drawing.Size(133, 15)
        Me.LblSetupWindow3Caption.TabIndex = 0
        Me.LblSetupWindow3Caption.Text = "DAX OSI: SETUP"
        '
        'BOOT_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.PnlSetupWindow3)
        Me.Controls.Add(Me.PnlConsoleWindow)
        Me.Controls.Add(Me.PnlHeaderBar)
        Me.Controls.Add(Me.PnlMainWindow)
        Me.Controls.Add(Me.PnlSetupWindow2)
        Me.Controls.Add(Me.PnlSetupWindow1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "BOOT_MENU"
        Me.Text = "BOOT_MENU"
        Me.TopMost = False
        Me.PnlHeaderBar.ResumeLayout(False)
        Me.PnlHeaderBar.PerformLayout()
        Me.PnlMainWindow.ResumeLayout(False)
        Me.PnlConsoleWindow.ResumeLayout(False)
        Me.PnlConsoleWindowHeader.ResumeLayout(False)
        Me.PnlConsoleWindowHeader.PerformLayout()
        Me.PnlSetupWindow2.ResumeLayout(False)
        Me.PnlSetupWindow2.PerformLayout()
        Me.PnlSetupWindow1.ResumeLayout(False)
        Me.PnlSetupWindow1.PerformLayout()
        Me.PnlSetupWindow3.ResumeLayout(False)
        Me.PnlSetupWindow3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHeaderBar As UI.UIPanel
    Friend WithEvents LblUICaption As UI.UILabel
    Friend WithEvents PnlMainWindow As UI.UIPanel
    Friend WithEvents BtnOpenConsoleWindow As UI.UIButton
    Friend WithEvents BtnRunDAXOSI As UI.UIButton
    Friend WithEvents PnlConsoleWindow As UI.UIPanel
    Friend WithEvents Console As UI.UIConsole
    Friend WithEvents PnlConsoleWindowHeader As UI.UIPanel
    Friend WithEvents LblConsoleWindowCaption As UI.UILabel
    Friend WithEvents PnlSetupWindow1 As UI.UIPanel
    Friend WithEvents BtnSetup1Next As UI.UIButton
    Friend WithEvents LblSetupMessage1 As UI.UILabel
    Friend WithEvents LblSetupWindow1Caption As UI.UILabel
    Friend WithEvents PnlSetupWindow2 As UI.UIPanel
    Friend WithEvents BtnSetup2Next As UI.UIButton
    Friend WithEvents LblSetupMessage2 As UI.UILabel
    Friend WithEvents LblSetupWindow2Caption As UI.UILabel
    Friend WithEvents PnlSetupWindow3 As UI.UIPanel
    Friend WithEvents BtnSetup3Next As UI.UIButton
    Friend WithEvents LblSetupMessage3 As UI.UILabel
    Friend WithEvents LblSetupWindow3Caption As UI.UILabel
    Friend WithEvents txtbSetUserProfilePassword As UI.UITextBox
End Class
