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
        private Abonent _abonent;
        private readonly MongoDBContext _context;
        private BindingList<Abonent> _bindingList;
        bool _isCreate;
        public Form_Abonent_Edit(Abonent abonent, MongoDBContext context, bool create, BindingSource binList)
        {
            InitializeComponent();
            //_bindingList = binList;
            _isCreate = create;
            _context = context;
            _abonent = abonent;
            tb_ID.Text = abonent.Id;
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
                EditAbonent(_abonent);
                if (_isCreate)
                {
                    _bindingList.Add(_abonent);
                    _context.Insert_Abonent_Information(_abonent);
                }
                else
                {
                    _context.Update_Abonent_Information(_abonent);
                }
            }
            this.Close();
        }

        private void EditAbonent(Abonent abonent)
        {
            abonent.Id = tb_ID.Text;
            abonent.Fio = tb_Fio.Text;
            abonent.FlatNo = Convert.ToInt32(tb_Flat.Text);
            abonent.StreetCD = tb_Street.Text;
            abonent.HouseNo = Convert.ToInt32(tb_House.Text);
            abonent.Phone = tb_Phone.Text;
        }

        private void Form_Abonent_Edit_Load(object sender, EventArgs e)
        {
            label_ID.Visible = tb_ID.Visible = _isCreate;
        }
    }
}
