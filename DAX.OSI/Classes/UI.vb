Imports System.ComponentModel
Imports System.Reflection
Imports DAX.OSI.OperationHandler
Imports DAX.OSI.StructureHandler
Imports DAX.OSI.VariableHandler
Imports DAX.OSI.EventHandler

Namespace UI
    Public Class UIFramework
        Public Shared ReadOnly UIBuildFrameworkVersion As String = "1.0.0.0" 'Used for application development and to prevent mismatching UI build types.
    End Class

    Public Class BlankWindow : Inherits Form
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Private B As Bitmap, G As Graphics
        Private RenderUserProfileColorTheme As Boolean = False

        <Browsable(False),
         EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overloads Property FormBorderStyle() As FormBorderStyle
            Get
                Return FindForm.FormBorderStyle
            End Get
            Set(value As FormBorderStyle)
                FindForm.FormBorderStyle = value
            End Set
        End Property

        Public Property InheritUserProfileColorTheme() As Boolean
            Get
                Return RenderUserProfileColorTheme
            End Get
            Set(value As Boolean)
                RenderUserProfileColorTheme = value
            End Set
        End Property

        <Browsable(False),
        EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <TypeConverterAttribute(GetType(OpacityConverter))>
        Public Overloads Property Opacity() As Double
            Get
                Return FindForm.Opacity
            End Get
            Set(value As Double)
                FindForm.Opacity = value
            End Set
        End Property

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Variables.SystemBackColor
                .ControlBox = False
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .FormBorderStyle = FormBorderStyle.None
                .Icon = Nothing
                .MaximizeBox = False
                .MinimizeBox = False
                .MinimumSize = New Size(240, 90)
                .Opacity = 1
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .ShowIcon = False
                .ShowInTaskbar = False
                .StartPosition = FormStartPosition.CenterScreen
                .TopMost = True
                .WindowState = FormWindowState.Maximized
            End With
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            If Text = "BOOT_MENU" Then
                Exit Sub
            End If

            If DesignMode = True Then
                Cursor = Cursors.Default
            Else
                Try
                    Variables.OSICursor.[GetType]().InvokeMember("handle", BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetField, Nothing, Variables.OSICursor, New Object() {Variables.HandleCursor})
                    Cursor = Variables.OSICursor
                Catch ex As Exception
                    Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

            Dim Base As New Rectangle(0, 0, Width, Height)

            With G
                .PixelOffsetMode = 2
                .SmoothingMode = 2
                .TextRenderingHint = 5

                If DesignMode = True Then
                    Try 'Design time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(2)
                        If InheritUserProfileColorTheme = False Then
                            BackColor = BackColor
                        Else
                            BackColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        BackColor = BackColor
                    End Try
                Else
                    Try 'Run time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(1)
                        If InheritUserProfileColorTheme = False Then
                            BackColor = BackColor
                        Else
                            BackColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        BackColor = BackColor
                    End Try
                End If
            End With

            MyBase.OnPaint(e)
            G.Dispose()
            e.Graphics.InterpolationMode = 7
            e.Graphics.DrawImageUnscaled(B, 0, 0)
            B.Dispose()
        End Sub
    End Class

    Public Class UIButton : Inherits Control
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Private B As Bitmap, G As Graphics
        Private MouseState As Variables.MouseState = Variables.MouseState.None
        Private RenderUserProfileColorTheme As Boolean = True

        Public Property InheritUserProfileColorTheme() As Boolean
            Get
                Return RenderUserProfileColorTheme
            End Get
            Set(value As Boolean)
                RenderUserProfileColorTheme = value
            End Set
        End Property

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Variables.SystemBackColor
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
            End With
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            MouseState = Variables.MouseState.Enter : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            MouseState = Variables.MouseState.Down : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            MouseState = Variables.MouseState.Up : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            MouseState = Variables.MouseState.None : Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

            Dim Base As New Rectangle(0, 0, Width, Height)

            With G
                .PixelOffsetMode = 2
                .SmoothingMode = 2
                .TextRenderingHint = 5

                If DesignMode = True Then
                    Try 'Design time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(2)
                        If InheritUserProfileColorTheme = False Then
                            BackColor = BackColor
                        Else
                            BackColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        BackColor = BackColor
                    End Try
                Else
                    Try 'Run time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(1)
                        If InheritUserProfileColorTheme = False Then
                            BackColor = BackColor
                        Else
                            BackColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        BackColor = BackColor
                    End Try
                End If

                Select Case MouseState
                    Case Variables.MouseState.Enter
                        .FillRectangle(New SolidBrush(BackColor), Base)
                        .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                        .DrawString(Text, Font, New SolidBrush(ForeColor), Base, Variables.CenterStringFormat)
                    Case Variables.MouseState.Down
                        .FillRectangle(New SolidBrush(BackColor), Base)
                        .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), Base)
                        .DrawString(Text, Font, New SolidBrush(ForeColor), Base, Variables.CenterStringFormat)
                    Case Variables.MouseState.Up
                        .FillRectangle(New SolidBrush(BackColor), Base)
                        .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                        .DrawString(Text, Font, New SolidBrush(ForeColor), Base, Variables.CenterStringFormat)
                    Case Variables.MouseState.None
                        .FillRectangle(New SolidBrush(BackColor), Base)
                        .DrawString(Text, Font, New SolidBrush(ForeColor), Base, Variables.CenterStringFormat)
                End Select
            End With

            MyBase.OnPaint(e)
            G.Dispose()
            e.Graphics.InterpolationMode = 7
            e.Graphics.DrawImageUnscaled(B, 0, 0)
            B.Dispose()
        End Sub
    End Class

    Public Class UIClockWidget : Inherits Control
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Private WithEvents DateString As New Label
        Private WithEvents TimeString As New Label
        Private WithEvents TimeTick As New Timer

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Empty
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .MaximumSize = New Size(480, 75)
                .MinimumSize = New Size(480, 75)
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .Size = New Size(480, 90)
            End With

            With DateString '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .AutoSize = True
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .Dock = DockStyle.Top
                .Font = New Font("Segoe UI", 22, FontStyle.Regular)
                .ForeColor = Variables.SystemForeColor
                .TextAlign = ContentAlignment.TopLeft
                .UseCompatibleTextRendering = False
            End With

            With TimeString '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .AutoSize = True
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .Dock = DockStyle.Bottom
                .Font = New Font("Segoe UI", 18, FontStyle.Regular)
                .ForeColor = Variables.SystemForeColor
                .TextAlign = ContentAlignment.TopLeft
                .UseCompatibleTextRendering = False
            End With

            With TimeTick '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .Enabled = False
                .Interval = 100
                .Tag = vbNullString
            End With
        End Sub

        Protected Overrides Sub OnCreateControl()
            BackColor = Color.Transparent
            Controls.Add(DateString)
            DateString.Text = Today.Date.ToLongDateString
            Controls.Add(TimeString)
            TimeString.Text = "0000:00"

            If DesignMode = True Then
                Exit Sub
            Else
                TimeTick.Start()
            End If
        End Sub

        Private Sub TimeTick_Tick(sender As Object, e As EventArgs) Handles TimeTick.Tick
            TimeString.Text = TimeOfDay
        End Sub

        Private Sub UIObject_ClockWidget_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
            DateString.ForeColor = ForeColor
            TimeString.ForeColor = ForeColor
        End Sub
    End Class

    Public Class UIConsole : Inherits Panel
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Public WithEvents Console As New TextBox
        Public WithEvents ConsoleInput As New TextBox

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
            End With

            With Console '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.FromArgb(45, 45, 45)
                .BorderStyle = BorderStyle.None
                .Dock = DockStyle.Fill
                .Font = New Font("Lucida Console", 9.75, FontStyle.Regular)
                .ForeColor = Color.FromArgb(255, 255, 255)
                .Multiline = True
                .ReadOnly = True
                .ScrollBars = ScrollBars.None
                .ShortcutsEnabled = False
                .Text = vbNullString
                .TextAlign = HorizontalAlignment.Left
                .WordWrap = True
            End With

            With ConsoleInput '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.FromArgb(45, 45, 45)
                .BorderStyle = BorderStyle.None
                .Cursor = Cursors.IBeam
                .Dock = DockStyle.Bottom
                .Font = New Font("Lucida Console", 9.75, FontStyle.Regular)
                .ForeColor = Color.FromArgb(255, 255, 255)
                .Multiline = False
                .ReadOnly = False
                .ScrollBars = ScrollBars.None
                .ShortcutsEnabled = False
                .Text = vbNullString
                .TextAlign = HorizontalAlignment.Left
            End With
        End Sub

        Protected Overrides Sub OnCreateControl()
            Controls.Add(Console)
            Controls.Add(ConsoleInput)
            Console.AppendText(Environment.NewLine & "> DAX OSI Console {BUILD: " & BuildID & "}")
            Console.AppendText(Environment.NewLine & "> Type: help for a list of commands.")
        End Sub

        Private Sub UITXTB_Console_Click(sender As Object, e As EventArgs) Handles Console.Click
            ConsoleInput.Focus()
        End Sub

        Private Sub UITXTB_ConsoleInput_KeyDown(sender As Object, e As KeyEventArgs) Handles ConsoleInput.KeyDown
            If e.KeyData = Keys.Enter Then
                If ConsoleInput.Text = "help" Then
                    Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                    Console.AppendText(Environment.NewLine & "> Help has been initiated")
                    Console.AppendText(Environment.NewLine & "> -----help - Shows a list of commands for the DAX OSI console.")
                    Console.AppendText(Environment.NewLine & "> -----signout - Signs out of the current user logged in.")
                    Console.AppendText(Environment.NewLine & "> -----shutdown - Shuts down DAX OSI.")
                    Console.AppendText(Environment.NewLine & "> -----profile.nanager - Opens the profile manager.")
                    Console.AppendText(Environment.NewLine & "> -----profile.nanager - Opens the profile manager.")
                    Console.AppendText(Environment.NewLine & "> -----list.profiles - Shows all profiles for DAX OSI.")
                    Console.AppendText(Environment.NewLine & "> -----clear - Clears the console")
                    Console.AppendText(Environment.NewLine & "")
                ElseIf ConsoleInput.Text = "signout" Then
                    If BOOT_MENU.Visible = True Then
                        Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                        Console.AppendText(Environment.NewLine & "> Cannot sign out of a profile if your not currently signed in.")
                        Console.AppendText(Environment.NewLine & "")
                    Else
                        Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                        Console.AppendText(Environment.NewLine & "> signing out.")
                        Console.AppendText(Environment.NewLine & "")
                        EventsCall.Events(1)
                    End If
                ElseIf ConsoleInput.Text = "shutdown" Then
                    Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                    Console.AppendText(Environment.NewLine & "> Shutting down.")
                    Console.AppendText(Environment.NewLine & "")
                    EventsCall.Events(2)
                ElseIf ConsoleInput.Text = "profile.manager" Then
                    If BOOT_MENU.Visible = True Then
                        Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                        Console.AppendText(Environment.NewLine & "> Cannot access the profile manager from the BOOT_MENU.")
                        Console.AppendText(Environment.NewLine & "")
                    Else
                        Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                        Console.AppendText(Environment.NewLine & "> Opening the profile manager.")
                        Console.AppendText(Environment.NewLine & "")
                        PROFILE_MANAGER.Show()
                    End If
                ElseIf ConsoleInput.Text = "list.profiles" Then
                    Try
                        Dim ProfileDirectory As New IO.DirectoryInfo(Variables.UserProfilesDirectory)
                        Dim ArryFi As IO.DirectoryInfo() = ProfileDirectory.GetDirectories
                        Dim ProfileName As IO.DirectoryInfo
                        Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                        Console.AppendText(Environment.NewLine & "> EXISTING DAX OSI PROFILES: " & ProfileDirectory.GetDirectories().Count)
                        For Each ProfileName In ArryFi
                            Console.AppendText(Environment.NewLine & "> " & ProfileName.Name)
                        Next
                    Catch ex As Exception
                        Console.AppendText(Environment.NewLine & "> Cannot access user profile directory at this time.")
                    End Try
                ElseIf ConsoleInput.Text = "clear" Then
                    Console.AppendText(Environment.NewLine & "> " & ConsoleInput.Text)
                    Console.Clear()
                    Console.AppendText(Environment.NewLine & "> DAX OSI Console {BUILD: " & BuildID & "}")
                    Console.AppendText(Environment.NewLine & "> Type: help for a list of commands.")
                Else
                    Console.AppendText(Environment.NewLine & ">" & "'" & ConsoleInput.Text & "'")
                    Console.AppendText(Environment.NewLine & ":> is not recognized as an internal or external command. Update command listing?")
                    Console.AppendText(Environment.NewLine & "")
                End If
                ConsoleInput.Clear()
                ConsoleInput.Focus()
                e.SuppressKeyPress = True
            End If
        End Sub
    End Class

    Public Class UILabel : Inherits Label
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .AutoSize = False
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .TextAlign = ContentAlignment.TopLeft
                .UseCompatibleTextRendering = False
            End With
        End Sub
    End Class

    Public Class UILinkLabel : Inherits Label
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Private B As Bitmap, G As Graphics
        Private TempForeColor As Color
        Private RenderHighlightColor As Color
        Private RenderUserProfileColorTheme As Boolean = True

        Public Property HighlightColor() As Color
            Get
                Return RenderHighlightColor
            End Get
            Set(value As Color)
                RenderHighlightColor = value
            End Set
        End Property

        Public Property InheritUserProfileColorTheme() As Boolean
            Get
                Return RenderUserProfileColorTheme
            End Get
            Set(value As Boolean)
                RenderUserProfileColorTheme = value
            End Set
        End Property

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .AutoSize = False
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .TextAlign = ContentAlignment.TopLeft
                .UseCompatibleTextRendering = False
            End With
        End Sub

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            TempForeColor = ForeColor
            ForeColor = HighlightColor
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            ForeColor = TempForeColor
            TempForeColor = Nothing
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

            Dim Base As New Rectangle(0, 0, Width, Height)

            With G
                .PixelOffsetMode = 2
                .SmoothingMode = 2
                .TextRenderingHint = 5

                If DesignMode = True Then
                    Try 'Design time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(2)
                        If InheritUserProfileColorTheme = False Then
                            HighlightColor = HighlightColor
                        Else
                            HighlightColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        HighlightColor = HighlightColor
                    End Try
                Else
                    Try 'Run time attempt at loading the user's profile color theme.
                        UserProfile.LoadUserProfileSettings(1)
                        If InheritUserProfileColorTheme = False Then
                            HighlightColor = HighlightColor
                        Else
                            HighlightColor = Color.FromArgb(UserProfile.Settings.R_Value, UserProfile.Settings.G_Value, UserProfile.Settings.B_Value)
                        End If
                    Catch ex As Exception
                        HighlightColor = HighlightColor
                    End Try
                End If
            End With

            MyBase.OnPaint(e)
            G.Dispose()
            e.Graphics.InterpolationMode = 7
            e.Graphics.DrawImageUnscaled(B, 0, 0)
            B.Dispose()
        End Sub
    End Class

    Public Class UIPanel : Inherits Panel
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Variables.SystemBackColor
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
            End With
        End Sub
    End Class

    Public Class UIPictureBox : Inherits PictureBox
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Transparent
                .BackgroundImage = Nothing
                .BackgroundImageLayout = ImageLayout.None
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .Image = Nothing
                .ImageLocation = vbNullString
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .SizeMode = PictureBoxSizeMode.Normal
            End With
        End Sub
    End Class

    Public Class UITextBox : Inherits TextBox
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.FromArgb(45, 45, 45)
                .BorderStyle = BorderStyle.FixedSingle
                .Cursor = Cursors.IBeam
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
            End With
        End Sub
    End Class

    Public Class UITimer : Inherits Timer
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .Enabled = False
                .Interval = 100
                .Tag = vbNullString
            End With
        End Sub
    End Class

    Public Class UIUserProfileImage : Inherits PictureBox
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion

        Public Sub New()
            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Transparent
                .BackgroundImage = Nothing
                .BackgroundImageLayout = ImageLayout.None
                .BorderStyle = BorderStyle.None
                .DoubleBuffered = True
                .Image = Nothing
                .ImageLocation = vbNullString
                .MaximumSize = New Size(68, 64)
                .MinimumSize = New Size(68, 64)
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .Size = New Size(68, 64)
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
        End Sub

        Protected Overrides Sub OnCreateControl()
            If DesignMode = True Then
                Try 'Design time attempt at loading the user's profile color theme.
                    UserProfile.LoadUserProfileSettings(2)
                    Image = Image.FromFile(UserProfile.Settings.UserProfileImage)
                Catch ex As Exception
                    Image = Nothing
                End Try
            Else
                Try 'Run time attempt at loading the user's profile color theme.
                    UserProfile.LoadUserProfileSettings(1)
                    Image = Image.FromFile(UserProfile.Settings.UserProfileImage)
                Catch ex As Exception
                    Image = Nothing
                End Try
            End If
        End Sub
    End Class

    Public Class Window : Inherits Form
        Public BuildID As String = UIFramework.UIBuildFrameworkVersion
        Private B As Bitmap, G As Graphics
        Private WithEvents UIHeaderBar As New Panel
        Private ReadOnly UIIcon As New PictureBox
        Private ReadOnly UICaption As New Label
        Private ReadOnly UIControlBox As New Panel
        Private WithEvents MaximizeUIButton As New UIObject_MaximizeUIButton
        Private WithEvents CloseUIButton As New UIObject_CloseUIButton
        Private Drag As Boolean
        Private MouseX, MouseY As Integer

        Private Class UIObject_MaximizeUIButton : Inherits Control
            Private B As Bitmap, G As Graphics
            Private MouseState As Variables.MouseState = Variables.MouseState.None

            Public Sub New()
                With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                    .BackColor = Color.FromArgb(45, 50, 50)
                    .Dock = DockStyle.Left
                    .Font = New Font("Marlett", 9.75, FontStyle.Regular)
                    .ForeColor = Color.FromArgb(255, 255, 255)
                    .MaximumSize = New Size(16, 16)
                    .MinimumSize = New Size(16, 16)
                    .Size = New Size(16, 16)
                End With
            End Sub

            Protected Overrides Sub OnClick(e As EventArgs)
                MyBase.OnClick(e)
                Select Case FindForm.WindowState
                    Case FormWindowState.Maximized
                        FindForm.WindowState = FormWindowState.Normal
                    Case FormWindowState.Normal
                        FindForm.WindowState = FormWindowState.Maximized
                End Select
            End Sub

            Protected Overrides Sub OnMouseEnter(e As EventArgs)
                MyBase.OnMouseEnter(e)
                MouseState = Variables.MouseState.Enter : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
                MyBase.OnMouseDown(e)
                MouseState = Variables.MouseState.Down : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
                MyBase.OnMouseUp(e)
                MouseState = Variables.MouseState.Up : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseLeave(e As EventArgs)
                MyBase.OnMouseLeave(e)
                MouseState = Variables.MouseState.None : Invalidate()
            End Sub

            Protected Overrides Sub OnPaint(e As PaintEventArgs)
                B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

                Dim Base As New Rectangle(0, 0, Width, Height)

                With G
                    .PixelOffsetMode = 2
                    .SmoothingMode = 2
                    .TextRenderingHint = 5

                    Select Case MouseState
                        Case Variables.MouseState.Enter
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                            If FindForm.WindowState = FormWindowState.Maximized Then
                                .DrawString("2", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            ElseIf FindForm.WindowState = FormWindowState.Normal Then
                                .DrawString("1", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            End If
                        Case Variables.MouseState.Down
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), Base)
                            If FindForm.WindowState = FormWindowState.Maximized Then
                                .DrawString("2", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            ElseIf FindForm.WindowState = FormWindowState.Normal Then
                                .DrawString("1", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            End If
                        Case Variables.MouseState.Up
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                            If FindForm.WindowState = FormWindowState.Maximized Then
                                .DrawString("2", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            ElseIf FindForm.WindowState = FormWindowState.Normal Then
                                .DrawString("1", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            End If
                        Case Variables.MouseState.None
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            If FindForm.WindowState = FormWindowState.Maximized Then
                                .DrawString("2", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            ElseIf FindForm.WindowState = FormWindowState.Normal Then
                                .DrawString("1", Font, New SolidBrush(ForeColor), New Rectangle(1, 1, Width, Height), Variables.CenterStringFormat)
                            End If
                    End Select
                End With

                MyBase.OnPaint(e)
                G.Dispose()
                e.Graphics.InterpolationMode = 7
                e.Graphics.DrawImageUnscaled(B, 0, 0)
                B.Dispose()
            End Sub
        End Class

        Private Class UIObject_CloseUIButton : Inherits Control
            Private B As Bitmap, G As Graphics
            Private MouseState As Variables.MouseState = Variables.MouseState.None

            Public Sub New()
                With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                    .BackColor = Color.FromArgb(168, 35, 35)
                    .Dock = DockStyle.Right
                    .Font = New Font("Marlett", 9.75, FontStyle.Regular)
                    .ForeColor = Color.FromArgb(255, 255, 255)
                    .MaximumSize = New Size(16, 16)
                    .MinimumSize = New Size(16, 16)
                    .Size = New Size(16, 16)
                End With
            End Sub

            Protected Overrides Sub OnMouseEnter(e As EventArgs)
                MyBase.OnMouseEnter(e)
                MouseState = Variables.MouseState.Enter : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
                MyBase.OnMouseDown(e)
                MouseState = Variables.MouseState.Down : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
                MyBase.OnMouseUp(e)
                MouseState = Variables.MouseState.Up : Invalidate()
            End Sub

            Protected Overrides Sub OnMouseLeave(e As EventArgs)
                MyBase.OnMouseLeave(e)
                MouseState = Variables.MouseState.None : Invalidate()
            End Sub

            Protected Overrides Sub OnClick(e As EventArgs)
                MyBase.OnClick(e)

                Dim FadeOut As Integer
                For FadeOut = 100 To 0 Step -10
                    Parent.FindForm.Opacity = FadeOut / 100
                    Refresh()
                    OSICall.PauseThread(5)
                Next
                Parent.FindForm.Dispose()
            End Sub

            Protected Overrides Sub OnPaint(e As PaintEventArgs)
                B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

                Dim Base As New Rectangle(0, 0, Width, Height)

                With G
                    .PixelOffsetMode = 2
                    .SmoothingMode = 2
                    .TextRenderingHint = 5

                    Select Case MouseState
                        Case Variables.MouseState.Enter
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                            .DrawString("r", Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width, Height), Variables.CenterStringFormat)
                        Case Variables.MouseState.Down
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), Base)
                            .DrawString("r", Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width, Height), Variables.CenterStringFormat)
                        Case Variables.MouseState.Up
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), Base)
                            .DrawString("r", Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width, Height), Variables.CenterStringFormat)
                        Case Variables.MouseState.None
                            .FillRectangle(New SolidBrush(BackColor), Base)
                            .DrawString("r", Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width, Height), Variables.CenterStringFormat)
                    End Select
                End With

                MyBase.OnPaint(e)
                G.Dispose()
                e.Graphics.InterpolationMode = 7
                e.Graphics.DrawImageUnscaled(B, 0, 0)
                B.Dispose()
            End Sub
        End Class

        Public Overloads Property ControlBox() As Boolean
            Get
                Return UIControlBox.Visible
                Return FindForm.ControlBox
            End Get
            Set(value As Boolean)
                UIControlBox.Visible = value : FindForm.ControlBox = value
            End Set
        End Property

        <Browsable(False),
         EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overloads Property FormBorderStyle() As FormBorderStyle
            Get
                Return FindForm.FormBorderStyle
            End Get
            Set(value As FormBorderStyle)
                FindForm.FormBorderStyle = value
            End Set
        End Property

        Public Overloads Property Icon() As Icon
            Get
                Return FindForm.Icon : UIIcon.Image = Bitmap.FromHicon(New Icon(Icon, New Size(16, 16)).Handle)
            End Get
            Set(value As Icon)
                FindForm.Icon = value : UIIcon.Image = Bitmap.FromHicon(New Icon(Icon, New Size(16, 16)).Handle)
            End Set
        End Property

        Public Overloads Property MaximizeBox() As Boolean
            Get
                Return MaximizeUIButton.Visible
                Return FindForm.MaximizeBox
            End Get
            Set(value As Boolean)
                MaximizeUIButton.Visible = value : FindForm.MaximizeBox = value
            End Set
        End Property

        <Browsable(False),
        EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        <TypeConverterAttribute(GetType(OpacityConverter))>
        Public Overloads Property Opacity() As Double
            Get
                Return FindForm.Opacity
            End Get
            Set(value As Double)
                FindForm.Opacity = value
            End Set
        End Property

        Public Overloads Property ShowIcon() As Boolean
            Get
                Return UIIcon.Visible
            End Get
            Set(value As Boolean)
                UIIcon.Visible = value

                If UIIcon.Visible = True Then
                    UICaption.Location = New Point(17, 1)
                Else
                    UICaption.Location = New Point(2, 1)
                End If
            End Set
        End Property

        Public Sub New()
            With UIHeaderBar '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.FromArgb(60, 60, 60)
                .BorderStyle = BorderStyle.None
                .Size = New Size(0, 20)
            End With

            With UIIcon '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .Image = Bitmap.FromHicon(New Icon(Icon, New Size(16, 16)).Handle)
                .Location = New Point(2, 2)
                .MaximumSize = New Size(16, 16)
                .MinimumSize = New Size(16, 16)
                .Size = New Size(16, 16)
                .SizeMode = PictureBoxSizeMode.AutoSize
            End With

            With UICaption '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .AutoSize = True
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .Font = Variables.SystemFont
                .ForeColor = Color.FromArgb(255, 255, 255)
                .Location = New Point(17, 1)
                .Padding = New Padding(0, 2, 0, 0)
                .TextAlign = ContentAlignment.TopLeft
                .UseCompatibleTextRendering = False
            End With

            With UIControlBox '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.Transparent
                .BorderStyle = BorderStyle.None
                .Dock = DockStyle.Right
                .Padding = New Padding(2, 2, 2, 2)
                .Size = New Size(38, 20)
            End With

            With Me '***These are default properties!*** Further property changes must be made in the VS editor or programmatically here in designer code.
                .BackColor = Color.FromArgb(0, 0, 0)
                .ControlBox = True
                .DoubleBuffered = True
                .Font = Variables.SystemFont
                .ForeColor = Variables.SystemForeColor
                .FormBorderStyle = FormBorderStyle.None
                .Icon = Icon
                .MaximizeBox = True
                .MinimizeBox = False
                .MinimumSize = New Size(240, 90)
                .Opacity = 0
                .Padding = New Padding(2, 24, 2, 2)
                .SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
                .UpdateStyles()
                .ShowIcon = True
                .ShowInTaskbar = False
                .StartPosition = FormStartPosition.CenterScreen
                .TopMost = True
            End With
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Focus()
            BringToFront()
            Opacity = 1

            If DesignMode = True Then
                Cursor = Cursors.Default
            Else
                Try
                    Variables.OSICursor.[GetType]().InvokeMember("handle", BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetField, Nothing, Variables.OSICursor, New Object() {Variables.HandleCursor})
                    Cursor = Variables.OSICursor
                Catch ex As Exception
                    Cursor = Cursors.Default
                End Try
            End If

            Controls.Add(UIHeaderBar)
            UIHeaderBar.Controls.Add(UIIcon)
            UIHeaderBar.Controls.Add(UICaption)
            UIHeaderBar.Controls.Add(UIControlBox)
            UIControlBox.Controls.Add(MaximizeUIButton)
            UIControlBox.Controls.Add(CloseUIButton)

            If Name = "BROWSER" Then
                Exit Sub
            Else
                Dim FadeIn As Integer
                For FadeIn = 0 To 90 Step +10
                    Opacity = FadeIn / 100
                    Refresh()
                    OSICall.PauseThread(1)
                Next
            End If
        End Sub

        Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
            Dim FadeOut As Integer
            For FadeOut = 100 To 0 Step -10
                Opacity = FadeOut / 100
                Refresh()
                OSICall.PauseThread(1)
            Next
            MyBase.OnFormClosing(e)
        End Sub

        Protected Overrides Sub OnTextChanged(e As EventArgs)
            MyBase.OnTextChanged(e)
            UICaption.Text = Text
        End Sub

        Private Sub UIHeaderBar_DoubleClick(sender As Object, e As EventArgs) Handles UIHeaderBar.DoubleClick
            If MaximizeBox = False Then
                Exit Sub
            Else
                Select Case FindForm.WindowState
                    Case FormWindowState.Maximized
                        FindForm.WindowState = FormWindowState.Normal
                    Case FormWindowState.Normal
                        FindForm.WindowState = FormWindowState.Maximized
                End Select
            End If
        End Sub

        Private Sub UIHeaderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles UIHeaderBar.MouseDown
            Drag = True
            MouseX = Cursor.Position.X - FindForm.Left
            MouseY = Cursor.Position.Y - FindForm.Top
        End Sub

        Private Sub UIHeaderBar_MouseMove(sender As Object, e As MouseEventArgs) Handles UIHeaderBar.MouseMove
            If Drag Then
                FindForm.Top = Cursor.Position.Y - MouseY
                FindForm.Left = Cursor.Position.X - MouseX
            End If
        End Sub

        Private Sub UIHeaderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles UIHeaderBar.MouseUp
            Drag = False
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)

            With UIHeaderBar
                .Location = New Point(2, 2)
                .Size = New Size(Width - 4, 20)
            End With
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            UIHeaderBar.BringToFront()

            B = New Bitmap(Width, Height) : G = Graphics.FromImage(B)

            Dim Base As New Rectangle(0, 0, Width, Height)

            With G
                .PixelOffsetMode = 2
                .SmoothingMode = 2
                .TextRenderingHint = 5
                .FillRectangle(New SolidBrush(Color.FromArgb(50, Color.White)), Base)
            End With

            MyBase.OnPaint(e)
            G.Dispose()
            e.Graphics.InterpolationMode = 7
            e.Graphics.DrawImageUnscaled(B, 0, 0)
            B.Dispose()
        End Sub
    End Class
End Namespace