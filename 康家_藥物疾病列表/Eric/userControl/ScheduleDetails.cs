using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehabilitationForm.CustomComponents
{
    public partial class ScheduleDetails : UserControl
    {
        bool theStartMoved = false;
        Point thePrevioueLocation = new Point(0, 0);
        public ScheduleDetails()
        {
            InitializeComponent();

            //this.MouseDown += TheExtendedButton_MouseDown;
            //this.MouseMove += TheExtendedButton_MouseMove;
            //this.MouseUp += TheExtendedButton_MouseUp;

        }

        private void TheExtendedButton_MouseUp(object sender, MouseEventArgs e)
        {
            theStartMoved = false;
        }

        private void TheExtendedButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (theStartMoved)            
            {
                Point theCurrentLocation = this.PointToScreen(e.Location);
                
                Point difference = new Point(
                     theCurrentLocation.X - thePrevioueLocation.X 
                     , theCurrentLocation.Y - thePrevioueLocation.Y
                    );
               
                Point newPoint = new Point(this.Location.X + difference.X, this.Location.Y + difference.Y);
            
                if (newPoint.X < 0
                    || newPoint.Y < 0
                    || newPoint.X + Width >= this.Parent.ClientSize.Width
                    || newPoint.Y + Height >= this.Parent.ClientSize.Height) { return; }
                else { this.Location = newPoint; }
               
                thePrevioueLocation = theCurrentLocation;
            }
        }

        private void TheExtendedButton_MouseDown(object sender, MouseEventArgs e)
        {
            thePrevioueLocation = this.PointToScreen(e.Location);
            theStartMoved = true;
        }

        private void ScheduleDetails_Load(object sender, EventArgs e)
        {
         
                //Convert.ToInt32(dtp_scheduleStart.Text) - Convert.ToInt32(dtp_scheduleEnd.Text);
        }

        private void dtp_scheduleStart_ValueChanged(object sender, EventArgs e)
        {
            tbx_scheduleCost.Text = dtp_scheduleEnd.Value.Subtract(dtp_scheduleStart.Value).ToString();
            //tbx_scheduleCost.Text = Convert.ToDateTime(dtp_scheduleEnd.Text).Subtract(Convert.ToDateTime(dtp_scheduleStart.Text)).ToString();
            if (tbx_scheduleCost.Text[0] == '-') { tbx_scheduleCost.Text = "起始大於結束";  }
        }

        private void dtp_scheduleEnd_ValueChanged(object sender, EventArgs e)
        {


            tbx_scheduleCost.Text = dtp_scheduleEnd.Value.Subtract(dtp_scheduleStart.Value).ToString();
            //tbx_scheduleCost.Text = Convert.ToDateTime(dtp_scheduleEnd.Text).Subtract(Convert.ToDateTime(dtp_scheduleStart.Text)).ToString();
            if (tbx_scheduleCost.Text[0] == '-') { tbx_scheduleCost.Text = "起始大於結束";  }
        }
    }
}
