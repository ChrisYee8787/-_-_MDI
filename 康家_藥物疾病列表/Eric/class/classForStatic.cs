using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RehabilitationForm.utility
{
    internal class classForStatic
    {
        public static MouseEventHandler meh = new MouseEventHandler((_, __) => { ((HandledMouseEventArgs)__).Handled = true; });
        public static string comboboxWheel;
        public static int staffID = 1;
    }
}
