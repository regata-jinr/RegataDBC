Imports System.Data.SqlClient
Partial Public Class Form_Main
    Public Function Fill_In_Weight_From_File_String_Quant(ByVal file_name_p As String) As Integer
        Try
            Dim currentRow_p As String

            Dim cnt = 0
            Using MyReader As New FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim readFlag As Boolean
                readFlag = False
                currentRow_p = ""
                While Not MyReader.EndOfData
                    currentRow_p = MyReader.ReadLine
                    If readFlag Then
                        cnt += 1
                        Continue While
                    End If
                    If currentRow_p.Contains("------") Then
                        readFlag = True
                    End If
                End While
            End Using
            Debug.WriteLine($"Count of samples: {cnt - 2}")
            Return cnt - 2 ' checking contains of "-----" returns headers from 2 rows
        Catch ex As Exception
            ' Fill_In_Weight_From_File_String_Quant = -1
            LangException(language, ex.Message & ex.ToString)
            Return 0
        End Try
    End Function

    Public Sub Fill_In_Weight_From_File(ByVal file_name_p As String, ByRef row_count_p As Integer, ByRef Samples_Names_p(,) As String, ByRef Samples_Weights_p(,) As Single)
        Try
            Dim currentRow_p As String

            Using MyReader As New FileIO.TextFieldParser(file_name_p, System.Text.Encoding.Default)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(" ")
                Dim readFlag As Boolean
                Dim parsedValue As String()
                Dim headersSkip As Integer
                headersSkip = 0
                readFlag = False
                currentRow_p = ""
                Debug.WriteLine("Rows for parsing:")
                While Not MyReader.EndOfData
                    currentRow_p = MyReader.ReadLine
                    If readFlag Then
                        If headersSkip > 1 Then
                            parsedValue = currentRow_p.Split(vbTab)
                            Debug.WriteLine($"Raw was parsed to the next values: 0:{parsedValue(0)}, 1:{parsedValue(1)}, 2:{parsedValue(2)}, 3:{parsedValue(3)}")
                            Samples_Names_p(row_count_p, 0) = parsedValue(0) 'индекс пробы - первое слово до пробела
                            Samples_Names_p(row_count_p, 1) = parsedValue(1)  'имя образца - первое слово до пробела
                            Samples_Weights_p(row_count_p, 0) = parsedValue(2)
                            Samples_Weights_p(row_count_p, 1) = parsedValue(3)
                            row_count_p += 1

                        End If
                        headersSkip += 1
                        Continue While
                    End If
                    If currentRow_p.Contains("-----") Then
                        readFlag = True
                    End If
                End While
            End Using
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Table_SRM_SetDataGridView_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Table_SRM_SetDataGridView.CellMouseUp
        fill_in_monitor_SRM()
    End Sub

    Private Sub fill_in_monitor_SRM()
        Try
            Dim i As Integer
            ListBox_Monitor_SRM.Items.Clear()
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim reader As SqlDataReader
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            If Table_SRM_SetDataGridView.SelectedRows.Count > 0 Then
                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_SLI_Irradiation_Log WHERE Country_Code='s' and Client_Id='s' and Year='s' and Sample_Set_Id='" + Table_SRM_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_SRM_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "Русский" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал КЖИ: ")
                            ElseIf language = "English" Then
                                ListBox_Monitor_SRM.Items.Add("SLI log: ")
                            End If
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        End If
                    End If
                End While
                sqlConnection1.Close()

                cmd.CommandText = "SELECT DISTINCT Date_Start FROM dbo.table_LLI_Irradiation_Log WHERE Country_Code='s' and Client_Id='s' and Year='s' and Sample_Set_Id='" + Table_SRM_SetDataGridView.SelectedCells.Item(0).Value + "' and Sample_Set_Index='" + Table_SRM_SetDataGridView.SelectedCells.Item(1).Value + "' ORDER BY Date_Start"
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                i = 0
                While reader.Read()
                    If Not IsDBNull(reader(0)) Then
                        If i = 0 Then
                            If language = "Русский" Then
                                ListBox_Monitor_SRM.Items.Add("Журнал ДЖИ: ")
                            ElseIf language = "English" Then
                                ListBox_Monitor_SRM.Items.Add("LLI log: ")
                            End If
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
                            i = i + 1
                        Else
                            ListBox_Monitor_SRM.Items.Add(Format(reader(0), "dd.MM.yyyy").ToString)
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

    Private Sub Table_SRM_SetDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles Table_SRM_SetDataGridView.SelectionChanged
        fill_in_monitor_SRM()
    End Sub
    Private Sub ButtonShowAllSrms_Click(sender As Object, e As EventArgs) Handles ButtonShowAllSrms.Click
        Dim sqlConnection1 As New SqlConnection(MyConnectionString)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text

        ComboBox_Journal_Of_Irradiation_View_SelectedIndexChanged(sender, e)

        cmd.CommandText = "select * from SRM_Set_All"

        Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
        Dim ds As New DataSet()

        dataadapter.Fill(ds, "SrmSetAll")
        Table_SRM_SetDataGridView.DataSource = ds
        Table_SRM_SetDataGridView.DataMember = "SrmSetAll"
        Change_Language()
    End Sub


    Private Sub B_New_SRM_Set_Accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_New_SRM_Set_Accept.Click
        Try
            Me.Enabled = False
            Form_SRM_Set_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SRM_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub B_Select_SRM_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Select_SRM_Set.Click
        Try
            Form_SRM_Accept.L_SRM_Set_Name.Text = Table_SRM_SetDataGridView.SelectedCells.Item(0).Value
            Form_SRM_Accept.L_SRM_Set_Number.Text = Table_SRM_SetDataGridView.SelectedCells.Item(1).Value
            Form_SRM_Accept.L_SRM_Set_Weight.Text = Table_SRM_SetDataGridView.SelectedCells.Item(3).Value
            Me.Enabled = False
            Form_SRM_Accept.Show()
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Form_SRM_Set_Accept.Close()
            Me.Enabled = True
            Exit Sub
        End Try

    End Sub



End Class
