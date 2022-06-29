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
    public partial class Form_Disrepair_Edit : Form
    {
        private Disrepair _disrepair;
        private readonly MongoDBContext _context;
        private BindingList<Disrepair> _bindingList;
        bool _isCreate;
        public Form_Disrepair_Edit(Disrepair disrepair, MongoDBContext context, bool create, BindingList<Disrepair> binList)
        {
            InitializeComponent();
            _bindingList = binList;
            _isCreate = create;
            _context = context;
            _disrepair = disrepair;
            tb_ID.Text = disrepair.Id.ToString();
            tb_Failernm.Text = disrepair.FAILURENM;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                EditDisrepair(_disrepair);
                if (_isCreate)
                {
                    _bindingList.Add(_disrepair);
                    _context.Insert_Disrepair_Information(_disrepair);
                    this.Close();
                }
                else
                {
                    _context.Update_Disrepair_Information(_disrepair);
                    this.Close();
                }
            }
        }

        private void EditDisrepair(Disrepair disrepair)
        {
            disrepair.Id = Convert.ToInt32(tb_ID.Text);
            disrepair.FAILURENM = tb_Failernm.Text;
        }

        private void Form_Disrepair_Edit_Load(object sender, EventArgs e)
        {
            label_ID.Visible = tb_ID.Visible = _isCreate;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_ID_Validating(object sender, CancelEventArgs e)
        {
            if (_isCreate)
            {
                var disrepairs = _context.Load_DataDisrepair();
                if (disrepairs.Any(a => a.Id == Convert.ToInt32(tb_ID.Text)))
                {
                    errorProvider.SetError(tb_ID, "Такое значение поля ID уже присутствует!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(tb_ID, String.Empty);
                    e.Cancel = false;
                }
            }
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Failernm_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Failernm.Text == String.Empty)
            {
                errorProvider.SetError(tb_Failernm, "Поле не может быть пустым");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Failernm, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
