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
        public Form2()
        {
            InitializeComponent();
            slider.Height = 30;
        }

        WindowsMediaPlayer sonido;

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String urlSonido;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Elige la canción que quieras :)";
                openFileDialog1.Filter = "Archivos MP3|*.mp3";
                openFileDialog1.ShowDialog();
                string Texto = openFileDialog1.FileName;
                if (File.Exists(openFileDialog1.FileName))
                {

                    string nombreArchivo = Path.GetFileName(Texto); // Extraer el nombre del archivo de la ruta completa
                 //   rtxt_Contenido.Text = "Nombre del archivo: " + nombreArchivo; // Mostrar solo el nombre del archivo
                    txt_Direccion.Text = Texto;
                    urlSonido = Texto;


                }
                txt_Direccion.Text = Texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
