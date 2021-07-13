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
using System.Diagnostics;

namespace KarmaPicker
{
    public partial class Ucp_RandomKarmaPicker : UserControl
    {

        SoundPlayer sound_Slect = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Notification 07 1.wav");
        SoundPlayer sound_Hover = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Scroll Sound 32 1.wav");

        private static Ucp_RandomKarmaPicker _instance;
        public static Ucp_RandomKarmaPicker Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Ucp_RandomKarmaPicker();
                return _instance;
            }
        }
        public Ucp_RandomKarmaPicker()
        {
            InitializeComponent();
        }

        private void Ucp_RandomKarmaPicker_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            sound_Slect.Play();
            Dice();
        }

        private void Btn_Start_Leave(object sender, EventArgs e)
        {

        }

        private void Btn_Start_MouseHover(object sender, EventArgs e)
        {
            sound_Hover.Play();
        }

        private void Dice()
        {
            Random dice = new Random();
            int breaker = dice.Next(1,5) , 
                slayer = dice.Next(1, 6);
            Debug.WriteLine(breaker + "\n"+ slayer);

        }
    }
}
