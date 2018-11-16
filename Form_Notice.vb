﻿Imports System.Data.SqlClient

Public Class Form_Notice
    Public Sub Form_Notice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = $"Комментарии к партии {Form_Samples_List.L_SS_Country_Code.Text}-{Form_Samples_List.L_SS_Client_ID.Text}-{Form_Samples_List.L_SS_Year.Text}-{Form_Samples_List.L_SS_Sample_Set_ID.Text}-{Form_Samples_List.L_SS_Sample_Set_Index.Text}"

        Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        cmd.Connection = sqlConnection1
        sqlConnection1.Open()
        cmd.CommandText = $"select Loggs from table_Sample_Set where Country_Code='{Form_Samples_List.L_SS_Country_Code.Text}' and Client_ID='{Form_Samples_List.L_SS_Client_ID.Text}' and Year='{Form_Samples_List.L_SS_Year.Text}' and Sample_Set_ID='{Form_Samples_List.L_SS_Sample_Set_ID.Text}' and Sample_Set_Index='{Form_Samples_List.L_SS_Sample_Set_Index.Text}'"
        Debug.WriteLine(cmd.CommandText)
        reader = cmd.ExecuteReader()
        reader.Read()
        Form_Notice_Log.Text = reader(0)
        sqlConnection1.Close()
    End Sub

    Private Sub ButtonFormNoticeCancel_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonFormNoticeSave_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeSave.Click
        Dim sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
        Dim cmd As New SqlCommand
        cmd.Connection = sqlConnection1
        sqlConnection1.Open()
        Dim log As String
        log = Form_Notice_Log.Text
        If log = "" Then
            log = $"@{Form_Main.us}|{Now.ToString("dd/MM/yyyy hh:mm")}: {RichTextBoxFormNotice.Text}"
        Else
            log += $"{vbCrLf}@{Form_Main.us}|{Now.ToString("dd/MM/yyyy hh:mm")}: {RichTextBoxFormNotice.Text}"
        End If
        cmd.CommandText = $"update table_Sample_Set set Loggs='{log}' where Country_Code='{Form_Samples_List.L_SS_Country_Code.Text}' and Client_ID='{Form_Samples_List.L_SS_Client_ID.Text}' and Year='{Form_Samples_List.L_SS_Year.Text}' and Sample_Set_ID='{Form_Samples_List.L_SS_Sample_Set_ID.Text}' and Sample_Set_Index='{Form_Samples_List.L_SS_Sample_Set_Index.Text}'"
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Form_Notice_Log.Text = log
        RichTextBoxFormNotice.Clear()
    End Sub
End Class