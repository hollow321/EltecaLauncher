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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 700)
            {
                SoundPlayer sound_StartUp = new SoundPlayer(@"C:\Users\hollow321\source\repos\KarmaPicker\KarmaPicker\Material\SFX\GUI_Notification 13 1.wav");
                sound_StartUp.Play();
                timer1.Stop();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if(panel2.Width <= 40)
            {
                SoundPlayer sound_NowLoading = new SoundPlayer(@"C:/Users/hollow321/source/repos/KarmaPicker/KarmaPicker/Material/SFX/GUI_Notification 02 1.wav");
                sound_NowLoading.Play();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
