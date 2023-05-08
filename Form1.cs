using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_Medios
{
    public partial class PanelLateral : Form
    {


        public PanelLateral()
        {

            InitializeComponent();
            personalizarDisenio();
        }

        private void personalizarDisenio()
        {

            panelMedios.Visible = false;

        }

        private void ocultarMenuLateral()
        {

            if (panelMedios.Visible == true)
            {

                panelMedios.Visible = false;

            }


        }

        private void mostrarMenuLateral(Panel menuLateral)
        {

            if (menuLateral.Visible == false)
            {
                ocultarMenuLateral();
                menuLateral.Visible = true;

            }
            else
            {

                menuLateral.Visible = false;
            }


        }


        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonMedia_Click(object sender, EventArgs e)
        {
            mostrarMenuLateral(panelMedios);
        }

        private void cargarAudio_Click(object sender, EventArgs e)
        {
            abrirpanelPrincipal(new Form2());

            ocultarMenuLateral();
        }

        private void cargarVideo_Click(object sender, EventArgs e)
        {
            abrirpanelPrincipal(new Form4());
            ocultarMenuLateral();
        }





        private void botonAyuda_Click(object sender, EventArgs e)
        {
            abrirpanelPrincipal(new Form3());
        }


        private Form FormularioActivo = null;

        private void abrirpanelPrincipal(Form formPrincipal)
        {

            if (FormularioActivo != null)
            {

                FormularioActivo.Close();
            }
            FormularioActivo = formPrincipal;
            formPrincipal.TopLevel = false;
            formPrincipal.FormBorderStyle = FormBorderStyle.None;
            formPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formPrincipal);
            panelPrincipal.Tag = formPrincipal;
            formPrincipal.BringToFront();
            formPrincipal.Show();


        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool estaReproduciendo = false;




        private void panelMedios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
