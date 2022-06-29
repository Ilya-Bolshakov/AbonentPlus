using Practice1_MongoDB_With_On_WinForms.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_MongoDB_With_On_WinForms.forms
{
    public partial class Form_Request : Form
    {
        private readonly MongoDBContext context;
        private BindingList<Request> _bindList;
        public Form_Request()
        {
            InitializeComponent();
            context = MongoDBContext.GetObject();
            _bindList = context.Load_DataRequest();
            dataGridView.DataSource = _bindList;

            // формируем список атрибутов для фильтрации
            IList<string> vs = new List<string>();
            foreach (DataGridViewColumn item in dataGridView.Columns)
            {
                vs.Add(item.HeaderText);
            }
            cb_Filters.DataSource = vs;

            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void tb_FilterValue_TextChanged(object sender, EventArgs e)
        {
            int prop = cb_Filters.SelectedIndex;
            string value = tb_FilterValue.Text;
            dataGridView.Filter(prop, value, (p, v) =>
            {
                if (p == null)
                {
                    return false;
                }
                return p.ToLower().Contains(v.ToLower());
            });
        }
    }
}
