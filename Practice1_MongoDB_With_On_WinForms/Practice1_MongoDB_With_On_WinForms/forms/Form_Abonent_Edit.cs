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
    public partial class Form_Abonent_Edit : Form
    {
        private readonly Abonent _abonent;
        public Form_Abonent_Edit(Abonent abonent)
        {
            InitializeComponent();
            _abonent = abonent;
            tb_Fio.Text = abonent.Fio;
            tb_Flat.Text = Convert.ToString(abonent.FlatNo);
            tb_House.Text = Convert.ToString(abonent.HouseNo);
            tb_Street.Text = Convert.ToString(abonent.StreetCD);
            tb_Phone.Text = Convert.ToString(abonent.Phone);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

            }
        }
    }
}
