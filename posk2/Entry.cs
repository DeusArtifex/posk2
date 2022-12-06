using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posk2
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;
            if (btnName == "btnHear")
            {
                var newForm = new Hearing();
                newForm.Show();
            }
            else {
                var newForm = new Vision();
                newForm.Show();
            }
        }
    }
}
