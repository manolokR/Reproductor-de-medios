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

        private void personalizarDisenio() {
        
            panelMedios.Visible = false;
            panelHerramientasMenuLateral.Visible = false;
            panelPlaylistMenuLateral.Visible = false;
        }

        private void ocultarMenuLateral() {

            if (panelMedios.Visible == true) {

                panelMedios.Visible = false;

            }

            if (panelHerramientasMenuLateral.Visible == true)
            {

                panelHerramientasMenuLateral.Visible = false;

            }

            if (panelPlaylistMenuLateral.Visible == true)
            {

                panelPlaylistMenuLateral.Visible = false;

            }
        }

        private void mostrarMenuLateral(Panel menuLateral) {

            if (menuLateral.Visible == false)
            {
                ocultarMenuLateral();
                menuLateral.Visible = true;

            }
            else {

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

        private void button2_Click(object sender, EventArgs e)
        {
            abrirpanelPrincipal(new Form2());

            ocultarMenuLateral();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void botonPlaylists_Click(object sender, EventArgs e)
        {
            mostrarMenuLateral(panelPlaylistMenuLateral);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void botonHerramientas_Click(object sender, EventArgs e)
        {
            mostrarMenuLateral(panelHerramientasMenuLateral);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            ocultarMenuLateral();
        }


        private Form FormularioActivo = null;

        private void abrirpanelPrincipal(Form formPrincipal) {

            if (FormularioActivo != null) { 
            
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

        private void botonEcualizador_Click(object sender, EventArgs e)
        {
            abrirpanelPrincipal(new Form3());

            ocultarMenuLateral();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
