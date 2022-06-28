using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_MongoDB_With_On_WinForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly MongoDBContext context;
        public Form()
        {
            InitializeComponent();
            context = MongoDBContext.GetObject();
        }
    }
}
