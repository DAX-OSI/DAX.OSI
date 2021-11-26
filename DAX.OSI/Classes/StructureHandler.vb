Imports DAX.OSI.OperationHandler
Imports DAX.OSI.VariableHandler

Namespace StructureHandler
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''Utilize's the Windows.Environment.UserName and creates a profile for them to read/write and save/load from in .up format (.user profile)'''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Class UserProfile
        Public Shared ReadOnly UserName As String = Environment.UserName.ToString
        Public Shared ReadOnly ProfileDirectory As String = Variables.UserProfilesDirectory & UserName & "\"
        Public Shared Settings As ProfileSettingsStructure

        Public Structure ProfileSettingsStructure
            Public UserProfilePassword As String
            Public UserProfileImage As String
            Public R_Value As Integer
            Public G_Value As Integer
            Public B_Value As Integer
        End Structure

        Public Shared Sub SetDefaultProfileSettings()
            Settings.UserProfilePassword = vbNullString
            Settings.UserProfileImage = vbNullString
            Settings.R_Value = 70
            Settings.G_Value = 130
            Settings.B_Value = 160
            SaveUserProfileSettings(1)
        End Sub

        Public Shared Sub SaveUserProfileSettings(SaveType As Byte) 'Save type is used for design time and run time to save settings to. 1 = run time, 2 = design time.
            Dim UserProfileSettingsFile As Short
            UserProfileSettingsFile = FreeFile()

            If SaveType = 1 Then
                FileOpen(UserProfileSettingsFile, ProfileDirectory & UserName & ".up", OpenMode.Binary, OpenAccess.Write, OpenShare.Default) '.up (User Profile.)
            ElseIf SaveType = 2 Then
                FileOpen(UserProfileSettingsFile, OSICall.GetCurrentDirectory & "\DAX.OSI\bin\OSISystem\Profiles\" & UserName & "\" & UserName & ".up", OpenMode.Binary, OpenAccess.Write, OpenShare.Default) '.up (User Profile.)
            End If

            FilePutObject(UserProfileSettingsFile, Settings.UserProfilePassword)
            FilePutObject(UserProfileSettingsFile, Settings.UserProfileImage)
            FilePutObject(UserProfileSettingsFile, Settings.R_Value)
            FilePutObject(UserProfileSettingsFile, Settings.G_Value)
            FilePutObject(UserProfileSettingsFile, Settings.B_Value)
            FileClose(UserProfileSettingsFile)
        End Sub

        Public Shared Sub LoadUserProfileSettings(LoadType As Byte) 'Load type is used for design time and run time to load settings from. 1 = run time, 2 = design time.
            Dim UserProfileSettingsFile As Short
            UserProfileSettingsFile = FreeFile()

            If LoadType = 1 Then
                FileOpen(UserProfileSettingsFile, ProfileDirectory & UserName & ".up", OpenMode.Binary, OpenAccess.Read, OpenShare.Default) '.up (User Profile.)
            ElseIf LoadType = 2 Then
                FileOpen(UserProfileSettingsFile, OSICall.GetCurrentDirectory & "\DAX.OSI\bin\OSISystem\Profiles\" & UserName & "\" & UserName & ".up", OpenMode.Binary, OpenAccess.Read, OpenShare.Default) '.up (User Profile.)
            End If

            FileGetObject(UserProfileSettingsFile, Settings.UserProfilePassword)
            FileGetObject(UserProfileSettingsFile, Settings.UserProfileImage)
            FileGetObject(UserProfileSettingsFile, Settings.R_Value)
            FileGetObject(UserProfileSettingsFile, Settings.G_Value)
            FileGetObject(UserProfileSettingsFile, Settings.B_Value)
            FileClose(UserProfileSettingsFile)
        End Sub
    End Class

    Public Class OSISettings
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''Generates 'Settings.osis' (Operating System Interface Settings) to read some hard settings controlled by the OSI separatley from the user profile settings'''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Public Shared Settings As SettingsStructure

        Public Structure SettingsStructure
            Public Setup As Boolean
        End Structure

        Public Shared Sub SetDefaultOSISettings()
            Settings.Setup = True
            SaveOSISettings()
        End Sub

        Public Shared Sub SaveOSISettings()
            Dim OSISettingsFile As Long
            OSISettingsFile = FreeFile()

            FileOpen(OSISettingsFile, Variables.SystemDirectory & "Settings.osis", OpenMode.Binary, OpenAccess.Write, OpenShare.Default) '.osis (Operating System Interface Settings.)

            FilePutObject(OSISettingsFile, Settings.Setup)
            FileClose(OSISettingsFile)
        End Sub

        Public Shared Sub LoadOSISettings()
            Dim OSISettingsFile As Long
            OSISettingsFile = FreeFile()

            FileOpen(OSISettingsFile, Variables.SystemDirectory & "Settings.osis", OpenMode.Binary, OpenAccess.Read, OpenShare.Default) '.osis (Operating System Interface Settings.)

            FileGetObject(OSISettingsFile, Settings.Setup)
            FileClose(OSISettingsFile)
        End Sub
    End Class
End Namespace