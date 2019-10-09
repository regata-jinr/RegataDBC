using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace NewForms
{
    public class AdvancedBindingSource<T>
    {
        private readonly BindingSource _bindingSource;
        private readonly List<T> _sourceList;
        private readonly Type _basicType;
        private readonly PropertyInfo[] _propertiesList;
        private DataTable _datatable;
        private readonly DataSet _dataset;

        public BindingSource GetBindingSource()
        {
            return _bindingSource;
        }

        public AdvancedBindingSource(List<T> list)
        {
            _sourceList = list;
            _bindingSource = new BindingSource();
            
            _basicType = typeof(T);
            _propertiesList = _basicType.GetProperties();
            _dataset = new DataSet();
            _datatable = new DataTable();
            CreateColumns();
            FillData();

            _bindingSource.DataSource = _dataset;

        }

        private void CreateColumns()
        {
            _datatable = _dataset.Tables.Add(_basicType.Name);

            foreach (var pi in _propertiesList)
                _datatable.Columns.Add(pi.Name, Nullable.GetUnderlyingType(
            pi.PropertyType) ?? pi.PropertyType);

            _bindingSource.DataMember = _datatable.TableName;
        }

        private void FillData()
        {
            foreach (var ent in _sourceList)
            {
                object[] newrow = new object[_propertiesList.Length];

                for (int i = 0; i < _propertiesList.Length; ++i)
                    newrow[i] = _propertiesList[i].GetValue(ent);

                _datatable.Rows.Add(newrow);
            }
        }
    }
}
