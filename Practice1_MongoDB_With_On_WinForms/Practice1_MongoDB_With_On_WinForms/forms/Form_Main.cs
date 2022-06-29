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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Form_Abonent_Click(object sender, EventArgs e)
        {
            Form_Abonent form_Abonent = new Form_Abonent();
            this.Hide();
            form_Abonent.ShowDialog();
            this.Show();
        }

        private void btn_Form_Disrepair_Click(object sender, EventArgs e)
        {
            Form_Disrepair form_Disrepair = new Form_Disrepair();
            this.Hide();
            form_Disrepair.ShowDialog();
            this.Show();
        }
    }
}
