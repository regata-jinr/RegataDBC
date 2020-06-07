Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Form_Sample_Set_Accept_Print_Form
    Dim memoryImage As Bitmap

    ' Declare a string to hold the entire document contents.
    Private documentContents As String

    ' Declare a variable to hold the portion of the document that
    ' is not printed.
    Private stringToPrint As String

    Private Sub B_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Print.Click
        Try
            B_Close.Visible = False
            B_Print.Visible = False
            CaptureScreen()
            PrintDocument1.Print()
            B_Close.Visible = True
            B_Print.Visible = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Print_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Print_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub B_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Close.Click
        Try
            Me.Close()
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in B_Close_Click!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub CaptureScreen()
        Try
            Dim myGraphics As Graphics = Me.CreateGraphics()
            Dim s As Size = Me.Size
            memoryImage = New Bitmap(s.Width, s.Height, myGraphics)
            Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
            memoryGraphics.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в CaptureScreen!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in CaptureScreen!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _
       PrintDocument1.PrintPage
        Try
            e.Graphics.DrawImage(memoryImage, 0, 0)
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в printDocument1_PrintPage!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in printDocument1_PrintPage!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_New_Sample_Set_Accept_Print_Form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Form_Sample_Set_Accept.Enabled = True
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_New_Sample_Set_Accept_Print_Form_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_New_Sample_Set_Accept_Print_Form_FormClosed!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub

    Private Sub Form_Sample_Set_Accept_Print_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If Form_Main.language = "Русский" Then
                Me.Text = "Приём новой партии образцов"

                L_Name_FLNP.Text = "Объединённый институт ядерных исследований     Лаборатория нейтронной физики им И.М. Франка"
                L_Name_Country.Text = "Страна"
                'L_Name_Client_ID.Text = "Номер клиента"
                L_Name_Postal_Code.Text = "Индекс:"
                L_Name_Republic.Text = "Республика:"
                L_Name_Region.Text = "Область:"
                L_Name_District.Text = "Район:"
                L_Name_City.Text = "Город:"
                L_Name_Street.Text = "Улица:"
                L_Name_House.Text = "Дом:"
                L_Name_Building.Text = "Строение:"
                L_Name_Organization.Text = "Организация:"
                'L_Name_Title.Text = "Title:"
                'L_Name_Gender.Text = "Пол:"
                L_Name_Last_Name.Text = "Фамилия:"
                L_Name_First_Name.Text = "Имя:"
                'L_Name_Middle_Name.Text = "Middle name:"
                'L_Name_Phone_Country_Code_Phone_1.Text = "Country code:"
                'L_Name_Code_Phone_1.Text = "Code:"
                L_Name_Phone_1.Text = "Телефон 1:"
                'L_Name_Phone_Country_Code_Phone_2.Text = "Country code:"
                'L_Name_Code_Phone_2.Text = "Code:"
                L_Name_Phone_2.Text = "Телефон 2:"
                'L_Name_Phone_Country_Code_Fax_1.Text = "Country code:"
                'L_Name_Code_Fax_1.Text = "Code:"
                L_Name_Fax_1.Text = "Факс 1:"
                'L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Country code:"
                'L_Name_Code_Mobile_Phone_1.Text = "Code:"
                L_Name_Mobile_Phone_1.Text = "Моб. тел. 1:"
                L_Name_E_mail_1.Text = "e-mail 1:"
                L_Name_E_mail_2.Text = "e-mail 2:"
                L_Name_Notes.Text = "Примечания:"

                'B_NewClient.Text = "Добавить нового клиента"
                'B_Correct_Client_Info.Text = "Изменить информацию о клиенте"
                'L_Name_Sample_Set_List.Text = "Список партий образцов"
                'L_Name_New_Sample_Set_ID.Text = "Номер новой партии"
                'L_Name_New_Sample_Set_Index.Text = "Индекс новой партии"
                L_Name_SampleSetReceiptDate.Text = "Дата приёма партии образцов:"
                L_Name_SampleSetReportDate.Text = "Дата возврата партии образцов:"

                L_Name_Notes_1.Text = "Примечания"
                'B_Fill_Notes_1.Text = "Быстро заполнить примечания 1"

                L_Name_ReceivedBy.Text = "Принято"
                Label_Name_Code.Text = "Страна-Клиент-Год-№ парт.-Ин. п."
                'B_SaveNewSampleAcceptance.Text = "Сохранить новую партию"
                L_Name_Client_s_Signature.Text = "Подпись клиента   ____________"
                B_Print.Text = "Печать"
                B_Close.Text = "Закрыть"
            ElseIf Form_Main.language = "English" Then
                Me.Text = "New sample set acceptance"

                L_Name_FLNP.Text = "           Joint Institute for Nuclear Research                       Frank Laboratory of Neutron Physics"
                L_Name_Country.Text = "Country"
                ' L_Name_Client_ID.Text = "Client ID"
                L_Name_Postal_Code.Text = "Postal code:"
                L_Name_Republic.Text = "Republic:"
                L_Name_Region.Text = "Region:"
                L_Name_District.Text = "District:"
                L_Name_City.Text = "City:"
                L_Name_Street.Text = "Street:"
                L_Name_House.Text = "House:"
                L_Name_Building.Text = "Building:"
                L_Name_Organization.Text = "Organization:"
                'L_Name_Title.Text = "Title:"
                'L_Name_Gender.Text = "Gender:"
                L_Name_Last_Name.Text = "Last name:"
                L_Name_First_Name.Text = "Fist name:"
                'L_Name_Middle_Name.Text = "Middle name:"
                'L_Name_Phone_Country_Code_Phone_1.Text = "Country code:"
                'L_Name_Code_Phone_1.Text = "Code:"
                L_Name_Phone_1.Text = "Phone 1:"
                'L_Name_Phone_Country_Code_Phone_2.Text = "Country code:"
                'L_Name_Code_Phone_2.Text = "Code:"
                L_Name_Phone_2.Text = "Phone 2:"
                'L_Name_Phone_Country_Code_Fax_1.Text = "Country code:"
                'L_Name_Code_Fax_1.Text = "Code:"
                L_Name_Fax_1.Text = "Fax 1:"
                'L_Name_Phone_Country_Code_Mobile_Phone_1.Text = "Country code:"
                'L_Name_Code_Mobile_Phone_1.Text = "Code:"
                L_Name_Mobile_Phone_1.Text = "Mob. phone 1:"
                L_Name_E_mail_1.Text = "e-mail 1:"
                L_Name_E_mail_2.Text = "e-mail 2:"
                L_Name_Notes.Text = "Notes:"

                'B_NewClient.Text = "Add new client"
                'B_Correct_Client_Info.Text = "Change client info"
                'L_Name_Sample_Set_List.Text = "Sample set list"
                'L_Name_New_Sample_Set_ID.Text = "New sample set ID"
                'L_Name_New_Sample_Set_Index.Text = "New sample set index"
                L_Name_SampleSetReceiptDate.Text = "Sample set acceptance date:"
                L_Name_SampleSetReportDate.Text = "Sample set report date:"

                L_Name_Notes_1.Text = "Notes"

                L_Name_ReceivedBy.Text = "Received by"
                Label_Name_Code.Text = "Country-Client-Year-Set ID-Set index"
                'B_SaveNewSampleAcceptance.Text = "Save new sample set"
                L_Name_Client_s_Signature.Text = "Client's signature   ____________"
                B_Print.Text = "Print"
                B_Close.Text = "Close"
            End If
        Catch ex As Exception
            If Form_Main.language = "Русский" Then
                MsgBox("Операция была отменена (ошибка в Form_Sample_Set_Accept_Print_Form_Load!", MsgBoxStyle.Critical, Me.Text)
            ElseIf Form_Main.language = "English" Then
                MsgBox("Operation was cancelled (error in Form_Sample_Set_Accept_Print_Form_Load!", MsgBoxStyle.Critical, Me.Text)
            End If
            Exit Sub
        End Try
    End Sub
End Class