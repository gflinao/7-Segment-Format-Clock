using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Segment_Format_Clock
{
    public partial class ClckSgmnt : Form
    {

        int rightsec = 0;
        int leftsec = 0;
        int rightmin = 0;
        int leftmin = 0;
        int righthr = 0;
        int lefthr = 0;
        int Tick = 0;
        string mytime = "a";

        public ClckSgmnt()
        {
            InitializeComponent();

            lblAMPM.Text = DateTime.Now.ToString("tt");
            lblMDY.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");

        }

        bool blink_on = false;
        private void ClckSgmnt_Load(object sender, EventArgs e)
        {
            Tick++;
            label1.Visible = false;
            string Secs = DateTime.Now.ToString("ss");
            leftsec = Convert.ToInt32(Secs.Substring(0, 1));
            if (leftsec == 1 || leftsec == 0)
            {

            }
            else
            {
                MessageBox.Show("Error, please run again at 0 or 1 sec");

                this.Close();
            }

        }

        private void Timerfnc_Tick(object sender, EventArgs e)
        {
            Tick++;
            string Secs = (DateTime.Now.ToString("ss"));
            rightsec = Convert.ToInt32(Secs.Substring(Secs.Length - 1));
            SecRght(rightsec);
            leftsec = Convert.ToInt32(Secs.Substring(0, 1));
            SecLft(leftsec);

            string Mins = (DateTime.Now.ToString("mm"));
            rightmin = Convert.ToInt32(Mins.Substring(Mins.Length - 1));
            MinRght(rightmin);
            leftmin = Convert.ToInt32(Mins.Substring(0, 1));
            MinLft(leftmin);

            string Hrs = (DateTime.Now.ToString("hh"));
            righthr = Convert.ToInt32(Hrs.Substring(Hrs.Length - 1));
            HourRght(righthr);
            lefthr = Convert.ToInt32(Hrs.Substring(0, 1));
            HourLft(lefthr);
        }
        private string mytime1()
        {
            return "is";
        }
        private void trans(Button args)
        {
            args.BackColor = Color.Transparent;
        }

        private void BLACKED(Button args)
        {
            args.BackColor = Color.Black;
        }

        private void SecRght(int tRsec)
        {
            if (tRsec == 1)
            {
                BtnRSec1.BackColor = System.Drawing.Color.Transparent;
                BtnRSec2.BackColor = System.Drawing.Color.Transparent;
                BtnRSec4.BackColor = System.Drawing.Color.Transparent;
                BtnRSec5.BackColor = System.Drawing.Color.Transparent;
                BtnRSec7.BackColor = System.Drawing.Color.Transparent;

                BLACKED(BtnRSec3);
                BLACKED(BtnRSec6);

            }
            else if (tRsec == 2)
            {
                BLACKED(BtnRSec1);
                BLACKED(BtnRSec3);
                BLACKED(BtnRSec4);
                BLACKED(BtnRSec5);
                BLACKED(BtnRSec7);

                BtnRSec6.BackColor = System.Drawing.Color.Transparent;
                BtnRSec2.BackColor = Color.Transparent;
            }
            else if (tRsec == 3)
            {
                BLACKED(BtnRSec1);
                BLACKED(BtnRSec3);
                BLACKED(BtnRSec6);
                BLACKED(BtnRSec7);
                BLACKED(BtnRSec4);


                BtnRSec5.BackColor = System.Drawing.Color.Transparent;
                BtnRSec2.BackColor = Color.Transparent;
            }
            else if (tRsec == 4)
            {
                BLACKED(BtnRSec3);
                BLACKED(BtnRSec6);
                BLACKED(BtnRSec2);
                BLACKED(BtnRSec4);

                BtnRSec1.BackColor = System.Drawing.Color.Transparent;
                BtnRSec7.BackColor = System.Drawing.Color.Transparent;
                BtnRSec5.BackColor = Color.Transparent;
            }
            else if (tRsec == 5)
            {
                BLACKED(BtnRSec1);
                BLACKED(BtnRSec6);
                BLACKED(BtnRSec7);
                BLACKED(BtnRSec2);
                BLACKED(BtnRSec4);
                trans(BtnRSec3);
                trans(BtnRSec5);


            }
            else if (tRsec == 6)
            {
                BLACKED(BtnRSec1);
                BLACKED(BtnRSec6);
                BLACKED(BtnRSec7);
                BLACKED(BtnRSec5);
                BLACKED(BtnRSec2);
                BLACKED(BtnRSec4);

                trans(BtnRSec3);
            }

            else if (tRsec == 7)
            {

                BtnRSec1.PerformClick();
                BtnRSec3.PerformClick();
                BtnRSec6.PerformClick();

                BtnRSec7.BackColor = System.Drawing.Color.Transparent;
                BtnRSec5.BackColor = System.Drawing.Color.Transparent;
                BtnRSec2.BackColor = System.Drawing.Color.Transparent;
                BtnRSec4.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRsec == 8)
            {
                BtnRSec1.PerformClick();
                BtnRSec6.PerformClick();
                BtnRSec7.PerformClick();
                BtnRSec5.PerformClick();
                BtnRSec2.PerformClick();
                BtnRSec4.PerformClick();
                BtnRSec3.PerformClick();
            }
            else if (tRsec == 9)
            {
                BtnRSec1.PerformClick();
                BtnRSec3.PerformClick();
                BtnRSec6.PerformClick();
                BtnRSec7.PerformClick();
                BtnRSec2.PerformClick();
                BtnRSec4.PerformClick();

                trans(BtnRSec5);
            }
            else
            {
                BtnRSec1.PerformClick();
                BtnRSec6.PerformClick();
                BtnRSec7.PerformClick();
                BtnRSec5.PerformClick();
                BtnRSec2.PerformClick();
                BtnRSec3.PerformClick();

                trans(BtnRSec4);
            }

        }

        private void SecLft(int tLsec)
        {
            if (tLsec == 1)
            {
                BLACKED(BtnLSec3);
                BLACKED(BtnLSec6);

                BtnLSec1.BackColor = System.Drawing.Color.Transparent;
                BtnLSec2.BackColor = System.Drawing.Color.Transparent;
                BtnLSec4.BackColor = System.Drawing.Color.Transparent;
                BtnLSec5.BackColor = System.Drawing.Color.Transparent;
                BtnLSec7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLsec == 2)
            {

                BLACKED(BtnLSec1);
                BLACKED(BtnLSec3);
                BLACKED(BtnLSec4);
                BLACKED(BtnLSec5);
                BLACKED(BtnLSec7);

                BtnLSec6.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLsec == 3)
            {
                BLACKED(BtnLSec1);
                BLACKED(BtnLSec3);
                BLACKED(BtnLSec6);
                BLACKED(BtnLSec7);
                trans(BtnLSec2);

                BtnLSec5.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLsec == 4)
            {
                BLACKED(BtnLSec3);
                BLACKED(BtnLSec6);
                BLACKED(BtnLSec2);
                BLACKED(BtnLSec4);

                BtnLSec1.BackColor = System.Drawing.Color.Transparent;
                BtnLSec7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLsec == 5)
            {
                BLACKED(BtnLSec1);
                BLACKED(BtnLSec6);
                BLACKED(BtnLSec7);
                BLACKED(BtnLSec2);
                BLACKED(BtnLSec4);

                trans(BtnLSec3);
                trans(BtnLSec5);
            }
            else
            {
                BLACKED(BtnLSec1);
                BLACKED(BtnLSec6);
                BLACKED(BtnLSec7);
                BLACKED(BtnLSec5);
                BLACKED(BtnLSec2);
                BLACKED(BtnLSec3);

                BtnLSec4.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void MinRght(int tRmin)
        {
            if (tRmin == 1)
            {
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin6);

                BtnRMin1.BackColor = System.Drawing.Color.Transparent;
                BtnRMin2.BackColor = System.Drawing.Color.Transparent;
                BtnRMin4.BackColor = System.Drawing.Color.Transparent;
                BtnRMin5.BackColor = System.Drawing.Color.Transparent;
                BtnRMin7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 2)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin4);
                BLACKED(BtnRMin5);
                BLACKED(BtnRMin7);

                trans(BtnRMin2);
                BtnRMin6.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 3)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
                BLACKED(BtnRMin4);

                trans(BtnRMin2);
                BtnRMin5.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 4)
            {
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin4);

                BtnRMin1.BackColor = System.Drawing.Color.Transparent;
                trans(BtnRMin5);
                BtnRMin7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 5)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin4);

                trans(BtnRMin5);
                BtnRMin3.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 6)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
                BLACKED(BtnRMin5);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin4);

                trans(BtnRMin3);
            }

            else if (tRmin == 7)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin6);

                BtnRMin7.BackColor = System.Drawing.Color.Transparent;
                BtnRMin5.BackColor = System.Drawing.Color.Transparent;
                BtnRMin2.BackColor = System.Drawing.Color.Transparent;
                BtnRMin4.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tRmin == 8)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin4);
                BLACKED(BtnRMin5);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
            }
            else if (tRmin == 9)
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin3);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin4);
                trans(BtnRMin5);
            }
            else
            {
                BLACKED(BtnRMin1);
                BLACKED(BtnRMin6);
                BLACKED(BtnRMin7);
                BLACKED(BtnRMin5);
                BLACKED(BtnRMin2);
                BLACKED(BtnRMin3);

                BtnRMin4.BackColor = System.Drawing.Color.Transparent;
            }

        }

        private void MinLft(int tLmin)
        {
            if (tLmin == 1)
            {
                BLACKED(BtnLMin3);
                BLACKED(BtnLMin6);

                BtnLMin1.BackColor = System.Drawing.Color.Transparent;
                BtnLMin2.BackColor = System.Drawing.Color.Transparent;
                BtnLMin4.BackColor = System.Drawing.Color.Transparent;
                BtnLMin5.BackColor = System.Drawing.Color.Transparent;
                BtnLMin7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLmin == 2)
            {
                BLACKED(BtnLMin1);
                BLACKED(BtnLMin3);
                BLACKED(BtnLMin4);
                BLACKED(BtnLMin5);
                BLACKED(BtnLMin7);

                trans(BtnLMin2);
                BtnLMin6.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLmin == 3)
            {
                BLACKED(BtnLMin1);
                BLACKED(BtnLMin3);
                BLACKED(BtnLMin6);
                BLACKED(BtnLMin7);
                BLACKED(BtnLMin4);

                trans(BtnLMin2);
                BtnLMin5.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLmin == 4)
            {
                BLACKED(BtnLMin3);
                BLACKED(BtnLMin6);
                BLACKED(BtnLMin2);
                BLACKED(BtnLMin4);

                BtnLMin1.BackColor = System.Drawing.Color.Transparent;
                trans(BtnLMin5);
                BtnLMin7.BackColor = System.Drawing.Color.Transparent;
            }
            else if (tLmin == 5)
            {
                BLACKED(BtnLMin1);
                BLACKED(BtnLMin6);
                BLACKED(BtnLMin7);
                BLACKED(BtnLMin2);
                BLACKED(BtnLMin4);

                trans(BtnLMin5);
                BtnLMin3.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                BLACKED(BtnLMin1);
                BLACKED(BtnLMin6);
                BLACKED(BtnLMin7);
                BLACKED(BtnLMin5);
                BLACKED(BtnLMin2);
                BLACKED(BtnLMin3);

                BtnLMin4.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void HourRght(int tRhrs)
        {
            if (tRhrs == 1)
            {
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs6);

                trans(BtnRHrs1);
                trans(BtnRHrs2);
                trans(BtnRHrs4);
                trans(BtnRHrs5);
                trans(BtnRHrs7);
            }
            else if (tRhrs == 2)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs4);
                BLACKED(BtnRHrs5);
                BLACKED(BtnRHrs7);

                trans(BtnRHrs2);
                trans(BtnRHrs6);
            }
            else if (tRhrs == 3)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);
                BLACKED(BtnRHrs4);

                trans(BtnRHrs2);
                trans(BtnRHrs5);
            }
            else if (tRhrs == 4)
            {
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs4);

                trans(BtnRHrs1);
                trans(BtnRHrs5);
                trans(BtnRHrs7);
            }
            else if (tRhrs == 5)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs4);

                trans(BtnRHrs5);
                trans(BtnRHrs3);
            }
            else if (tRhrs == 6)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs4);
                BLACKED(BtnRHrs5);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);

                trans(BtnRHrs3);
            }

            else if (tRhrs == 7)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs6);

                trans(BtnRHrs5);
                trans(BtnRHrs7);
                trans(BtnRHrs2);
                trans(BtnRHrs4);
            }
            else if (tRhrs == 8)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs4);
                BLACKED(BtnRHrs5);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);
            }
            else if (tRhrs == 9)
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs4);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);
                trans(BtnRHrs5);
            }
            else
            {
                BLACKED(BtnRHrs1);
                BLACKED(BtnRHrs2);
                BLACKED(BtnRHrs3);
                BLACKED(BtnRHrs5);
                BLACKED(BtnRHrs6);
                BLACKED(BtnRHrs7);

                trans(BtnRHrs4);
            }
        }

        private void HourLft(int tLhrs)
        {
            if (tLhrs == 0)
            {
                BLACKED(BtnLHrs1);
                BLACKED(BtnLHrs6);
                BLACKED(BtnLHrs7);
                BLACKED(BtnLHrs5);
                BLACKED(BtnLHrs2);
                BLACKED(BtnLHrs3);

                trans(BtnLHrs4);
            }
            else if (tLhrs == 1)
            {
                BLACKED(BtnLHrs3);
                BLACKED(BtnLHrs6);

                trans(BtnLHrs1);
                trans(BtnLHrs2);
                trans(BtnLHrs4);
                trans(BtnLHrs5);
                trans(BtnLHrs7);
            }
            else if (tLhrs == 2)
            {
                BLACKED(BtnLHrs1);
                BLACKED(BtnLHrs3);
                BLACKED(BtnLHrs4);
                BLACKED(BtnLHrs5);
                BLACKED(BtnLHrs7);

                trans(BtnLHrs6);
                trans(BtnLHrs2);
            }
            else if (tLhrs == 3)
            {
                BLACKED(BtnLHrs1);
                BLACKED(BtnLHrs3);
                BLACKED(BtnLHrs6);
                BLACKED(BtnLHrs7);
                BLACKED(BtnLHrs4);

                trans(BtnLHrs2);
                trans(BtnLHrs5);
            }
            else if (tLhrs == 4)
            {
                BLACKED(BtnLHrs3);
                BLACKED(BtnLHrs6);
                BLACKED(BtnLHrs2);
                BLACKED(BtnLHrs4);

                trans(BtnLHrs1);
                trans(BtnLHrs5);
                trans(BtnLHrs7);
            }
            else
            {
                BLACKED(BtnLHrs1);
                BLACKED(BtnLHrs6);
                BLACKED(BtnLHrs7);
                BLACKED(BtnLHrs2);
                BLACKED(BtnLMin4);

                trans(BtnLHrs5);
                trans(BtnLHrs3);
            }
        }
    

        private void BtnTClick(object sender, EventArgs e)
        {
            Button TClick = (Button)sender;
            TClick.BackColor = System.Drawing.Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
