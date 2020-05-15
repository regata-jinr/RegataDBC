using System.Windows.Forms;
using Regata.UITemplates;
using System.Collections.Generic;
using System;
using Extensions.Models;

namespace Extensions.NewForms
{
    public partial class ShowSetContentForm : DataTableForm<Sample>
    {
        private IReadOnlyDictionary<string, string> RussianLabels;
        private IReadOnlyDictionary<string, string> EnglishLabels;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            _ic.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RussianLabels = new Dictionary<string, string>() {
                { "ButtonExport", $"Экспорт из {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB", "Сохранить" },
                { "ButtonAddSample", "Добавить образец" },
                { "FormText", $"Просмотр партии - {SetKey}" },
                { "MoreThan99Message", "В партии должно быть не более 99 образцов!"},
                { "ExportCancelledByTimeout", "Экспортирование было отменено по таймауту. Проверьте соединение с интернетом."},
                { "SavingCancelledByTimeout", "Сохранение было отменено по таймауту. Похоже БД недоступна."},
                { "InitSavingToDb", "Сохранение данных в базу"},
                { "SavedToDbSuccessfuly", "Сохранение успешно завершено"},
                { "InitialExport", "Экспортирование файла"},
                { "SuccessExport", "Экспортирование успешно завершено"},
                { "DeleteFromDB", $"При повторном экспортировании данных уже загруженная информация будет удалена. Вы хотите продолжить?"},
                { "HelpMessagePromt", $"Вставьте ссылку на таблицу Google.{Environment.NewLine}Убедитесь, что файл доступен для просмотра по ссылке."},
                { "HelpCaptionPromt", "Экспортирование данных из файла Google Sheet"}
            };

            EnglishLabels = new Dictionary<string, string>() {
                { "ButtonExport", $"Export from {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB", "Save" },
                { "ButtonAddSample", "Add sample" },
                { "FormText", $"Set content - {SetKey}" },
                { "MoreThan99Message", "Set can't contain more than 99 samples!"},
                { "ExportCancelledByTimeout", "Export has cancelled by timeout. Check internet connection."},
                { "SavingCancelledByTimeout", "Saving has cancelled by timeout. Check internet connection."},
                { "InitSavingToDb", "Initialising data save process into db"},
                { "SavedToDbSuccessfuly", "Data has been saved successfully"},
                { "InitialExport", "Initialization file export process"},
                { "SuccessExport", "Data has been exported successfully"},
                { "DeleteFromDB", $"In case of 'yes' existing information about samples will be delete. Do you want to continue?"},
                { "HelpMessagePromt", $"Please paste link to the shared Google Sheet file"},
                { "HelpCaptionPromt",  "Export from Google Sheets"}
           };
            this.Text = "Content of set: ";
            DataGridView.ReadOnly = false;
            ButtonExport = new Button();
            ButtonExport.Name = "ButtonExport";
            ButtonExport.Click += ExportButton_Click;

            ButtonSaveToDB = new Button();
            ButtonSaveToDB.Name = "ButtonSaveToDB";
            ButtonSaveToDB.Click += ButtonSaveToDB_Click;
            ButtonSaveToDB.Enabled = false;

            ButtonAddSample = new Button();
            ButtonAddSample.Name = "ButtonAddSample";
            ButtonAddSample.Click += ButtonAddSample_Click;

            Labels.AddRussianLabels(ref RussianLabels);
            Labels.AddEnglishLabels(ref EnglishLabels);
            AddButtonToLayout(ButtonExport);
            AddButtonToLayout(ButtonSaveToDB);
            AddButtonToLayout(ButtonAddSample);

            DataGridView.Columns[5].ReadOnly = true;
        }

     

        #endregion
    }
}

