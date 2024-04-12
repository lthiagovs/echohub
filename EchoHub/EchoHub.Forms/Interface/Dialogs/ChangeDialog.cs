using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
namespace EchoHub.Forms.Interface.Dialogs
{
    public partial class ChangeDialog : Form
    {
        public ChangeDialog(string baseText)
        {
            InitializeComponent();
            this.txtChange.Text = baseText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
