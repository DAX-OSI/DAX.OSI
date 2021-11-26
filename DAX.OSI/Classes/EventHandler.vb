Imports DAX.OSI.OperationHandler
Imports DAX.OSI.VariableHandler

Namespace EventHandler
    Public Class Boot
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''EventHandler.Boot.Main is the entry point for the OSI to start from'''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Public Shared Sub Main()
            Variables.OSIRunning = True
            StartupParams.EnableSystemVisuals()
            StartupParams.UseCTR(False)
            BOOT_MENU.Show()
            OSICall.ProcessingLoop()
        End Sub
    End Class

    Public Class EventsCall
        Public Shared Sub Events(State As Integer)
            Select Case State
                Case 0 'Starting up
                    Variables.OSIStartingUp = True
                    With EVENT_HANDLER.BufferEvents
                        .Enabled = False
                        .Interval = 3000
                        .Tag = vbNullString
                    End With
                    EVENT_HANDLER.LblProcessingEvent.Text = "Starting up...Please wait..."
                    EVENT_HANDLER.Show()
                Case 1 'Signing out
                    Variables.OSISigningOut = True
                    For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
                        If Application.OpenForms.Item(i) IsNot EVENT_HANDLER And Application.OpenForms.Item(i) IsNot DESKTOP And Application.OpenForms.Item(i) IsNot BOOT_MENU And Application.OpenForms.Item(i) IsNot SIGN_IN Then
                            Application.OpenForms.Item(i).Close()
                        End If
                    Next i
                    With EVENT_HANDLER.BufferEvents
                        .Enabled = False
                        .Interval = 3000
                        .Tag = vbNullString
                    End With
                    EVENT_HANDLER.LblProcessingEvent.Text = "Signing out...Please wait..."
                    EVENT_HANDLER.Show()
                Case 2 'Shutting down
                    Variables.OSIShuttingDown = True
                    For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
                        If Application.OpenForms.Item(i) IsNot EVENT_HANDLER And Application.OpenForms.Item(i) IsNot DESKTOP And Application.OpenForms.Item(i) IsNot BOOT_MENU And Application.OpenForms.Item(i) IsNot SIGN_IN Then
                            Application.OpenForms.Item(i).Close()
                        End If
                    Next i
                    With EVENT_HANDLER.BufferEvents
                        .Enabled = False
                        .Interval = 3000
                        .Tag = vbNullString
                    End With
                    EVENT_HANDLER.LblProcessingEvent.Text = "Shutting down...Please wait..."
                    EVENT_HANDLER.Show()
                Case 3
                    Variables.OSIApplyingChanges = True
                    With EVENT_HANDLER.BufferEvents
                        .Enabled = False
                        .Interval = 1000
                        .Tag = vbNullString
                    End With
                    EVENT_HANDLER.LblProcessingEvent.Text = "Applying changes...Please wait..."
                    EVENT_HANDLER.Show()
            End Select
        End Sub
    End Class
End Namespace