using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SmartPlugin.SmartChildForm
{
    public partial class AuthorizeTimeForm : Smart.Core.StandardForm
    {
        DateTime selecttime;
        ResourceManager _resc;
        
        public DateTime Selecttime
        {
            get { return selecttime; }
            set { selecttime = value; }
        }

        public AuthorizeTimeForm()
        {
            _resc = new ResourceManager(typeof(AuthorizeTimeForm));
            selecttime = DateTime.Now;
            InitializeComponent();
        }

        private void AuthorizeTimeForm_Load(object sender, EventArgs e)
        {
            this.Text = _resc.GetString("setauthorizetime");
            this.btn_OK.Text = _resc.GetString("enter");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.selecttime = this.dateTimePicker1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
