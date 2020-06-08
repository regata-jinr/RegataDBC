Imports System.Data.SqlClient

Public Class Form_Notice


    Public Country_Code, Client_ID, Year, Sample_Set_ID, Sample_Set_Index As String

    Public Sub Form_Notice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If Form_Main.DataGridView_Sample_Set.SelectedRows.Count = 0 Then Exit Sub

        Country_Code = Form_Main.DataGridView_Sample_Set.SelectedRows(0).Cells(0).Value
        Client_ID = Form_Main.DataGridView_Sample_Set.SelectedRows(0).Cells(1).Value
        Year = Form_Main.DataGridView_Sample_Set.SelectedRows(0).Cells(2).Value
        Sample_Set_ID = Form_Main.DataGridView_Sample_Set.SelectedRows(0).Cells(3).Value
        Sample_Set_Index = Form_Main.DataGridView_Sample_Set.SelectedRows(0).Cells(4).Value
        Me.Text = $"Комментарии к партии {Country_Code}-{Client_ID}-{Year}-{Sample_Set_ID}-{Sample_Set_Index}"

        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Using cmd As New SqlCommand
                Dim reader As SqlDataReader
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                cmd.CommandText = $"select Loggs, ResCompl, LLICompl,SLICompl, PrepCompl from table_Sample_Set where Country_Code='{Country_Code}' and Client_ID='{Client_ID}' and Year='{Year}' and Sample_Set_ID='{Sample_Set_ID}' and Sample_Set_Index='{Sample_Set_Index}'"
                Debug.WriteLine(cmd.CommandText)
                reader = cmd.ExecuteReader()
                reader.Read()
                Form_Notice_Log.Text = reader(0)
                Dim i As Integer = 1
                For Each chb As CheckBox In GroupBoxComplete.Controls.OfType(Of CheckBox)
                    Debug.WriteLine($"{chb.Text}  {reader(i)}")
                    chb.Checked = reader(i)
                    InitComplMarkers(i - 1) = If(chb.Checked, 1, 0)
                    i += 1
                Next
            End Using
        End Using
    End Sub

    Private InitComplMarkers(3) As Integer

    Private Sub ButtonFormNoticeCancel_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonFormNoticeSave_Click(sender As Object, e As EventArgs) Handles ButtonFormNoticeSave.Click
        Using sqlConnection1 As New SqlConnection(Form_Main.MyConnectionString)
            Using cmd As New SqlCommand
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                Dim log As String
                Dim adds As String = ""
                Dim queryCompleteMarker As String = ""
                Dim i As Integer = 0
                Dim compl(3) As Integer

                For Each chb As CheckBox In GroupBoxComplete.Controls.OfType(Of CheckBox)
                    compl(i) = If(chb.Checked, 1, 0)
                    If compl(i) - InitComplMarkers(i) <> 0 Then
                        queryCompleteMarker += $", {chb.Name}={compl(i)}"
                        If chb.Checked Then adds = $"Закончить этап {chb.Text}"
                    End If
                        i += 1
                Next
                log = Form_Notice_Log.Text
                If log = "" Then
                    log = $"@{Form_Main.us}|{Now.ToString("dd/MM/yyyy hh:mm")}: {RichTextBoxFormNotice.Text}"
                Else
                    log += $"{vbCrLf}@{Form_Main.us}|{Now.ToString("dd/MM/yyyy hh:mm")}: {RichTextBoxFormNotice.Text}"
                End If
                cmd.CommandText = $"update table_Sample_Set set Loggs='{log}.{adds}' {queryCompleteMarker} where Country_Code='{Country_Code}' and Client_ID='{Client_ID}' and Year='{Year}' and Sample_Set_ID='{Sample_Set_ID}' and Sample_Set_Index='{Sample_Set_Index}'"
                cmd.ExecuteNonQuery()
                Form_Notice_Log.Text = log
                RichTextBoxFormNotice.Clear()
            End Using
        End Using
    End Sub
End Class