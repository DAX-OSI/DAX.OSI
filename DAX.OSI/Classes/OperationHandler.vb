Imports System.IO
Imports DAX.OSI.VariableHandler

Namespace OperationHandler
    ''''''''''''''''''''''''''''''''''''''''''''''''''
    '''Startup parameters for the OSI while booting'''
    ''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Class StartupParams
        Public Shared Sub EnableSystemVisuals() 'Allows System.Windows.Forms.dll to take on the visual elements from the system theme.
            Application.EnableVisualStyles()
        End Sub

        Public Shared Sub UseCTR(Value As Boolean) 'Enables/disables compatible text rendering (used for .NET framework 1.0 and 1.1 Older.)
            Application.SetCompatibleTextRenderingDefault(Value)
        End Sub
    End Class

    '''''''''''''''''''''''''''''''''''''''''''''''
    '''Calls a major Function/action For the OSI'''
    '''''''''''''''''''''''''''''''''''''''''''''''
    Public Class OSICall
        Public Shared Function CheckDirectory(DirectoryPath As String) As Boolean 'Check's if the directory exists with the given path.
            Return Directory.Exists(DirectoryPath)
        End Function

        Public Shared Function CreateDirectory(DirectoryPath As String) 'Creates the directory with the given path directive.
            Return Directory.CreateDirectory(DirectoryPath)
        End Function

        Public Shared Function GetCurrentDirectory() 'Gets the current directory path.
            Return Directory.GetCurrentDirectory
        End Function

        Public Shared Function FileExists(FilePath As String) As Boolean 'Check's if a file exists.
            Return File.Exists(FilePath)
        End Function

        Public Shared Sub PauseThread(Miliseconds As Integer) 'Suspends the current thread for the specified amount of time.
            Threading.Thread.Sleep(Miliseconds)
        End Sub

        Public Shared Sub Process() 'Handles the calling of other events in queue.
            Application.DoEvents()
        End Sub

        Public Shared Sub Terminate() 'Completley exits the entire OSI.
            Application.Exit()
            End
        End Sub

        Public Shared Sub MessageUI(Title As String, Message As String, AlertType As Integer)
            Dim NewMessageUI As New MESSAGE_UI
            NewMessageUI.Text = Title
            NewMessageUI.LblMessage.Text = Message
            If AlertType = 1 Then 'Warning
                NewMessageUI.PbIcon.Image = My.Resources.alert_icon
            End If
            NewMessageUI.Show()
        End Sub

        Public Shared Sub ProcessingLoop() 'The main loop of the whole OSI.
            Do While Variables.OSIRunning = True
                Process()
                PauseThread(5)
            Loop

            Terminate()
        End Sub
    End Class
End Namespace