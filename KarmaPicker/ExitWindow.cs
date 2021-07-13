using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace KarmaPicker
{
    public partial class ExitWindow : UserControl
    {
        private static ExitWindow _instance;
        public static ExitWindow Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new ExitWindow();
                return _instance;
            }
        }

        public ExitWindow()
        {
            InitializeComponent();
        }
        SoundPlayer sound_load = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Swipe 01 1.wav");
        SoundPlayer sound_Slect = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Select_05 1.wav");
        SoundPlayer sound_Hover = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Scroll Sound 32 1.wav");
        

        private void ExitWindow_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }
    }
}
