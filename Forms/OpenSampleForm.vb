Imports System.Data
Imports System.Data.SqlClient
Imports NaaDB.Microsoft.Office.Interop.Excel

Public Class OpenSampleForm
    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        Try
            '   SaveFileDialogExportToExcel.InitialDirectory = "C:\GENIE2K\"
            SaveFileDialogExportToExcel.FileName = $"Список партий для печати"
            If SaveFileDialogExportToExcel.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf System.Windows.Forms.DialogResult.OK Then
                Me.Enabled = False

                Dim dt As New DataTable()
                Dim contNum As Integer = 1
                Dim finish, len As Integer
                len = 0
                finish = 0

                For Each column As DataGridViewColumn In DataGridViewForPrint.Columns
                    dt.Columns.Add(column.HeaderText, column.ValueType)
                Next

                For Each row As DataGridViewRow In DataGridViewForPrint.Rows
                    dt.Rows.Add()
                    For Each cell As DataGridViewCell In row.Cells
                        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value
                    Next
                Next

                dt.TableName = "ListOfSamples"

                'If (String.IsNullOrEmpty(Form_Main.DataGridView_Description.SelectedRows.Count = 0), "ListOfSamples", Form_Main.DataGridView_Description.SelectedRows(0).Cells(1).Value) Then

                Dim inum As Integer = 1
                    Using wb As New ClosedXML.Excel.XLWorkbook()
                        Dim ws = wb.Worksheets.Add(dt)

                        'Dim rngbord = ws.Range(1, 1, dt.Rows.Count + 2, dt.Columns.Count)
                        'rngbord.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                        'rngbord.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                        'rngbord.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                        'ws.Columns().Style.Alignment.WrapText = True
                        'ws.Columns().AdjustToContents()
                        wb.SaveAs(SaveFileDialogExportToExcel.FileName)
                        Dim result As Integer = MessageBox.Show("Готово! Хотите открыть файл?", "Экспорт в excel", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            Me.Enabled = True
                            Exit Sub
                        ElseIf result = DialogResult.Yes Then
                            Me.Close()
                            System.Diagnostics.Process.Start(SaveFileDialogExportToExcel.FileName)
                        End If
                    End Using
                End If
                Me.Close()
        Catch ex As Exception
            Me.Enabled = True
            MsgBox(ex.ToString)
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Save_Final_Report_Click)!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("The operation was cancelled (error in B_Save_Final_Report_Click)!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub



    'загрузка файла по клику на ячейку с именем
    'Private Sub OpenSetSLIDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OpenSetSLIDataGridView.CellClick
    '    If e.ColumnIndex = 7 Then
    '        OpenSetSLIDataGridView.SelectedCells.Item(0).Value.ToString()
    '    End If
    'End Sub
End Class