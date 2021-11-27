Imports DAX.OSI.EventHandler
Imports DAX.OSI.OperationHandler
Imports DAX.OSI.StructureHandler

Public Class PROFILE_MANAGER
    Private Sub PROFILE_MANAGER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserProfile.Settings.UserProfilePassword = vbNullString Then
            BtnOpenManagePasswordWindow.Text = "Set Password"
        Else
            BtnOpenManagePasswordWindow.Text = "Edit Password"
        End If
    End Sub

    Private Sub BtnCT1_Click(sender As Object, e As EventArgs) Handles BtnCT1.Click
        UserProfile.Settings.R_Value = 70
        UserProfile.Settings.G_Value = 130
        UserProfile.Settings.B_Value = 160
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT2_Click(sender As Object, e As EventArgs) Handles BtnCT2.Click
        UserProfile.Settings.R_Value = 46
        UserProfile.Settings.G_Value = 204
        UserProfile.Settings.B_Value = 113
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT3_Click(sender As Object, e As EventArgs) Handles BtnCT3.Click
        UserProfile.Settings.R_Value = 52
        UserProfile.Settings.G_Value = 152
        UserProfile.Settings.B_Value = 219
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT4_Click(sender As Object, e As EventArgs) Handles BtnCT4.Click
        UserProfile.Settings.R_Value = 155
        UserProfile.Settings.G_Value = 89
        UserProfile.Settings.B_Value = 182
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT5_Click(sender As Object, e As EventArgs) Handles BtnCT5.Click
        UserProfile.Settings.R_Value = 52
        UserProfile.Settings.G_Value = 73
        UserProfile.Settings.B_Value = 94
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT6_Click(sender As Object, e As EventArgs) Handles BtnCT6.Click
        UserProfile.Settings.R_Value = 241
        UserProfile.Settings.G_Value = 196
        UserProfile.Settings.B_Value = 15
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT7_Click(sender As Object, e As EventArgs) Handles BtnCT7.Click
        UserProfile.Settings.R_Value = 230
        UserProfile.Settings.G_Value = 126
        UserProfile.Settings.B_Value = 34
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT8_Click(sender As Object, e As EventArgs) Handles BtnCT8.Click
        UserProfile.Settings.R_Value = 231
        UserProfile.Settings.G_Value = 76
        UserProfile.Settings.B_Value = 60
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT9_Click(sender As Object, e As EventArgs) Handles BtnCT9.Click
        UserProfile.Settings.R_Value = 236
        UserProfile.Settings.G_Value = 240
        UserProfile.Settings.B_Value = 241
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnCT10_Click(sender As Object, e As EventArgs) Handles BtnCT10.Click
        UserProfile.Settings.R_Value = 149
        UserProfile.Settings.G_Value = 165
        UserProfile.Settings.B_Value = 166
        UserProfile.SaveUserProfileSettings(1)
        EventsCall.Events(3)
    End Sub

    Private Sub BtnChooseColorThemeWindow_Click(sender As Object, e As EventArgs) Handles BtnOpenChooseColorThemeWindow.Click
        PnlChooseColorThemeWindow.Visible = True
        PnlPasswordManagerWindow.Visible = False
    End Sub

    Private Sub BtnManagePasswordWindow_Click(sender As Object, e As EventArgs) Handles BtnOpenManagePasswordWindow.Click
        If UserProfile.Settings.UserProfilePassword = vbNullString Then
            PnlPasswordManagerWindow.Visible = True
            PnlSetPasswordWindow.Visible = True
        Else
            PnlPasswordManagerWindow.Visible = True
            PnlEditPasswordWindow.Visible = True
        End If
    End Sub

    Private Sub BtnSetPassword_Click(sender As Object, e As EventArgs) Handles BtnSetPassword.Click
        If txtBSetPassword.Text = vbNullString Then
            OSICall.MessageUI("Invalid Input", "Password cannot be left blank. Either set a password or click cancel.", 1)
            Exit Sub
        End If

        If Not txtBSetPasswordRetype.Text = txtBSetPassword.Text Then
            OSICall.MessageUI("Invalid Input", "Password's do not match. Please try again.", 1)
            Exit Sub
        End If

        If TxtbPasswordHint.Text = vbNullString Then
            OSICall.MessageUI("Password Hint", "Password hint cannot be left blank. This is for your own saftey!", 1)
            Exit Sub
        End If

        OSICall.MessageUI("Success!", "Your password has been set, and your profile is now secure!", 0)
        UserProfile.Settings.UserProfilePassword = txtBSetPasswordRetype.Text
        UserProfile.SaveUserProfileSettings(1)
        UserProfile.LoadUserProfileSettings(1)
        PnlSetPasswordWindow.Visible = False
        PnlPasswordManagerWindow.Visible = False
        BtnOpenManagePasswordWindow.Text = "Edit Password"
        Refresh()
    End Sub

    Private Sub BtnSetNewPassword_Click(sender As Object, e As EventArgs) Handles BtnSetNewPassword.Click
        If Not TxtBCurrentPassword.Text = UserProfile.Settings.UserProfilePassword Then
            OSICall.MessageUI("Incorrect User Password", "The password you have entered for this profile is incorrect. Please try again!", 1)
            Exit Sub
        End If

        If Not TxtbNewPassword.Text = TxtbNewPasswordRetype.Text Then
            OSICall.MessageUI("Invalid Input", "Password's do not match. Please try again.", 1)
            Exit Sub
        End If

        If TxtbNewPasswordHint.Text = vbNullString Then
            OSICall.MessageUI("Password Hint", "Password hint cannot be left blank. This is for your own saftey!", 1)
            Exit Sub
        End If

        OSICall.MessageUI("Success!", "Your password has been updated, and your profile is now secure!", 0)
        UserProfile.Settings.UserProfilePassword = TxtbNewPassword.Text
        UserProfile.SaveUserProfileSettings(1)
        UserProfile.LoadUserProfileSettings(1)
        PnlEditPasswordWindow.Visible = False
        PnlPasswordManagerWindow.Visible = False
        BtnOpenManagePasswordWindow.Text = "Edit Password"
        Refresh()
    End Sub

    Private Sub BtnDisablePassword_Click(sender As Object, e As EventArgs) Handles BtnDisablePassword.Click
        If Not TxtBCurrentPassword.Text = UserProfile.Settings.UserProfilePassword Then
            OSICall.MessageUI("Incorrect User Password", "The password you have entered for this profile is incorrect. Please ensure your current password is typed in then try again.", 1)
            Exit Sub
        End If

        UserProfile.Settings.UserProfilePassword = vbNullString
        UserProfile.SaveUserProfileSettings(1)
        UserProfile.LoadUserProfileSettings(1)
        OSICall.MessageUI("Success", "Your password has been disabled, however; your profile is now no longer secured.", 1)
        PnlSetPasswordWindow.Visible = False
        PnlEditPasswordWindow.Visible = False
        PnlPasswordManagerWindow.Visible = False
        BtnOpenManagePasswordWindow.Text = "Set Password"
        Refresh()
    End Sub
End Class