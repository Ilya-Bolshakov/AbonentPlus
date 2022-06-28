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
    public partial class Form_Abonent : System.Windows.Forms.Form
    {
        private readonly MongoDBContext context;
        private BindingSource _bindList;
        public Form_Abonent()
        {
            InitializeComponent();
            context = MongoDBContext.GetObject();
            _bindList = new BindingSource();
            _bindList.Filter = "FlatNo";
            _bindList.DataSource = context.Load_Abonent();
            dataGridView.DataSource = _bindList;

            // формируем
            IList<string> vs = new List<string>();
            foreach (DataGridViewColumn item in dataGridView.Columns)
            {
                vs.Add(item.Name);
            }
            cb_Filters.DataSource = vs;
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Abonent abonent = (Abonent)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem;
            Form_Abonent_Edit edit = new Form_Abonent_Edit(abonent, context, false, _bindList);
            edit.ShowDialog();

            dataGridView.Refresh();
            Console.WriteLine();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            Form_Abonent_Edit add = new Form_Abonent_Edit(abonent, context, true, _bindList);
            add.ShowDialog();
            dataGridView.Refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Abonent abonent = (Abonent)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem;
            if (abonent != null)
            {
                DialogResult result = MessageBox.Show("Удалить абонента " + abonent.Fio + "?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _bindList.Remove(abonent);
                    context.Delete_Abonent_Infromation(abonent);
                }
            }
            else
            {
                MessageBox.Show("Выберите абонента");
            }

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
