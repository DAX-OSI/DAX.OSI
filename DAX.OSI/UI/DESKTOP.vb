Imports DAX.OSI.EventHandler
Imports DAX.OSI.OperationHandler

Public Class DESKTOP
    Public WithEvents BufferDesktop As New UI.UITimer
    Public WithEvents CleanupSignIn As New UI.UITimer

    Private Sub DESKTOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0

        With BufferDesktop
            .Enabled = False
            .Interval = 30
            .Tag = vbNullString
        End With

        With CleanupSignIn
            .Enabled = False
            .Interval = 3000
            .Tag = vbNullString
        End With

        BufferDesktop.Start()
        CleanupSignIn.Start()
    End Sub

    Private Sub BufferDesktop_Tick(sender As Object, e As EventArgs) Handles BufferDesktop.Tick
        If Opacity = 1.0 Then
            CleanupSignIn.Start()
            BufferDesktop.Stop()
            BufferDesktop.Dispose()
        Else
            Opacity += 0.1
        End If
    End Sub

    Private Sub CleanupSignIn_Tick(sender As Object, e As EventArgs) Handles CleanupSignIn.Tick
        SIGN_IN.Close()
        CleanupSignIn.Stop()
        CleanupSignIn.Dispose()
    End Sub

    Private Sub LlOpenApplicationsMenu_Click(sender As Object, e As EventArgs) Handles LlOpenApplicationsMenu.Click
        If Not PnlApplicationsWindow.Visible Then
            PnlApplicationsWindow.Visible = True
            PnlApplicationsWindow.Focus()
        Else
            PnlApplicationsWindow.Visible = False
        End If
    End Sub

    Private Sub PnlApplicationsWindow_LostFocus(sender As Object, e As EventArgs) Handles PnlApplicationsWindow.LostFocus
        PnlApplicationsWindow.Visible = False
    End Sub

    Private Sub LlShutdown_Click(sender As Object, e As EventArgs) Handles LlShutdown.Click
        EventsCall.Events(2)
    End Sub

    Private Sub LlSignout_Click(sender As Object, e As EventArgs) Handles LlSignout.Click
        EventsCall.Events(1)
    End Sub

    Private Sub LlOpenConsoleApplication_Click(sender As Object, e As EventArgs) Handles LlOpenConsoleApplication.Click
        Dim NewConsoleWindow As New CONSOLE
        NewConsoleWindow.Show()
        NewConsoleWindow.ConsoleWidget.ConsoleInput.Focus()
    End Sub

    Private Sub LlOpenProfileManagerApplication_Click(sender As Object, e As EventArgs) Handles LlOpenProfileManagerApplication.Click
        PROFILE_MANAGER.Show()
        OSICall.MessageUI("Notice", "All features are not active yet. Development is still underway.", 1)
    End Sub

    Private Sub DESKTOP_Click(sender As Object, e As EventArgs) Handles Me.Click
        If PnlApplicationsWindow.Visible = True Then
            PnlApplicationsWindow.Visible = False
        End If
    End Sub
End Class