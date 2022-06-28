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
    public partial class Form_Disrepair : Form
    {
        private readonly MongoDBContext context;
        private BindingList<Disrepair> _bindList;
        public Form_Disrepair()
        {
            InitializeComponent();

            context = MongoDBContext.GetObject();
            _bindList = context.Load_DataDisrepair();
            dataGridView.DataSource = _bindList;

            // формируем список атрибутов для фильтрации
            //IList<string> vs = new List<string>();
            //foreach (DataGridViewColumn item in dataGridView.Columns)
            //{
            //    vs.Add(item.Name);
            //}
            //cb_Filters.DataSource = vs;
        }
    }
}
