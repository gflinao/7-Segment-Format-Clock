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
        int Tick = 0;
        string mytime = "a";

        public ClckSgmnt()
        {
            InitializeComponent();
        }

        private void ClckSgmnt_Load(object sender, EventArgs e)
        {

        }

        private void Timerfnc_Tick(object sender, EventArgs e)
        {
            Tick++;
            string Secs = (DateTime.Now.ToString("ss"));
            rightsec = Convert.ToInt32(Secs.Substring(Secs.Length - 1));
            SecRght(rightsec);
            leftsec = Convert.ToInt32(Secs.Substring(0, 1));
            SecLft(leftsec);
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
        private string mytime5()
        {
            return "this";
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

        private void BtnTClick(object sender, EventArgs e)
        {
            Button TClick = (Button)sender;
            TClick.BackColor = System.Drawing.Color.Black;
        }
    }
}
