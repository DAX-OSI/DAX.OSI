Imports DAX.OSI.OperationHandler
Imports DAX.OSI.EventHandler
Imports DAX.OSI.VariableHandler
Imports DAX.OSI.StructureHandler
Public Class BOOT_MENU
    Private Sub BtnRunDAXOSI_Click(sender As Object, e As EventArgs) Handles BtnRunDAXOSI.Click
        If Not OSICall.CheckDirectory(Variables.SystemDirectory) Then
            OSICall.CreateDirectory(Variables.SystemDirectory)
        End If

        If Not OSICall.CheckDirectory(Variables.UserProfilesDirectory) Then
            OSICall.CreateDirectory(Variables.UserProfilesDirectory)
        End If

        If Not OSICall.FileExists(Variables.SystemDirectory & "Settings.osis") Then
            OSISettings.SetDefaultOSISettings()
        Else
            OSISettings.LoadOSISettings()
        End If

        If OSISettings.Settings.Setup = True Then
            PnlSetupWindow1.Visible = True
            PnlMainWindow.Visible = False
        Else
            UserProfile.LoadUserProfileSettings(1)
            EventsCall.Events(0)
        End If
    End Sub

    Private Sub BtnOpenConsoleWindow_Click(sender As Object, e As EventArgs) Handles BtnOpenConsoleWindow.Click
        If Not PnlConsoleWindow.Visible Then
            PnlConsoleWindow.Visible = True
            Console.ConsoleInput.Focus()
            BtnOpenConsoleWindow.Text = "CLOSE: CONSOLE"
        Else
            PnlConsoleWindow.Visible = False
            BtnOpenConsoleWindow.Text = "OPEN: CONSOLE"
        End If
    End Sub

    Private Sub BtnSetup1Next_Click(sender As Object, e As EventArgs) Handles BtnSetup1Next.Click
        LblSetupWindow2Caption.Text = "PROFILE NAME: " & UserProfile.UserName
        PnlSetupWindow2.Visible = True
        txtbSetUserProfilePassword.Focus()
        PnlSetupWindow1.Visible = False
    End Sub

    Private Sub BtnSetup2Next_Click(sender As Object, e As EventArgs) Handles BtnSetup2Next.Click
        Dim SystemResource As Image = My.Resources.default_profile_image

        If Not OSICall.CheckDirectory(UserProfile.ProfileDirectory) Then
            OSICall.CreateDirectory(UserProfile.ProfileDirectory)
            If Not OSICall.FileExists(Variables.SystemDirectory & "default_profile_image.png") Then
                SystemResource.Save(UserProfile.ProfileDirectory & "default_profile_image.png", Imaging.ImageFormat.Png)
            End If
        End If

        If Not OSICall.FileExists(UserProfile.ProfileDirectory & UserProfile.UserName & ".up") Then
            UserProfile.SetDefaultProfileSettings()
        End If

        If Not txtbSetUserProfilePassword.Text = vbNullString Then
            UserProfile.Settings.UserProfilePassword = txtbSetUserProfilePassword.Text
            UserProfile.SaveUserProfileSettings(1)
        End If

        UserProfile.Settings.UserProfileImage = UserProfile.ProfileDirectory & "default_profile_image.png"
        UserProfile.SaveUserProfileSettings(1)
        UserProfile.LoadUserProfileSettings(1)
        OSISettings.Settings.Setup = False
        OSISettings.SaveOSISettings()
        PnlSetupWindow3.Visible = True
        PnlSetupWindow2.Visible = False
    End Sub

    Private Sub BtnSetup3Next_Click(sender As Object, e As EventArgs) Handles BtnSetup3Next.Click
        EventsCall.Events(0)
    End Sub
End Class