using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing.Drawing2D;
namespace Reproductor_Medios
{
    public partial class Form2 : Form
    {
        private PanelLateral form1Instance;
        public Form2()
        {
       
            InitializeComponent();
            trackBar1.Value = 50;
            axWindowsMediaPlayer1.uiMode = "none";
            slider.Height = 30;
        }

        WindowsMediaPlayer sonido;

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String[] paths, files;
        String urlSonido;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
     
            openFileDialog1.Title = "Elige la canción que quieras :)";
            openFileDialog1.Filter = "Archivos MP3|*.mp3";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                files = openFileDialog1.FileNames;
                paths = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++) { 
                
                    track_list.Items.Add(files[i]);
                }



            }
        }

       

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BotonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                sonido = new WindowsMediaPlayer();
                sonido.URL = urlSonido;
                sonido.controls.play();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
                
            }
        }

        public void PauseMusic() {
            sonido = new WindowsMediaPlayer();
            sonido.controls.pause();
            
        }

        public void ResumeMusic()
        {

            sonido = new WindowsMediaPlayer();
            sonido.controls.play();

        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void slider_Click(object sender, EventArgs e)
        {

        }

        private void lbl_end_Click(object sender, EventArgs e)
        {

        }

        private void lbl_start_Click(object sender, EventArgs e)
        {

        }
        bool reproduciendo = false;
       
        private void track_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();

            string basePath = Environment.CurrentDirectory;
            string imagePath = Path.Combine(basePath, (@"..\..\tutorial UI V icons\pausemini.png"));
            pictureBox1.Image = Image.FromFile(imagePath);

            reproduciendo = true;
            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    miniatura.Image = Image.FromStream(new MemoryStream(bin));
                }
                else
                {
                    imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\musiquita.png"); // load a default picture
                    miniatura.Image = Image.FromFile(imagePath);
                }
            }
            catch
            {
                imagePath = Path.Combine(basePath, @"..\..\Reproductor_Medios\tutorial UI V icons\musiquita.png"); // load a default picture on error
                miniatura.Image = Image.FromFile(imagePath);
            }
            pictureBox2.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            string basePath = Environment.CurrentDirectory;
            string imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\icon.png");
            pictureBox1.Image = Image.FromFile(imagePath);

            reproduciendo = false;

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (!reproduciendo )
            {
                string basePath = Environment.CurrentDirectory;
                string imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\pausemini.png");
                pictureBox1.Image = Image.FromFile(imagePath);

                axWindowsMediaPlayer1.URL = @listBox1.Text;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                reproduciendo = true;
                

            }
            else
            {
                string basePath = Environment.CurrentDirectory;
                string imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\icon.png");
                pictureBox1.Image = Image.FromFile(imagePath);

                axWindowsMediaPlayer1.Ctlcontrols.pause();
                reproduciendo = false;
             
            }


            
            
        }

        float valores_default = 0.1f, Min = 0.0f, Max = 1.0f;

        public float Bar(float value)
        {

            return (slider.Width - 24) * (value - Min) / (float)(Max - Min);

        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.3f;
            float x = Bar(valores_default);
            int y = (int)(slider.Height * bar_size);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.DarkRed, 0, y, x, slider.Height - 30);
            using (Pen pen = new Pen(Color.FromArgb(235, 5, 75), 8))
            {

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex<track_list.Items.Count - 1){

                track_list.SelectedIndex = track_list.SelectedIndex +1;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >0)
            {

                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            if (trackBar1.Value == 0)
            {
                string basePath = Environment.CurrentDirectory;
                string imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\minimute.png");
                botonVolumen.Image = Image.FromFile(imagePath);

            }
            else {
                string basePath = Environment.CurrentDirectory;
                string imagePath = Path.Combine(basePath, @"..\..\tutorial UI V icons\reduced-volume.png");
                botonVolumen.Image = Image.FromFile(imagePath);
            }
        }

        private void botonVolumen_Click(object sender, EventArgs e)
        {
           
        }

        private void loadPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;
            listBox1.Items.Add(track_list.Text);
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            track_list.Text = listBox1.Text;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string directorioProyecto = Directory.GetCurrentDirectory();
            string rutaArchivo = Path.Combine(directorioProyecto, "../../Almacenamiento/Favoritos.txt");
            StreamWriter Guardar = new StreamWriter(rutaArchivo);

            foreach (var item in listBox1.Items) { 
               
                Guardar.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Añadido a favoritos");
            Guardar.Close();    
            listBox1.Items.Clear();
            
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..","Almacenamiento", "Favoritos.txt");

            using (StreamReader leer = new StreamReader(rutaArchivo)) 
            {
                string linea;
                while ((linea = leer.ReadLine()) != null) { 
                
                    listBox1.Items.Add (linea);
                }
            
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0) {

                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void axWindowsMediaPlayer1_Enter_2(object sender, EventArgs e)
        {

        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Max = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                valores_default = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                slider.Invalidate();
                lbl_start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                lbl_end.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            }
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
