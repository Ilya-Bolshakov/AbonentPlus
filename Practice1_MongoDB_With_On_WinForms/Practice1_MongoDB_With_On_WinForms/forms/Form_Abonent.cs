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
        public Form_Abonent()
        {
            InitializeComponent();
            BindingSource binding = new BindingSource();
            context = MongoDBContext.GetObject();
            dataGridView.DataSource = context.Load_Abonent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_Abonent_Edit edit = new Form_Abonent_Edit((Abonent)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem);
            edit.ShowDialog();
        }
    }
}
