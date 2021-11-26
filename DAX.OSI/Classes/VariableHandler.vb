Imports System.Runtime.InteropServices

Namespace VariableHandler
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''Variables used for definitions/attributes of the OSI'''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Class Variables
        <DllImport("user32.dll")>
        Public Shared Function LoadCursorFromFile(filename As String) As IntPtr
        End Function

        Public Shared OSIRunning As Boolean = False
        Public Shared OSIStartingUp As Boolean = False
        Public Shared OSISigningOut As Boolean = False
        Public Shared OSIShuttingDown As Boolean = False
        Public Shared OSIApplyingChanges As Boolean = False
        Public Shared ReadOnly SystemDirectory As String = Application.StartupPath & "\OSISystem\"
        Public Shared ReadOnly UserProfilesDirectory As String = SystemDirectory & "Profiles\"
        Public Shared ReadOnly SystemFont As New Font("Segoe UI", 8.25, FontStyle.Regular)
        Public Shared ReadOnly SystemForeColor As Color = Color.FromArgb(255, 255, 255)
        Public Shared ReadOnly SystemBackColor As Color = Color.FromArgb(70, 130, 160)
        Public Shared ReadOnly CenterStringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        Public Shared ReadOnly CenterLowerStringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Far}
        Public Shared ReadOnly NearStringFormat As New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near}
        Public Shared OSICursor As New Cursor(Cursor.Current.Handle)
        Public Shared HandleCursor As IntPtr = LoadCursorFromFile(Application.StartupPath & "\OSICursor.cur")

        Public Enum MouseState As Byte 'Programmatically defined MouseStates based on Event_MouseState for controls I.E Buttons.
            None = 0
            Enter = 1
            Down = 2
            Up = 3
        End Enum
    End Class
End Namespace