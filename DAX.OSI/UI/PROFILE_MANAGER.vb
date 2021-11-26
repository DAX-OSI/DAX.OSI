Imports DAX.OSI.EventHandler
Imports DAX.OSI.StructureHandler

Public Class PROFILE_MANAGER
    Private Sub PROFILE_MANAGER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class