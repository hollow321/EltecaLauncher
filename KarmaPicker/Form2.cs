using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;


namespace KarmaPicker
{
    public partial class Form2 : Form
    {
        SoundPlayer sound_Slect = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Select_05 1.wav");
        SoundPlayer sound_Hover = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Scroll Sound 32 1.wav");
        SoundPlayer sound_Exit = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Swipe 01 1.wav");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnDashbord.Height;
            PnlNav.Top = BtnDashbord.Top;
            PnlNav.Left = BtnDashbord.Left;
            BtnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //クリックイベント開始
        private void BtnDashbord_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashbord.Height;
            PnlNav.Top = BtnDashbord.Top;
            PnlNav.Left = BtnDashbord.Left;
            BtnDashbord.BackColor = Color.FromArgb(46,51,73);
            sound_Slect.Play();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalytics.Height;
            PnlNav.Top = BtnAnalytics.Top;
            PnlNav.Left = BtnAnalytics.Left;
            BtnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
            sound_Slect.Play();
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnCustom.Height;
            PnlNav.Top = BtnCustom.Top;
            PnlNav.Left = BtnCustom.Left;
            BtnCustom.BackColor = Color.FromArgb(46, 51, 73);
            sound_Slect.Play();
        }

        private void BtnKarmaPicker_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnKarmaPicker.Height;
            PnlNav.Top = BtnKarmaPicker.Top;
            PnlNav.Left = BtnKarmaPicker.Left;
            BtnKarmaPicker.BackColor = Color.FromArgb(46, 51, 73);
            sound_Slect.Play();

            if (!PnlContainer.Controls.Contains(Ucp_RandomKarmaPicker.Instance))
            {
                PnlContainer.Controls.Add(Ucp_RandomKarmaPicker.Instance);
                Ucp_RandomKarmaPicker.Instance.Dock = DockStyle.Fill;
                Ucp_RandomKarmaPicker.Instance.BringToFront();
            }
            else
            {
                Ucp_RandomKarmaPicker.Instance.BringToFront();
            }

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            PnlNav.Left = BtnSettings.Left;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);
            sound_Slect.Play();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnExit.Height;
            PnlNav.Top = BtnExit.Top;
            PnlNav.Left = BtnExit.Left;
            BtnExit.BackColor = Color.FromArgb(46, 51, 73);

            if (!PnlContainer.Controls.Contains(ExitWindow.Instance))
            {
                PnlContainer.Controls.Add(ExitWindow.Instance);
                ExitWindow.Instance.Dock = DockStyle.Fill;
                ExitWindow.Instance.BringToFront();
            }
            else
            {
                ExitWindow.Instance.BringToFront();
            }
            sound_Exit.Play();
            
        }
        //クリックイベント

        //クリックから別のを選択したら
        private void BtnDashbord_Leave(object sender, EventArgs e)
        {
            BtnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCustom_Leave(object sender, EventArgs e)
        {
            BtnCustom.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnKarmaPicker_Leave(object sender, EventArgs e)
        {
            BtnKarmaPicker.BackColor = Color.FromArgb(24, 30, 54); 
        }

        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnExit_Leave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.FromArgb(24, 30, 54);
        }
        //クリックから別のを選択したら

        //マウスホバー
        private void BtnDashbord_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void BtnAnalytics_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void BtnCustom_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void BtnKarmaPicker_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void BtnSettings_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
        }

        private void PnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        //マウスホバー
    }
}
