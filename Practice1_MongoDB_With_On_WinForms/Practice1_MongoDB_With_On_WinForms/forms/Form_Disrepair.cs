using Practice1_MongoDB_With_On_WinForms.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //формируем список атрибутов для фильтрации
            IList<string> vs = new List<string>();
            foreach (DataGridViewColumn item in dataGridView.Columns)
            {
                vs.Add(item.HeaderText);
            }
            cb_Filters.DataSource = vs;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Disrepair disrepair = new Disrepair();
            Form_Disrepair_Edit add = new Form_Disrepair_Edit(disrepair, context, true, _bindList);
            add.ShowDialog();
            dataGridView.Refresh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Disrepair disrepair = (Disrepair)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem;
            if (disrepair != null)
            {
                DialogResult result = MessageBox.Show($"Удалить поломку № {disrepair.Id} ?",
                    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _bindList.Remove(disrepair);
                    context.Delete_Disrepair_Infromation(disrepair);
                }
            }
            else
            {
                MessageBox.Show("Выберите поломку");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Disrepair disrepair = (Disrepair)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem;
            Form_Disrepair_Edit edit = new Form_Disrepair_Edit(disrepair, context, false, _bindList);
            edit.ShowDialog();

            dataGridView.Refresh();
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
