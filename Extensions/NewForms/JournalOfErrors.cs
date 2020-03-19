using System.Linq;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using Extensions.Models;
using Extensions.Classes;
using Microsoft.EntityFrameworkCore;

namespace Extensions.NewForms
{
    //FIXME: after usage of binding list adgv filters stop working
    //TODO: add search logic with separator: RU-11-12-34-c
    //TODO: create and open file with content of journal when download spectra files
    //FIXME: after running debug file from bin/Debug has stack overflow exception, but from obj/Debug/x86 does not
    //TODO: save text of journal in case of exists to folder after saving spectra
    public partial class JournalOfErrors : Form
    {
        private string _connectionString;
        InfoContext _ic;

        private bool CheckRoles()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("select IS_Rolemember('operator') + IS_Rolemember('db_owner')", conn))
                {
                    conn.Open();
                    object o = cmd.ExecuteScalar();
                    if ((o == null || DBNull.Value == o) ? false : ((int)o != 0))
                        return true;
                }
            }
            return false;
        }

        public JournalOfErrors(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _ic = new InfoContext(_connectionString);
            _ic.Sets.Load();

            _bindingSource.DataSource = _ic.Sets.Local.ToBindingList().OrderByDescending(s => s.Year).ThenByDescending(s => s.Sample_Set_ID).ThenByDescending(s => s.Sample_Set_Index);


            advancedDataGridViewJournalErr.SetDoubleBuffered();
            advancedDataGridViewJournalErr.DataSource = _bindingSource;
            advancedDataGridViewJournalErr.FilterStringChanged += AdvancedDataGridViewJournalErr_FilterStringChanged;

            SetColumnsProperties(ref advancedDataGridViewJournalErr,
                                 new string[0],
                                 new Dictionary<string, string>()
                                 {
                                    { "Country_Code",     "Код страны"    },
                                    { "Client_ID",        "Код клиента"   },
                                    { "Year",             "Год"           },
                                    { "Sample_Set_ID",    "Номер партии"  },
                                    { "Sample_Set_Index", "Индекс партии" },
                                    { "Notes_2",          "Замечание"     }
                                 }, 
                                 advancedDataGridViewJournalErr.Columns.Cast<DataGridViewColumn>().Select(c => c.Name).Take(5).ToArray());

            advancedDataGridViewJournalErr.Columns["Notes_2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            advancedDataGridViewJournalErr.DisableFilterAndSort(advancedDataGridViewJournalErr.Columns["Notes_2"]);
            advancedDataGridViewJournalErr.DisableFilterChecklist(advancedDataGridViewJournalErr.Columns["Notes_2"]);

            advancedDataGridViewSearchToolBar1.SetColumns(advancedDataGridViewJournalErr.Columns);
            advancedDataGridViewJournalErr.DisplayedRowCount(true);

            if (!CheckRoles())
                buttonSaveChanges.Visible = false;

        }

        private void AdvancedDataGridViewJournalErr_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            _bindingSource.Filter = advancedDataGridViewJournalErr.FilterString; // "([Year] IN ('11'))"

        }
        private const char delim = '-';
        private string searchedValue = "";
        private bool ComplexSearch(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            if (!e.ValueToSearch.Contains(delim))
            {
                searchedValue = e.ValueToSearch;
                return false;
            }

            foreach (var el in e.ValueToSearch.Split(delim))
            {
                searchedValue = el;
                advancedDataGridViewSearchToolBar_main_Search(sender, e);
            }

            return true;
        }

        private void advancedDataGridViewSearchToolBar_main_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            if (ComplexSearch(sender, e))
                return;

            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;

            if (!e.FromBegin)
            {
                bool endcol = advancedDataGridViewJournalErr.CurrentCell.ColumnIndex + 1 >= advancedDataGridViewJournalErr.ColumnCount;
                bool endrow = advancedDataGridViewJournalErr.CurrentCell.RowIndex + 1 >= advancedDataGridViewJournalErr.RowCount;

                if (endcol && endrow)
                {
                    startColumn = advancedDataGridViewJournalErr.CurrentCell.ColumnIndex;
                    startRow = advancedDataGridViewJournalErr.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : advancedDataGridViewJournalErr.CurrentCell.ColumnIndex + 1;

                    startRow = advancedDataGridViewJournalErr.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }

            DataGridViewCell c = advancedDataGridViewJournalErr.FindCell(
                searchedValue,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = advancedDataGridViewJournalErr.FindCell(
                    searchedValue,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                advancedDataGridViewJournalErr.CurrentCell = c;
        }

        private void SetColumnsProperties(ref Zuby.ADGV.AdvancedDataGridView adgv, string[] invisibles, Dictionary<string, string> columnHeaders, string[] readonlies)
        {
            try
            {
                foreach (var colName in invisibles)
                    adgv.Columns[colName].Visible = false;

                if (readonlies.Any())
                {
                    foreach (var colName in readonlies)
                    {
                        adgv.Columns[colName].ReadOnly = true;
                        adgv.Columns[colName].Width = 40;
                    }
                }
                else
                {
                    foreach (DataGridViewColumn col in adgv.Columns)
                        col.ReadOnly = true;
                }

                foreach (var colName in columnHeaders.Keys)
                {
                    adgv.Columns[colName].HeaderText = columnHeaders[colName];

                    if (colName.Contains("DateTime"))
                    {
                        adgv.Columns[colName].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                        adgv.Columns[colName].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }
        

        //TODO: add validations exceptions
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                _ic.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBoxTemplates.WrapExceptionToMessageBox(new ExceptionEventsArgs() { exception = ex, Level = ExceptionLevel.Error });
            }
        }

    }


}
