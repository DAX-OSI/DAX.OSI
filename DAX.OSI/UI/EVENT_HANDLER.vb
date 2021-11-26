Imports DAX.OSI.OperationHandler
Imports DAX.OSI.StructureHandler
Imports DAX.OSI.VariableHandler

Public Class EVENT_HANDLER
    Public WithEvents BufferUI As New UI.UITimer
    Public WithEvents DebufferUI As New UI.UITimer
    Public WithEvents BufferEvents As New UI.UITimer

    Private Sub EVENT_HANDLER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0

        With BufferUI
            .Enabled = False
            .Interval = 30
            .Tag = vbNullString
        End With

        With DebufferUI
            .Enabled = False
            .Interval = 30
            .Tag = vbNullString
        End With

        BufferUI.Start()
    End Sub

    Private Sub BufferUI_Tick(sender As Object, e As EventArgs) Handles BufferUI.Tick
        If Opacity = 1.0 Then
            BufferEvents.Start()
            BufferUI.Stop()
            BufferUI.Dispose()
        Else
            Opacity += 0.1
        End If
    End Sub

    Private Sub BufferEvents_Tick(sender As Object, e As EventArgs) Handles BufferEvents.Tick
        OSICall.Process()

        If Variables.OSIStartingUp = True Then
            Variables.OSIStartingUp = False
            BOOT_MENU.Close()
            SIGN_IN.Show()
            DebufferUI.Start()
        ElseIf Variables.OSISigningOut = True Then
            Variables.OSISigningOut = False
            For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
                If Application.OpenForms.Item(i) IsNot Me Then
                    Application.OpenForms.Item(i).Dispose()
                    DESKTOP.Close()
                    SIGN_IN.Show()
                    DebufferUI.Start()
                End If
            Next i
        ElseIf Variables.OSIShuttingDown = True Then
            Variables.OSIShuttingDown = False
            OSICall.Terminate()
        ElseIf Variables.OSIApplyingChanges = True Then
            Variables.OSIApplyingChanges = False
            For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
                Application.OpenForms.Item(i).Refresh()
                UserProfile.LoadUserProfileSettings(1)
                DebufferUI.Start()
            Next i
        End If

        BufferEvents.Stop()
        BufferEvents.Dispose()
    End Sub

    Private Sub DebufferUI_Tick(sender As Object, e As EventArgs) Handles DebufferUI.Tick
        If Opacity = 0 Then
            DebufferUI.Stop()
            DebufferUI.Dispose()
            Close()
        Else
            Opacity -= 0.1
        End If
    End Sub
End Class