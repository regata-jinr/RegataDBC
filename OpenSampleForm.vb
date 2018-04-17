Imports System.Data
Imports System.Data.SqlClient
Imports NaaDB.Microsoft.Office.Interop.Excel

Public Class OpenSampleForm
    Private Sub OpenSampleFormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(Form_Main.MyConnectionString)
        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text

        Try
            cmd.CommandText = "select distinct tss.Country_Code, tss.Client_ID, tss.Year, tss.Sample_Set_ID, tss.Sample_Set_Index, tco.Country, tcl.Organization, tcl.Last_Name from NAA_DB.dbo.table_Sample_Set as tss left join NAA_DB.dbo.table_Country as tco on tco.Country_Code = tss.Country_Code left join NAA_DB.dbo.table_Client as tcl on tcl.Client_ID = tss.Client_ID  and tcl.Country_Code = tss.Country_Code  where tss.Country_Code = '" + Form_Main.CountryCodeForOpenSet + "' and tss.Client_ID ='" + Form_Main.ClientIDForOpenSet + "' and tss.Year ='" + Form_Main.YearForOpenSet + "' and tss.Sample_Set_ID = '" + Form_Main.SampleSetIDForOpenSet + "' and tss.Sample_Set_Index = '" + Form_Main.SampleSetIndexForOpenSet + "'"

            Dim daBaseInfo As New SqlDataAdapter(cmd.CommandText, con)
            Dim dsBaseInfo As New DataSet()
            daBaseInfo.Fill(dsBaseInfo, "SLInfo")
            OpenSetBaseDataGridView.DataSource = dsBaseInfo
            OpenSetBaseDataGridView.DataMember = "SLInfo"
            OpenSetBaseDataGridView.AllowUserToAddRows = False
            OpenSetBaseDataGridView.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString)
        End Try

        Try
            cmd.CommandText = "select ts.A_Sample_ID as Sample_ID, ts.A_Sample_Type, ts.P_Weighting_SLI, ts.R_Processed_By, tsil.Date_Start as SLI_Date_Start,tsil.Time_Start as SLI_Time_Start, tsil.Channel as SLI_Channel, tsil.Duration as SLI_Duration, tsil.File_First as SLI_FileName, tsil.Irradiated_By as SLI_Irradiated_By from NAA_DB.dbo.table_Sample_Set as tss left join NAA_DB.dbo.table_Country as tco on tco.Country_Code = tss.Country_Code left join NAA_DB.dbo.table_Client as tcl on tcl.Client_ID = tss.Client_ID  and tcl.Country_Code = tss.Country_Code left join NAA_DB.dbo.table_Sample as ts on ts.F_Client_ID = tss.Client_ID and ts.F_Country_Code = tss.Country_Code and ts.F_Year = tss.Year and ts.F_Sample_Set_ID = tss.Sample_Set_ID and ts.F_Sample_Set_Index = tss.Sample_Set_Index left join NAA_DB.dbo.table_SLI_Irradiation_Log as tsil on tsil.Client_ID = tss.Client_ID and tsil.Country_Code = tss.Country_Code and tsil.Year = tss.Year and tsil.Sample_Set_ID = tss.Sample_Set_ID and tsil.Sample_Set_Index = tss.Sample_Set_Index and tsil.Sample_ID = ts.A_Sample_ID where tss.Country_Code = '" + Form_Main.CountryCodeForOpenSet + "' and tss.Client_ID ='" + Form_Main.ClientIDForOpenSet + "' and tss.Year ='" + Form_Main.YearForOpenSet + "' and tss.Sample_Set_ID = '" + Form_Main.SampleSetIDForOpenSet + "' and tss.Sample_Set_Index = '" + Form_Main.SampleSetIndexForOpenSet + "'"

            Dim daSLIInfo As New SqlDataAdapter(cmd.CommandText, con)
            Dim dsSLIInfo As New DataSet()
            daSLIInfo.Fill(dsSLIInfo, "SLInfo")
            OpenSetSLIDataGridView.DataSource = dsSLIInfo
            OpenSetSLIDataGridView.DataMember = "SLInfo"
            OpenSetSLIDataGridView.AllowUserToAddRows = False
            OpenSetSLIDataGridView.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString)
        End Try

        Try
            cmd.CommandText = "select ts.A_Sample_ID as Sample_ID, ts.A_Sample_Type, ts.P_Weighting_LLI, ts.R_Processed_By, tlil.Date_Start as LLI_Date_Start,tlil.Time_Start as LLI_Time_Start, tlil.Channel as LLI_Channel, tlil.Date_Finish as LLI_Date_Finish, tlil.Time_Finish as LLI_Time_Finish, tlil.Container_Number as LLI_Container_Number, tlil.Position_Number as LLI_Position_Number, tlil.Irradiated_By as LLI_Irradiated_By, tlil.Rehandled_By LLI_Rehandled_By, tlil.Date_Measurement_LLI_1, tlil.Measured_LLI_1_By as LLI_File1, tlil.Date_Measurement_LLI_2, tlil.Measured_LLI_2_By as LLI_File2 from NAA_DB.dbo.table_Sample_Set as tss left join NAA_DB.dbo.table_Country as tco on tco.Country_Code = tss.Country_Code left join NAA_DB.dbo.table_Client as tcl on tcl.Client_ID = tss.Client_ID  and tcl.Country_Code = tss.Country_Code left join NAA_DB.dbo.table_Sample as ts on ts.F_Client_ID = tss.Client_ID and ts.F_Country_Code = tss.Country_Code and ts.F_Year = tss.Year and ts.F_Sample_Set_ID = tss.Sample_Set_ID and ts.F_Sample_Set_Index = tss.Sample_Set_Index left join NAA_DB.dbo.table_LLI_Irradiation_Log as tlil on tlil.Client_ID = tss.Client_ID and tlil.Country_Code = tss.Country_Code and tlil.Year = tss.Year and tlil.Sample_Set_ID = tss.Sample_Set_ID and tlil.Sample_Set_Index = tss.Sample_Set_Index and tlil.Sample_ID = ts.A_Sample_ID where tss.Country_Code = '" + Form_Main.CountryCodeForOpenSet + "' and tss.Client_ID ='" + Form_Main.ClientIDForOpenSet + "' and tss.Year ='" + Form_Main.YearForOpenSet + "' and tss.Sample_Set_ID = '" + Form_Main.SampleSetIDForOpenSet + "' and tss.Sample_Set_Index = '" + Form_Main.SampleSetIndexForOpenSet + "'"

            Dim daLLIInfo As New SqlDataAdapter(cmd.CommandText, con)
            Dim dsLLIInfo As New DataSet()
            daLLIInfo.Fill(dsLLIInfo, "SLInfo")
            OpenSetLLIDataGridView.DataSource = dsLLIInfo
            OpenSetLLIDataGridView.DataMember = "SLInfo"
            OpenSetLLIDataGridView.AllowUserToAddRows = False
            OpenSetLLIDataGridView.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString)
        End Try


    End Sub

    'загрузка файла по клику на ячейку с именем
    'Private Sub OpenSetSLIDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OpenSetSLIDataGridView.CellClick
    '    If e.ColumnIndex = 7 Then
    '        OpenSetSLIDataGridView.SelectedCells.Item(0).Value.ToString()
    '    End If
    'End Sub
End Class