Imports System.ComponentModel
Imports System.Data.SqlClient
Partial Public Class Form_Main



    Private Sub Fill_In_Monitor() 'заполнение отображаемой информации в Label Monitor и раскраска DataGridView1
        Debug.WriteLine("Fill In Monitor started:")
        Try
            L_Monitor.Text = ""
            Dim i As Integer
            Dim Country, Organzation, LastName, SampleType, SLIF, LLIF, Results, SLIDateString, LLIDateString, Notice, NoticeMod, WorkType, Note As String
            Dim ProcessedBy As String = ""
            Dim SLIDateAr As New ArrayList
            Dim LLIDateAr As New ArrayList
            Dim CountOfSample As Integer
            Dim ProcessedSample As Integer = 0
            Dim SamplesDistribution As New Dictionary(Of String, Integer) From {{"accepted", 0}, {"prepared", 0}, {"SLI", 0}, {"LLI", 0}, {"SLI|LLI&Results", 0}, {"SLI&LLI&Results", 0}}
            Country = ""
            Organzation = ""
            LastName = ""
            SampleType = ""
            SLIF = ""
            LLIF = ""
            Results = ""
            SLIDateString = ""
            LLIDateString = ""
            Notice = ""
            NoticeMod = ""
            WorkType = ""
            Note = ""
            Dim TypeSet As HashSet(Of String) = New HashSet(Of String)
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand
            Dim reader As SqlDataReader

            If DataGridView_Sample_Set.SelectedCells.Count = 0 Then Exit Sub 'чтобы избежать ошибки при сортировке срабатывает selectionChanged до выполнения тела события columnHeaderClick

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select * from SamplesSetForNaaDB where Country_Code ='" + DataGridView_Sample_Set.SelectedCells.Item(0).Value + "' and  Client_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(1).Value + "' and Year = '" + DataGridView_Sample_Set.SelectedCells.Item(2).Value + "' and Sample_Set_ID = '" + DataGridView_Sample_Set.SelectedCells.Item(3).Value + "' and Sample_Set_Index = '" + DataGridView_Sample_Set.SelectedCells.Item(4).Value + "'"

            CountOfSample = 0
            i = 1
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            'подумать над оптимизацией через циклы и индексы
            While reader.Read()
                If Not IsDBNull(reader(5)) Then Country = reader(5).ToString
                If Not IsDBNull(reader(6)) Then Organzation = reader(6).ToString
                If Not IsDBNull(reader(7)) Then LastName = reader(7).ToString
                If Not IsDBNull(reader(8)) Then CountOfSample += reader(8)
                If Not IsDBNull(reader(9)) Then TypeSet.Add(reader(9).ToString)
                If Not IsDBNull(reader(10)) Then
                    If Not SLIDateAr.Contains(Format(reader(10), "dd.MM.yyyy").ToString()) Then
                        If i Mod 3 <> 0 Then
                            SLIDateAr.Add(Format(reader(10), "dd.MM.yyyy").ToString())
                            SLIDateString += Format(reader(10), "dd.MM.yyyy").ToString() + ", "
                        Else
                            SLIDateAr.Add(Format(reader(10), "dd.MM.yyyy").ToString())
                            SLIDateString += Format(reader(10), "dd.MM.yyyy").ToString() + vbCrLf
                        End If
                    End If
                Else
                    SLIDateAr.Add("")
                    SLIDateString += ""
                End If

                If Not IsDBNull(reader(11)) Then
                    If Not LLIDateAr.Contains(Format(reader(11), "dd.MM.yyyy").ToString()) Then
                        If i Mod 3 <> 0 Then
                            LLIDateAr.Add(Format(reader(11), "dd.MM.yyyy").ToString())
                            LLIDateString += Format(reader(11), "dd.MM.yyyy").ToString() + ", "
                        Else
                            LLIDateAr.Add(Format(reader(11), "dd.MM.yyyy").ToString())
                            LLIDateString += Format(reader(11), "dd.MM.yyyy").ToString() + vbCrLf
                        End If
                    End If
                Else
                    LLIDateAr.Add("")
                    LLIDateString += ""
                End If

                If Not IsDBNull(reader(12)) Then ProcessedBy = reader(12).ToString
                If Not IsDBNull(reader(13)) Then
                    Results = reader(13).ToString
                End If
                If Not IsDBNull(reader(14)) Then
                    SamplesDistribution("prepared") += reader(8)
                End If
                If Not IsDBNull(reader(15)) Then
                    SamplesDistribution("SLI") += reader(8)
                End If
                If Not IsDBNull(reader(16)) Then
                    SamplesDistribution("LLI") += reader(8)
                End If
                If ((Not IsDBNull(reader(15))) Or (Not IsDBNull(reader(16)))) And (Not IsDBNull(reader(13))) Then
                    SamplesDistribution("SLI|LLI&Results") += reader(8)
                End If
                If Not IsDBNull(reader(15)) And Not IsDBNull(reader(16)) And Not IsDBNull(reader(13)) Then
                    SamplesDistribution("SLI&LLI&Results") += reader(8)
                End If
                If Not IsDBNull(reader(18)) Then Notice = reader(18).ToString
                If Not IsDBNull(reader(20)) Then
                    ProcessedSample = reader(20)
                End If
                If Not IsDBNull(reader(21)) Then
                    WorkType = reader(21)
                End If
                If Not IsDBNull(reader(22)) Then
                    Note = reader(22)
                End If
                i += 1
            End While
            reader.Close()
            sqlConnection1.Close()

            SamplesDistribution("accepted") = CountOfSample

            If Results <> "" Then Results = "Yes"

            For k As Integer = 0 To TypeSet.Count - 1
                SampleType += $"{TypeSet.ToArray().GetValue(k)},"
            Next
            If Not String.IsNullOrEmpty(SampleType) Then SampleType = SampleType.Substring(0, SampleType.Length - 1)
            L_Monitor.Text = "Страна: " + Country + vbCrLf + "Организация: " + Organzation + vbCrLf + "Фамилия: " + LastName + vbCrLf + "Кол-во образцов: " + CountOfSample.ToString + vbCrLf + "Тип образцов: " + SampleType + vbCrLf + "Дата КЖИ: " + SLIDateString + vbCrLf + "Дата ДЖИ: " + LLIDateString + vbCrLf + "Обработчик: " + ProcessedBy + vbCrLf + "Результаты: " + Results + vbCrLf + "Обработано образцов: " + ProcessedSample.ToString + " из " + CountOfSample.ToString + vbCrLf + "Комментарии:" + vbCrLf + Notice + vbCrLf + "Тип работ: " + WorkType + vbCrLf + "Примечание к партии: " + vbCrLf + Note

            SLIDateAr.Clear()
            LLIDateAr.Clear()

            If DataGridView_Description.RowCount > 0 Then
                DataGridView_Description.Rows(0).Cells(0).Value = SamplesDistribution("accepted")
                DataGridView_Description.Rows(1).Cells(0).Value = SamplesDistribution("prepared")
                DataGridView_Description.Rows(2).Cells(0).Value = SamplesDistribution("SLI")
                DataGridView_Description.Rows(3).Cells(0).Value = SamplesDistribution("LLI")
                DataGridView_Description.Rows(4).Cells(0).Value = SamplesDistribution("SLI|LLI&Results")
                DataGridView_Description.Rows(5).Cells(0).Value = SamplesDistribution("SLI&LLI&Results")

            End If

            Colorize(DataGridView_Sample_Set.SelectedRows.Item(0))

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub

    Private Sub Colorize(row As DataGridViewRow) 'раскраска DataGridView1
        Try
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Dim cmd As New System.Data.SqlClient.SqlCommand

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "select color from SamplesSetForNaaDB where Country_Code ='" + row.Cells(0).Value + "' and  Client_ID = '" + row.Cells(1).Value + "' and Year = '" + row.Cells(2).Value + "' and Sample_Set_ID = '" + row.Cells(3).Value + "' and Sample_Set_Index = '" + row.Cells(4).Value + "'"

            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            row.DefaultCellStyle.BackColor = Color.FromName(cmd.ExecuteScalar().ToString())
            sqlConnection1.Close()

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try
    End Sub

    Sub DataSampleSetLoad(ByVal Field As String)
        Try
            ChangeLang.Text = language
            Debug.WriteLine("DataSampleSetLoad:")
            SampleSetFormLoadFlag = False
            Dim sqlConnection1 As New SqlConnection(MyConnectionString)
            Using cmd As New System.Data.SqlClient.SqlCommand

                cmd.CommandType = System.Data.CommandType.Text
                fields = Field

                cmd.CommandText = "select distinct sampSet.Country_Code, sampSet.Client_ID, sampSet.Year, sampSet.Sample_Set_ID,            sampSet.Sample_Set_Index from SamplesSetForNaaDB as sampSet " + Field + " order by sampSet.Year, sampSet.Sample_Set_ID, sampSet.Client_ID, sampSet.Country_Code, sampSet.Sample_Set_Index"

                Dim dataadapter As New SqlDataAdapter(cmd.CommandText, sqlConnection1)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "SampleInf")
                DataGridView_Sample_Set.DataSource = ds
                DataGridView_Sample_Set.DataMember = "SampleInf"
                DataGridView_Sample_Set.ReadOnly = True
                DataGridView_Sample_Set.AllowUserToAddRows = False
                DataGridView_Sample_Set.ClearSelection() ' вызывает срабатывание changeselection чтобы не было не выделенной строки при добавляем флаги SampleSetFormLoadFlag
                SampleSetFormLoadFlag = True

                Dim start As Integer = DataGridView_Sample_Set.RowCount - DataGridView_Sample_Set.DisplayedRowCount(True)
                Dim finish As Integer = DataGridView_Sample_Set.RowCount

                For i As Integer = start To finish - 1
                    Colorize(DataGridView_Sample_Set.Rows.Item(i))
                Next

                If DataGridView_Sample_Set.RowCount = 0 Then
                    MsgBox("Таких значений нет")
                    DataSampleSetLoad("")
                    ' Exit Sub
                End If

                DataGridView_Sample_Set.Rows.Item(DataGridView_Sample_Set.RowCount - 1).Selected = True
                DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1

                If Not BackgroundWorkerColorizer.IsBusy Then BackgroundWorkerColorizer.RunWorkerAsync()
            End Using
        Catch backgroundWorker As InvalidOperationException
        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
        End Try


    End Sub

    Private Sub ColorizeAll()
        Try
            For Each row As DataGridViewRow In DataGridView_Sample_Set.Rows
                Colorize(row)
            Next
        Catch ex As ArgumentOutOfRangeException
            Debug.WriteLine("Too much activities in sorting")
        End Try

    End Sub

    Private Sub BackgroundWorkerColorizer_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerColorizer.DoWork
        ColorizeAll()
    End Sub

    Private Sub DataGridView_Sample_Set_ColumnHeaderMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_Sample_Set.ColumnHeaderMouseClick
        Debug.WriteLine("DataGridView_Sample_Set HeaderClick event started")
        Try
            Dim start As Integer = DataGridView_Sample_Set.RowCount - DataGridView_Sample_Set.DisplayedRowCount(True)
            Dim finish As Integer = DataGridView_Sample_Set.RowCount

            For i As Integer = start To finish - 1
                Colorize(DataGridView_Sample_Set.Rows.Item(i))
            Next


            DataGridView_Sample_Set.Rows.Item(DataGridView_Sample_Set.RowCount - 1).Selected = True
            DataGridView_Sample_Set.FirstDisplayedScrollingRowIndex = DataGridView_Sample_Set.RowCount - 1

            If Not BackgroundWorkerColorizer.IsBusy Then
                BackgroundWorkerColorizer.RunWorkerAsync()
            End If

        Catch ex As Exception
            LangException(language, ex.Message & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView_Sample_Set_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView_Sample_Set.SelectionChanged
        Try
            If SampleSetFormLoadFlag Then Fill_In_Monitor()
        Catch ex As Exception
        End Try
    End Sub

End Class
