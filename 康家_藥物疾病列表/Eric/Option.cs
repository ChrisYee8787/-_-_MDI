using RehabilitationForm.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehabilitationForm
{
    public  partial class Option : Form
    {
       

        public Option()
        {
            InitializeComponent();
            if (classForStatic.comboboxWheel == "1") checkBoxMouseWheel.Checked = true;
        }

        private void comform_Click(object sender, EventArgs e)
        {
            if (checkBoxMouseWheel.Checked)
                classForStatic.comboboxWheel = "1";
            else
                classForStatic.comboboxWheel = "0";
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
