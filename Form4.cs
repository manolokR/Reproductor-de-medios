using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing.Drawing2D;
namespace Reproductor_Medios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        
            axWindowsMediaPlayer1.uiMode = "none";
            slider.Height = 30;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Elige el video que quieras :)";
            openFileDialog1.Filter = "Archivos MP4|*.mp4";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        float valores_default = 0.1f, Min = 0.0f, Max = 1.0f;

        public float Bar(float value) {

            return (slider.Width - 24) * (value - Min) / (float)(Max - Min);
        
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.3f;
            float x = Bar(valores_default);
            int y = (int)(slider.Height * bar_size);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, 0, y, slider.Width-7, y / 2);
            e.Graphics.FillRectangle(Brushes.DarkRed, 0, y, x, slider.Height - 30);
            using (Pen pen = new Pen(Color.FromArgb(235,5, 75), 8)) {

                e.Graphics.DrawEllipse(pen, x + 4, y - 2, slider.Height / 4, slider.Height / 4);
            }

        }

        bool mouse = false;


        public void thumb(float value)
        {

            if (value < Min) value = Min;
            if (value > Max) value = Max;
            valores_default = value;
            slider.Refresh();
        }
        public float slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(slider.Width);
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(slider_width(e.X));
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / slider.Width;


        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            thumb(slider_width(e.X));
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / slider.Width;

        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying) {
                Max = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                valores_default = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                slider.Invalidate();
                lbl_start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                lbl_end.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

       
       


       
    }
}
