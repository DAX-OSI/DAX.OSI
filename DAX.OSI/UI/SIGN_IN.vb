Imports DAX.OSI.EventHandler
Imports DAX.OSI.OperationHandler
Imports DAX.OSI.StructureHandler

Public Class SIGN_IN
    Private Sub SIGN_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWelcomeUser.Text = "Welcome, " & UserProfile.UserName & "!"
        If UserProfile.Settings.UserProfilePassword = vbNullString Then
            LblWelcomeUser.Location = New Point(79, 21)
            txtbUserProfilePassword.Visible = False
        Else
            LblWelcomeUser.Location = New Point(79, 6)
            txtbUserProfilePassword.Visible = True
        End If
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        If txtbUserProfilePassword.Text = UserProfile.Settings.UserProfilePassword Then
            DESKTOP.Show()
        Else
            OSICall.MessageUI("Incorrect User Password", "The password you have entered for this profile is incorrect. Please try again!", 1)
        End If
    End Sub

    Private Sub LlShutdown_Click(sender As Object, e As EventArgs) Handles LlShutdown.Click
        EventsCall.Events(2)
    End Sub
End Class