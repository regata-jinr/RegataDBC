using System.Windows.Forms;
using Regata.UITemplates;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Extensions.Models;
using Microsoft.EntityFrameworkCore;

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

        private Button ButtonExport;
        private Button ButtonSaveToDB;
        private Button ButtonAddSample;
        private Button ButtonClearSelection;
        private ToolStripMenuItem MenuItemMenuType;
        //private ToolStripMenuItem MenuItemMenuSubType;


        private async Task GenerateTypeAndSubTypeMenuItems()
        {

            FillTypeMenu(ref MenuItemMenuType, _types);


            //var subTypes = await _ic.Types.Where(t => t.Type == ).Select(s => s.A_Sample_Subtype).Distinct().ToArrayAsync();
            //FillTypeMenu(ref MenuItemMenuSubType, subTypes);
        }

        private void FillTypeMenu(ref ToolStripMenuItem item, string[] names)
        {

            ToolStripMenuItem[] tmis = new ToolStripMenuItem[names.Length];
            for (var i = 0; i < names.Length; ++i)
            {
                tmis[i] = new ToolStripMenuItem()
                {
                    Name = names[i],
                    AutoSize = true,
                    CheckOnClick = true

                };
                tmis[i].CheckedChanged += MenuItemMenuTypes_CheckedChanged;
            }

            item.DropDownItems.AddRange(tmis);
        }

        private void MatchType()
        {
            if (!Data.Any()) return;

            var lst = Data.Last();
            
            foreach (ToolStripMenuItem tm in MenuItemMenuType.DropDownItems)
            {
                if (tm.Name == lst.A_Sample_Type)
                {
                    tm.Checked = true;
                    MenuItemMenuTypes_CheckedChanged(tm, null);
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RussianLabels = new Dictionary<string, string>() {
                { "ButtonExport",             $"Экспорт из {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB",           "Сохранить" },
                { "ButtonClearSelection",           "Снять выделение" },
                { "MenuItemMenuType",         "Тип" },
                { "MenuItemMenuSubType",      "Подтип" },
                { "ButtonAddSample",          "Добавить образец" },
                { "FormText",                 $"Просмотр партии - {SetKey}" },
                { "MoreThan99Message",        "В партии должно быть не более 99 образцов!"},
                { "ExportCancelledByTimeout", "Экспортирование было отменено по таймауту. Проверьте соединение с интернетом."},
                { "SavingCancelledByTimeout", "Сохранение было отменено по таймауту. Похоже БД недоступна."},
                { "InitSavingToDb",           "Сохранение данных в базу"},
                { "SavedToDbSuccessfuly",     "Сохранение успешно завершено"},
                { "InitialExport",            "Экспортирование файла"},
                { "SuccessExport",            "Экспортирование успешно завершено"},
                { "DeleteFromDB",             $"При повторном экспортировании данных уже загруженная информация будет удалена. Вы хотите продолжить?"},
                { "HelpMessagePromt",         $"Вставьте ссылку на таблицу Google.{Environment.NewLine}Убедитесь, что файл доступен для просмотра по ссылке."},
                { "HelpCaptionPromt",         "Экспортирование данных из файла Google Sheet"},
                { "biomedical",     "Биологические материалы"},
                { "others",                   "Другое"},
                { "filters",                  "Фильтры"},
                { "rocks",                    "Руда"},
                { "technological",            "Технологический"},
                { "luquids",                  "Жидкость"},
                { "sediments",                "Осадочный"},
                { "soils",                    "Почва"},
                { "foodstuffs",               "Пищевой"},
                { "vegetation",               "Растительность"},
                { "lichens", "Лишайники" },
                { "leaves", "Дистья" },
                { "teeth", "Зубы" },
                { "tree-bark", "" },
                { "hairs", "Волосы" },
                { "moss", "Мхи" }
            };

            EnglishLabels = new Dictionary<string, string>() {
                { "ButtonExport",             $"Export from {Environment.NewLine} GoogleSheet" },
                { "ButtonSaveToDB",           "Save" },
                { "ButtonClearSelection",           "Clear selection" },
                { "MenuItemMenuType",         "Type" },
                { "MenuItemMenuSubType",      "SubType" },
                { "ButtonAddSample",          "Add sample" },
                { "FormText",                 $"Set content - {SetKey}" },
                { "MoreThan99Message",        "Set can't contain more than 99 samples!"},
                { "ExportCancelledByTimeout", "Export has cancelled by timeout. Check internet connection."},
                { "SavingCancelledByTimeout", "Saving has cancelled by timeout. Check internet connection."},
                { "InitSavingToDb",           "Initialising data save process into db"},
                { "SavedToDbSuccessfuly",     "Data has been saved successfully"},
                { "InitialExport",            "Initialization file export process"},
                { "SuccessExport",            "Data has been exported successfully"},
                { "DeleteFromDB",             $"In case of 'yes' existing information about samples will be delete. Do you want to continue?"},
                { "HelpMessagePromt",         $"Please paste link to the shared Google Sheet file"},
                { "HelpCaptionPromt",         "Export from Google Sheets"},
                { "biomedical",     "Biomedical materials"},
                { "others",                   "Other"},
                { "filters",                  "Filters"},
                { "rocks",                    "Rocks"},
                { "technological",            "Technological"},
                { "luquids",                  "Liquids"},
                { "sediments",                "Sediments"},
                { "soils",                    "Soils"},
                { "foodstuffs",               "Food"},
                { "vegetation",               "Vegetation"},
                { "lichens", "Lichens" },
                { "leaves", "Leaves" },
                { "teeth", "Teeth" },
                { "tree-bark", "Tree-Bark" },
                { "hairs", "Hairs" },
                { "moss", "Moss" }
           };

            MenuItemMenuType = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuType", AutoSize = true };
            //MenuItemMenuSubType = new System.Windows.Forms.ToolStripMenuItem() { Name = "MenuItemMenuSubType", AutoSize = true };

            MenuStrip.Items.Add(MenuItemMenuType);
            //MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //MenuItemMenuType, MenuItemMenuSubType});


            this.Text = "Content of set: ";
            DataGridView.ReadOnly = false;
            ButtonExport = new Button();
            ButtonExport.Name = "ButtonExport";
            ButtonExport.Click += ExportButton_Click;

            ButtonSaveToDB = new Button();
            ButtonSaveToDB.Name = "ButtonSaveToDB";
            ButtonSaveToDB.Click += ButtonSaveToDB_Click;
            ButtonSaveToDB.Enabled = false;

            ButtonClearSelection = new Button();
            ButtonClearSelection.Name = "ButtonClearSelection";
            ButtonClearSelection.Click += ButtonClearSelection_Click;

            ButtonAddSample = new Button();
            ButtonAddSample.Name = "ButtonAddSample";
            ButtonAddSample.Click += ButtonAddSample_Click;

            Labels.AddRussianLabels(ref RussianLabels);
            Labels.AddEnglishLabels(ref EnglishLabels);
            AddButtonToLayout(ButtonExport);
            AddButtonToLayout(ButtonSaveToDB);
            AddButtonToLayout(ButtonAddSample);
            AddButtonToLayout(ButtonClearSelection);

            DataGridView.Columns[5].ReadOnly = true;

        }

        private void ButtonClearSelection_Click(object sender, EventArgs e)
        {
            DataGridView.ClearSelection();
        }

        #endregion
    }
}

