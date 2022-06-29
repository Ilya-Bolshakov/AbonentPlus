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
        public Form_Abonent_Edit(Abonent abonent, MongoDBContext context, bool create, BindingList<Abonent> binList)
        {
            InitializeComponent();
            _bindingList = binList;
            _isCreate = create;
            _context = context;
            _abonent = abonent;
            tb_ID.Text = abonent.Id;
            tb_Fio.Text = abonent.Fio;
            tb_Flat.Text = Convert.ToString(abonent.FlatNo);
            tb_House.Text = Convert.ToString(abonent.HouseNo);
            tb_Street.Text = abonent.StreetCD;
            tb_Phone.Text = abonent.Phone;
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
                    this.Close();
                }
                else
                {
                    _context.Update_Abonent_Information(_abonent);
                    this.Close();
                }
            }
            
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

        private void tb_ID_Validating(object sender, CancelEventArgs e)
        {
            if (_isCreate)
            {
                var abonents = _context.Load_Abonent();
                if (abonents.Any(a => a.Id == tb_ID.Text))
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

        private void tb_Phone_Validating(object sender, CancelEventArgs e)
        {
            if (!tb_Phone.Text.All(c => char.IsDigit(c)))
            {
                errorProvider.SetError(tb_Phone, "В телефоне не могут присутстовать символы кроме цифр");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Phone, String.Empty);
                e.Cancel = false;
            }
        }

        private void tb_Street_Validating(object sender, CancelEventArgs e)
        {
            if (!tb_Street.Text.All(c => char.IsLetter(c) || c.Equals(' ')))
            {
                errorProvider.SetError(tb_Street, "В адресе не могут присутстовать символы кроме цифр или букв");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Street, String.Empty);
                e.Cancel = false;
            }
        }

        private void tb_House_Validating(object sender, CancelEventArgs e)
        {
            if (!tb_House.Text.All(c => char.IsDigit(c)))
            {
                errorProvider.SetError(tb_House, "В номере дома не могут присутстовать символы кроме цифр");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_House, String.Empty);
                e.Cancel = false;
            }
        }

        private void tb_Flat_Validating(object sender, CancelEventArgs e)
        {
            if (!tb_Flat.Text.All(c => char.IsDigit(c)))
            {
                errorProvider.SetError(tb_Flat, "В номере этажа не могут присутстовать символы кроме цифр");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Flat, String.Empty);
                e.Cancel = false;
            }
        }

        private void tb_Fio_Validating(object sender, CancelEventArgs e)
        {
            if (!tb_Fio.Text.All(c => char.IsLetter(c) || c.Equals('.') || c.Equals(' ')))
            {
                errorProvider.SetError(tb_Fio, "В фио могут быть только буквы и символ '.'");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tb_Fio, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
