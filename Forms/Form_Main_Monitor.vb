Imports System.Data.SqlClient
Partial Public Class Form_Main
    Private Sub fill_in_monitor_monitor()
        Try
            Dim i As Integer
            ListBox_Monitor_Monitor.Items.Clear()
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If Table_Monitor_SetDataGridView.SelectedRows.Count > 0 Then
                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_SLI_Irradiation_Log WHERE Country_Code='m' and Client_Id='m' and Year='m' and Sample_Set_Id='" + Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "Русский" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "English" Then
                                ListBox_Monitor_Monitor.Items.Add("SLI log: ")
                            End If
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()

                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_LLI_Irradiation_Log WHERE Country_Code='m' and Client_Id='m' and Year='m' and Sample_Set_Id='" + Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "Русский" Then
                                ListBox_Monitor_Monitor.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "English" Then
                                ListBox_Monitor_Monitor.Items.Add("LLI log: ")
                            End If
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_Monitor.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()
            End If
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Table_Monitor_SetDataGridView_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table_Monitor_SetDataGridView.CellMouseUp
        fill_in_monitor_monitor()
    End Sub

    Private Sub Table_Monitor_SetDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Table_Monitor_SetDataGridView.SelectionChanged
        fill_in_monitor_monitor()
    End Sub

    Private Sub B_New_Monitor_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_Monitor_Set_Accept.Click
        Try
            Me.Enabled = False
            Form_Monitor_Set_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Monitor_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_Monitor_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_Monitor_Set.Click
        Try
            Form_Monitor_Accept.L_Monitor_Set_Name.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(0).Value
            Form_Monitor_Accept.L_Monitor_Set_Number.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(1).Value
            Form_Monitor_Accept.L_Monitor_Set_Weight.Text = Table_Monitor_SetDataGridView.SelectedCells.Item(3).Value
            Me.Enabled = False
            Form_Monitor_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_Monitor_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

End Class
