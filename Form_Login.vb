Public Class Form_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim samplePrincipal As New SampleIPrincipal(
    Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)

        Form_Main.MyConnectionString = "Data Source=159.93.100.205,1433;Initial Catalog=NAA_DB;User ID=" + UsernameTextBox.Text + ";Password=" + PasswordTextBox.Text

        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            MsgBox("The username and password pair is incorrect")
        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal

            Form_Main.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



End Class

