using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Extensions.Models;
using Extensions.Classes;

namespace Extensions.NewForms
{
    //TODO: create and open file with content of journal when download spectra files
    //FIXME: after running debug file from bin/Debug has stack overflow exception, but from obj/Debug/x86 does not
    //TODO: add search logic with separator: RU-11-12-34-c
    //TODO: translate columns names
    //TODO: change size of message column
    //TODO: order sample and only 3 last years, with button show all
    //TODO: access modifiers checking. only for operators
    //TODO: keep changes into separate list and save it after button clicked
    //TODO: save text of journal in case of exists to folder after saving spectra
    public partial class JournalOfErrors : Form
    {
        private string _connectionString;
        private AdvancedBindingSource<SetInfo> _advBindSource;

        public JournalOfErrors(string connectionString)
        {
            InitializeComponent();
            List<SetInfo> setList = null;
            _connectionString = connectionString;
            using (var ic = new InfoContext(_connectionString))
                setList = ic.Sets.ToList();

            if (setList == null)
                setList = new List<SetInfo>();

            _advBindSource = new AdvancedBindingSource<SetInfo>(setList);
            _bindingSource = _advBindSource.GetBindingSource();
            advancedDataGridViewJournalErr.SetDoubleBuffered();
            advancedDataGridViewJournalErr.DataSource = _bindingSource;

            advancedDataGridViewSearchToolBar1.SetColumns(advancedDataGridViewJournalErr.Columns);
        }

        private void advancedDataGridViewSearchToolBar_main_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
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
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = advancedDataGridViewJournalErr.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                advancedDataGridViewJournalErr.CurrentCell = c;
        }

        private void JournalOfErrors_Load(object sender, System.EventArgs e)
        {

        }

        private void JournalOfErrors_Shown(object sender, System.EventArgs e)
        {

        }
    }


}
