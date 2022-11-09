using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 康家_藥物疾病列表
{
    //Form MDImain = Application.OpenForms["frm_主表單"];
    //Frm_主表單 getMDI;
    // getMDI = (Frm_主表單)MDImain;
    //getMDI.openFrm_noMax(frm);
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_主表單());
        }
    }
}
