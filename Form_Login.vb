Imports System.Data.SqlClient
Public Class Form_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Form_Main.MyConnectionString = "Data Source=159.93.100.205,1433;Initial Catalog=NAA_DB;User ID=" + UsernameTextBox.Text + ";Password=" + PasswordTextBox.Text
            Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            sqlConnection1.Open()
            sqlConnection1.Close()
            Form_Main.Show()
            Me.Close()
        Catch sqlEx As SqlException
            MsgBox("Неправильное имя пользователя или пароль.", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox($"{ex.ToString}", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class

