using System;
using System.Windows.Forms;

namespace Practice1_MongoDB_With_On_WinForms.forms
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Form_Abonent_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_Abonent());
        }

        private void btn_Form_Disrepair_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_Disrepair());
        }

        private void btn_Form_Request_Click(object sender, EventArgs e)
        {
            ShowForm(new Form_Request());
        }

        private void ShowForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
