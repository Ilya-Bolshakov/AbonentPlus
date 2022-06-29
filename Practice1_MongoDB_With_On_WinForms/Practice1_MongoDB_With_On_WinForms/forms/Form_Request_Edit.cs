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
    public partial class Form_Request_Edit : Form
    {
        private Request _request;
        private readonly MongoDBContext _context;
        private BindingList<Request> _bindingList;
        bool _isCreate;
        public Form_Request_Edit(Request request, MongoDBContext context, bool create, BindingList<Request> binList)
        {
            InitializeComponent();
            _bindingList = binList;
            _isCreate = create;
            _context = context;
            _request = request;
            tb_ID.Text = _request.Id.ToString();
            tb_Account.Text = _request.AccountCD;
            tb_Executor.Text = _request.ExecutorCD;
            tb_Failure.Text = _request.FailureCD;
            dtp_ExecutionDate.Value = _request.ExecutionDate == default(DateTime) ? DateTime.Now : _request.ExecutionDate;  
            dtp_IncomingDate.Value = _request.IncomingDate == default(DateTime) ? DateTime.Now : _request.IncomingDate;
            cb_isExecuted.Checked = _request.Executed;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Request_Edit_Load(object sender, EventArgs e)
        {
            label_ID.Visible = tb_ID.Visible = _isCreate;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                EditRequest(_request);
                if (_isCreate)
                {
                    _bindingList.Add(_request);
                    _context.Insert_Request_Information(_request);
                    this.Close();
                }
                else
                {
                    _context.Update_Request_Information(_request);
                    this.Close();
                }
            }
        }

        private void EditRequest(Request request)
        {
            request.Id = Convert.ToInt32(tb_ID.Text);
            request.AccountCD = tb_Account.Text;
            request.ExecutorCD = tb_Executor.Text;
            request.FailureCD = tb_Failure.Text;
            request.ExecutionDate = dtp_ExecutionDate.Value;
            request.IncomingDate = dtp_IncomingDate.Value;
            request.Executed = cb_isExecuted.Checked;
        }
    }
}
