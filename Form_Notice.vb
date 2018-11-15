Imports System.Data.SqlClient

Public Class Form_Notice
    Public Sub Form_Notice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = $"Примечания к партии {Form_Samples_List.L_SS_Country_Code.Text}-{Form_Samples_List.L_SS_Client_ID.Text}-{Form_Samples_List.L_SS_Year.Text}-{Form_Samples_List.L_SS_Sample_Set_ID.Text}-{Form_Samples_List.L_SS_Sample_Set_Index.Text}"

    End Sub

    Private Sub ButtonFormNoticeCancel_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonFormNoticeSave_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeSave.Click
        Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
        Dim cmd As New SqlCommand
        cmd.Connection = sqlConnection1
        sqlConnection1.Open()
        cmd.CommandText = $"update table_Sample_Set set Note='{RichTextBoxFormNotice.Text}'"
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Me.Close()
    End Sub
End Class