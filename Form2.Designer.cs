namespace Reproductor_Medios
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.botonVolumen = new System.Windows.Forms.PictureBox();
            this.botonAnterior = new System.Windows.Forms.PictureBox();
            this.botonStop = new System.Windows.Forms.PictureBox();
            this.botonSiguiente = new System.Windows.Forms.PictureBox();
            this.botonPlay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.favoritos = new System.Windows.Forms.PictureBox();
            this.cargarArchivo = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.miniatura = new System.Windows.Forms.PictureBox();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cargar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPlay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(497, 37);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(389, 56);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // botonVolumen
            // 
            this.botonVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolumen.Image = ((System.Drawing.Image)(resources.GetObject("botonVolumen.Image")));
            this.botonVolumen.Location = new System.Drawing.Point(439, 37);
            this.botonVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.botonVolumen.Name = "botonVolumen";
            this.botonVolumen.Size = new System.Drawing.Size(24, 24);
            this.botonVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botonVolumen.TabIndex = 27;
            this.botonVolumen.TabStop = false;
            this.botonVolumen.Click += new System.EventHandler(this.botonVolumen_Click);
            // 
            // botonAnterior
            // 
            this.botonAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnterior.Image = ((System.Drawing.Image)(resources.GetObject("botonAnterior.Image")));
            this.botonAnterior.Location = new System.Drawing.Point(221, 37);
            this.botonAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(24, 24);
            this.botonAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botonAnterior.TabIndex = 26;
            this.botonAnterior.TabStop = false;
            this.botonAnterior.Click += new System.EventHandler(this.botonAnterior_Click);
            // 
            // botonStop
            // 
            this.botonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.botonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonStop.Location = new System.Drawing.Point(367, 37);
            this.botonStop.Margin = new System.Windows.Forms.Padding(4);
            this.botonStop.Name = "botonStop";
            this.botonStop.Size = new System.Drawing.Size(32, 30);
            this.botonStop.TabIndex = 24;
            this.botonStop.TabStop = false;
            this.botonStop.Click += new System.EventHandler(this.botonStop_Click);
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("botonSiguiente.Image")));
            this.botonSiguiente.Location = new System.Drawing.Point(312, 37);
            this.botonSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(24, 24);
            this.botonSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botonSiguiente.TabIndex = 22;
            this.botonSiguiente.TabStop = false;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // botonPlay
            // 
            this.botonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPlay.Image = ((System.Drawing.Image)(resources.GetObject("botonPlay.Image")));
            this.botonPlay.Location = new System.Drawing.Point(261, 37);
            this.botonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.botonPlay.Name = "botonPlay";
            this.botonPlay.Size = new System.Drawing.Size(43, 33);
            this.botonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonPlay.TabIndex = 21;
            this.botonPlay.TabStop = false;
            this.botonPlay.Click += new System.EventHandler(this.botonPlay_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.favoritos);
            this.panel1.Controls.Add(this.botonVolumen);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.botonAnterior);
            this.panel1.Controls.Add(this.botonPlay);
            this.panel1.Controls.Add(this.botonSiguiente);
            this.panel1.Controls.Add(this.botonStop);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(3, 521);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 123);
            this.panel1.TabIndex = 29;
            // 
            // favoritos
            // 
            this.favoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoritos.Image = ((System.Drawing.Image)(resources.GetObject("favoritos.Image")));
            this.favoritos.Location = new System.Drawing.Point(135, 26);
            this.favoritos.Margin = new System.Windows.Forms.Padding(4);
            this.favoritos.Name = "favoritos";
            this.favoritos.Size = new System.Drawing.Size(51, 44);
            this.favoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favoritos.TabIndex = 29;
            this.favoritos.TabStop = false;
            this.favoritos.Click += new System.EventHandler(this.favoritos_Click);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.cargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarArchivo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cargarArchivo.Location = new System.Drawing.Point(28, 98);
            this.cargarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(129, 42);
            this.cargarArchivo.TabIndex = 6;
            this.cargarArchivo.Text = "Archivo";
            this.cargarArchivo.UseVisualStyleBackColor = false;
            this.cargarArchivo.Click += new System.EventHandler(this.cargarArchivo_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(28, 26);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(129, 42);
            this.botonCerrar.TabIndex = 9;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // track_list
            // 
            this.track_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(412, 98);
            this.track_list.Margin = new System.Windows.Forms.Padding(4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(359, 244);
            this.track_list.TabIndex = 18;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged_1);
            // 
            // miniatura
            // 
            this.miniatura.Image = ((System.Drawing.Image)(resources.GetObject("miniatura.Image")));
            this.miniatura.Location = new System.Drawing.Point(203, 142);
            this.miniatura.Margin = new System.Windows.Forms.Padding(4);
            this.miniatura.Name = "miniatura";
            this.miniatura.Size = new System.Drawing.Size(196, 174);
            this.miniatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniatura.TabIndex = 19;
            this.miniatura.TabStop = false;
            // 
            // lbl_start
            // 
            this.lbl_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_start.Location = new System.Drawing.Point(91, 368);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(60, 28);
            this.lbl_start.TabIndex = 52;
            this.lbl_start.Text = "00:00";
            // 
            // lbl_end
            // 
            this.lbl_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_end.Location = new System.Drawing.Point(732, 368);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(60, 28);
            this.lbl_end.TabIndex = 53;
            this.lbl_end.Text = "00:00";
            this.lbl_end.Click += new System.EventHandler(this.label3_Click);
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.Location = new System.Drawing.Point(175, 368);
            this.slider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(552, 30);
            this.slider.TabIndex = 58;
            this.slider.TabStop = false;
            this.slider.Click += new System.EventHandler(this.slider_Click);
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(175, 416);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 84);
            this.listBox1.TabIndex = 59;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(205, 12);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(451, 62);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_3);
            // 
            // Guardar
            // 
            this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(757, 399);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Guardar.MaximumSize = new System.Drawing.Size(99, 46);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(99, 46);
            this.Guardar.TabIndex = 60;
            this.Guardar.Text = "Guardar playlist";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cargar
            // 
            this.Cargar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.Cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cargar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar.Location = new System.Drawing.Point(757, 452);
            this.Cargar.Margin = new System.Windows.Forms.Padding(4);
            this.Cargar.MaximumSize = new System.Drawing.Size(99, 46);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(99, 46);
            this.Cargar.TabIndex = 62;
            this.Cargar.Text = "Cargar Playlist";
            this.Cargar.UseVisualStyleBackColor = false;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(16, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "Tus canciones";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(136, 416);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(28, 292);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 52);
            this.delete.TabIndex = 64;
            this.delete.Text = "Borrar canción de la Playlist";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.miniatura);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.cargarArchivo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPlay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox botonVolumen;
        private System.Windows.Forms.PictureBox botonAnterior;
        private System.Windows.Forms.PictureBox botonStop;
        private System.Windows.Forms.PictureBox botonSiguiente;
        private System.Windows.Forms.PictureBox botonPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cargarArchivo;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox miniatura;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox favoritos;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button delete;
    }
}