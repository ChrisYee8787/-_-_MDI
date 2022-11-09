using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class ADDCALLER : Form
    {
        public ADDCALLER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            PatientInfo p = new PatientInfo();
            db.EmergenceCaller.Add(new EmergenceCaller
            {
                fEmergencyName = textBox1.Text,
                fPhone = textBox3.Text,
                frelation = textBox2.Text,
                fPatientId= Convert.ToInt32(textBox5.Text),
            });
                db.SaveChanges();
            MessageBox.Show("新增成功!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
