namespace Reproductor_Medios
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.botonPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.cargarVideo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.botonPlay);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(891, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 123);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(452, 4);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(397, 56);
            this.trackBar2.TabIndex = 36;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(176, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // botonPlay
            // 
            this.botonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPlay.Image = ((System.Drawing.Image)(resources.GetObject("botonPlay.Image")));
            this.botonPlay.Location = new System.Drawing.Point(216, 4);
            this.botonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.botonPlay.Name = "botonPlay";
            this.botonPlay.Size = new System.Drawing.Size(43, 33);
            this.botonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonPlay.TabIndex = 29;
            this.botonPlay.TabStop = false;
            this.botonPlay.Click += new System.EventHandler(this.botonPlay_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(267, 4);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 30;
            this.pictureBox11.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 422);
            this.panel2.TabIndex = 52;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(891, 343);
            this.axWindowsMediaPlayer1.TabIndex = 49;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbl_end);
            this.panel3.Controls.Add(this.lbl_start);
            this.panel3.Controls.Add(this.slider);
            this.panel3.Controls.Add(this.botonCerrar);
            this.panel3.Controls.Add(this.cargarVideo);
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 95);
            this.panel3.TabIndex = 53;
            // 
            // lbl_end
            // 
            this.lbl_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_end.Location = new System.Drawing.Point(661, 2);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(60, 28);
            this.lbl_end.TabIndex = 59;
            this.lbl_end.Text = "00:00";
            // 
            // lbl_start
            // 
            this.lbl_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_start.Location = new System.Drawing.Point(169, 2);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(60, 28);
            this.lbl_start.TabIndex = 58;
            this.lbl_start.Text = "00:00";
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.Location = new System.Drawing.Point(175, 49);
            this.slider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(552, 30);
            this.slider.TabIndex = 57;
            this.slider.TabStop = false;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.botonCerrar.Location = new System.Drawing.Point(4, 37);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(129, 42);
            this.botonCerrar.TabIndex = 56;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // cargarVideo
            // 
            this.cargarVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(5)))), ((int)(((byte)(75)))));
            this.cargarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarVideo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cargarVideo.Location = new System.Drawing.Point(760, 37);
            this.cargarVideo.Margin = new System.Windows.Forms.Padding(4);
            this.cargarVideo.Name = "cargarVideo";
            this.cargarVideo.Size = new System.Drawing.Size(127, 42);
            this.cargarVideo.TabIndex = 55;
            this.cargarVideo.Text = "Cargar";
            this.cargarVideo.UseVisualStyleBackColor = false;
            this.cargarVideo.Click += new System.EventHandler(this.cargarVideo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(906, 680);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button cargarVideo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox botonPlay;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Timer timer1;
    }
}