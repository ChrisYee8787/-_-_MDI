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
    public partial class UPDATECALLER : Form
    {

        public int aa;
        public UPDATECALLER()
        {
            InitializeComponent();
        }

        private void UPDATECALLER_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmergyCaller c = new EmergyCaller();
            dbClassEntities db = new dbClassEntities();
            var Q = from caller in db.EmergenceCaller
                    where caller.fid == aa
                    select caller;
            foreach (var caller in Q)
            {
                caller.fEmergencyName = textBox1.Text;
                caller.frelation = textBox2.Text;
                caller.fPhone = textBox3.Text;
            }
            db.SaveChanges();
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}

