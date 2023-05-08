namespace Reproductor_Medios
{
    partial class PanelLateral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelLateral));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonAyuda = new System.Windows.Forms.Button();
            this.panelMedios = new System.Windows.Forms.Panel();
            this.cargarVideo = new System.Windows.Forms.Button();
            this.cargarAudio = new System.Windows.Forms.Button();
            this.botonMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelMedios.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.botonAyuda);
            this.panel1.Controls.Add(this.panelMedios);
            this.panel1.Controls.Add(this.botonMedia);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 785);
            this.panel1.TabIndex = 0;
            // 
            // botonAyuda
            // 
            this.botonAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("botonAyuda.Image")));
            this.botonAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAyuda.Location = new System.Drawing.Point(0, 231);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonAyuda.Size = new System.Drawing.Size(250, 45);
            this.botonAyuda.TabIndex = 9;
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonAyuda.UseVisualStyleBackColor = true;
            this.botonAyuda.Click += new System.EventHandler(this.botonAyuda_Click);
            // 
            // panelMedios
            // 
            this.panelMedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMedios.Controls.Add(this.cargarVideo);
            this.panelMedios.Controls.Add(this.cargarAudio);
            this.panelMedios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedios.Location = new System.Drawing.Point(0, 145);
            this.panelMedios.Name = "panelMedios";
            this.panelMedios.Size = new System.Drawing.Size(250, 86);
            this.panelMedios.TabIndex = 2;
            this.panelMedios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMedios_Paint);
            // 
            // cargarVideo
            // 
            this.cargarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cargarVideo.FlatAppearance.BorderSize = 0;
            this.cargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarVideo.ForeColor = System.Drawing.Color.LightGray;
            this.cargarVideo.Image = ((System.Drawing.Image)(resources.GetObject("cargarVideo.Image")));
            this.cargarVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargarVideo.Location = new System.Drawing.Point(0, 40);
            this.cargarVideo.Name = "cargarVideo";
            this.cargarVideo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cargarVideo.Size = new System.Drawing.Size(250, 40);
            this.cargarVideo.TabIndex = 1;
            this.cargarVideo.Text = "  Cargar Video";
            this.cargarVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargarVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cargarVideo.UseVisualStyleBackColor = true;
            this.cargarVideo.Click += new System.EventHandler(this.cargarVideo_Click);
            // 
            // cargarAudio
            // 
            this.cargarAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cargarAudio.FlatAppearance.BorderSize = 0;
            this.cargarAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarAudio.ForeColor = System.Drawing.Color.LightGray;
            this.cargarAudio.Image = ((System.Drawing.Image)(resources.GetObject("cargarAudio.Image")));
            this.cargarAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargarAudio.Location = new System.Drawing.Point(0, 0);
            this.cargarAudio.Name = "cargarAudio";
            this.cargarAudio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cargarAudio.Size = new System.Drawing.Size(250, 40);
            this.cargarAudio.TabIndex = 0;
            this.cargarAudio.Text = "  Cargar Audio";
            this.cargarAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargarAudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cargarAudio.UseVisualStyleBackColor = true;
            this.cargarAudio.Click += new System.EventHandler(this.cargarAudio_Click);
            // 
            // botonMedia
            // 
            this.botonMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonMedia.FlatAppearance.BorderSize = 0;
            this.botonMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMedia.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonMedia.Image = ((System.Drawing.Image)(resources.GetObject("botonMedia.Image")));
            this.botonMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMedia.Location = new System.Drawing.Point(0, 100);
            this.botonMedia.Name = "botonMedia";
            this.botonMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonMedia.Size = new System.Drawing.Size(250, 45);
            this.botonMedia.TabIndex = 1;
            this.botonMedia.Text = "Media";
            this.botonMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonMedia.UseVisualStyleBackColor = true;
            this.botonMedia.Click += new System.EventHandler(this.botonMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelPrincipal.Controls.Add(this.textBox1);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(250, 0);
            this.panelPrincipal.MinimumSize = new System.Drawing.Size(1084, 793);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1084, 793);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(251, 590);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(787, 178);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Media Master\r\nExperimenta la música";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelLateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 785);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1350, 832);
            this.MinimumSize = new System.Drawing.Size(1350, 832);
            this.Name = "PanelLateral";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelMedios.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMedios;
        private System.Windows.Forms.Button cargarVideo;
        private System.Windows.Forms.Button cargarAudio;
        private System.Windows.Forms.Button botonMedia;
        private System.Windows.Forms.Button botonAyuda;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

