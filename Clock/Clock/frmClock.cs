using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        private DateTime dispDateTime = DateTime.Now;
        private readonly string DateFormat = "yyyy/MM/dd(ddd)";
        private readonly string TimeFormat = "HH:mm:ss";
        private readonly CultureInfo culture = CultureInfo.GetCultureInfo("en-US");
        private readonly Size SizeHasBorder = new Size(300, 120);
        private readonly Size SizeNotHasBorder = new Size(284, 80);

        public Clock()
        {
            InitializeComponent();

            this.Disp();
            this.ControlDispHide("Display");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.dispDateTime.Second != DateTime.Now.Second)
            {
                this.dispDateTime = DateTime.Now;
                this.Disp();
            }
        }

        private void Disp()
        {
            this.LbDate.Text = this.dispDateTime.ToString(this.DateFormat, culture);
            this.LbTime.Text = this.dispDateTime.ToString(this.TimeFormat);
        }

        private void Clock_MouseUp(object sender, MouseEventArgs e)
        {
            const int offset_X = 8;
            const int offset_Y = 31;

            if (e.Button == MouseButtons.Left)
            {
                if (this.FormBorderStyle == FormBorderStyle.FixedDialog)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.Size = SizeNotHasBorder;
                    this.SetDesktopLocation(this.DesktopLocation.X + offset_X, this.DesktopLocation.Y + offset_Y);
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    this.Size = SizeHasBorder;
                    this.SetDesktopLocation(this.DesktopLocation.X - offset_X, this.DesktopLocation.Y - offset_Y);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.ControlDispHide("Hide");
            }
        }

        private void MiDisplay_Click(object sender, EventArgs e)
        {
            this.ControlDispHide(this.MiDisplay.Text);
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            this.NotifyIcon.Dispose();
            Application.Exit();
        }

        private void ControlDispHide(string disp = "Display")
        {
            if (disp == "Display")
            {
                this.Show();
                this.MiDisplay.Text = "Hide";
            }
            else
            {
                this.Hide();
                this.MiDisplay.Text = "Display";
            }
        }
    }
}
