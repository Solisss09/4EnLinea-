namespace Juego
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            ltsCanciones = new ListBox();
            btnAdjuntar = new PictureBox();
            mTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            mTrackEstatus = new XComponent.SliderBar.MACTrackBar();
            btnStop = new PictureBox();
            btnPlay = new PictureBox();
            lblCancion = new Label();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Reproductor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdjuntar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Reproductor
            // 
            Reproductor.Enabled = true;
            Reproductor.Location = new Point(336, 466);
            Reproductor.Name = "Reproductor";
            Reproductor.OcxState = (AxHost.State)resources.GetObject("Reproductor.OcxState");
            Reproductor.Size = new Size(28, 15);
            Reproductor.TabIndex = 0;
            Reproductor.PlayStateChange += Reproductor_PlayStateChange;
            Reproductor.Enter += Reproductor_Enter;
            // 
            // ltsCanciones
            // 
            ltsCanciones.ForeColor = Color.Black;
            ltsCanciones.FormattingEnabled = true;
            ltsCanciones.Location = new Point(12, 175);
            ltsCanciones.Name = "ltsCanciones";
            ltsCanciones.Size = new Size(427, 464);
            ltsCanciones.TabIndex = 1;
            ltsCanciones.SelectedIndexChanged += ltsCanciones_SelectedIndexChanged;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Cursor = Cursors.Hand;
            btnAdjuntar.Image = Properties.Resources._4105962_add_expand_plus_113920;
            btnAdjuntar.Location = new Point(187, 32);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(88, 75);
            btnAdjuntar.SizeMode = PictureBoxSizeMode.Zoom;
            btnAdjuntar.TabIndex = 3;
            btnAdjuntar.TabStop = false;
            btnAdjuntar.Click += btnAdjuntar_Click;
            // 
            // mTrackVolumen
            // 
            mTrackVolumen.BackColor = Color.Transparent;
            mTrackVolumen.BorderColor = SystemColors.ActiveBorder;
            mTrackVolumen.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mTrackVolumen.ForeColor = Color.FromArgb(123, 125, 123);
            mTrackVolumen.IndentHeight = 6;
            mTrackVolumen.Location = new Point(336, 56);
            mTrackVolumen.Maximum = 100;
            mTrackVolumen.Minimum = 0;
            mTrackVolumen.Name = "mTrackVolumen";
            mTrackVolumen.Size = new Size(144, 22);
            mTrackVolumen.TabIndex = 4;
            mTrackVolumen.Text = "macTrackBar1";
            mTrackVolumen.TextTickStyle = TickStyle.None;
            mTrackVolumen.TickColor = Color.Silver;
            mTrackVolumen.TickHeight = 4;
            mTrackVolumen.TickStyle = TickStyle.None;
            mTrackVolumen.TrackerColor = Color.Black;
            mTrackVolumen.TrackerSize = new Size(10, 10);
            mTrackVolumen.TrackLineColor = Color.DarkGray;
            mTrackVolumen.TrackLineHeight = 3;
            mTrackVolumen.TrackLineSelectedColor = Color.Red;
            mTrackVolumen.Value = 0;
            mTrackVolumen.ValueChanged += macTrackBar1_ValueChanged;
            // 
            // mTrackEstatus
            // 
            mTrackEstatus.BackColor = Color.Transparent;
            mTrackEstatus.BorderColor = SystemColors.ActiveBorder;
            mTrackEstatus.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mTrackEstatus.ForeColor = Color.FromArgb(123, 125, 123);
            mTrackEstatus.IndentHeight = 6;
            mTrackEstatus.Location = new Point(12, 147);
            mTrackEstatus.Maximum = 10;
            mTrackEstatus.Minimum = 0;
            mTrackEstatus.Name = "mTrackEstatus";
            mTrackEstatus.Size = new Size(427, 22);
            mTrackEstatus.TabIndex = 5;
            mTrackEstatus.Text = "macTrackBar2";
            mTrackEstatus.TextTickStyle = TickStyle.None;
            mTrackEstatus.TickColor = Color.Silver;
            mTrackEstatus.TickHeight = 4;
            mTrackEstatus.TickStyle = TickStyle.None;
            mTrackEstatus.TrackerColor = Color.Black;
            mTrackEstatus.TrackerSize = new Size(10, 10);
            mTrackEstatus.TrackLineColor = Color.FromArgb(90, 93, 90);
            mTrackEstatus.TrackLineHeight = 3;
            mTrackEstatus.TrackLineSelectedColor = Color.FromArgb(90, 93, 90);
            mTrackEstatus.Value = 0;
            mTrackEstatus.ValueChanged += mTrackEstatus_ValueChanged;
            // 
            // btnStop
            // 
            btnStop.Cursor = Cursors.Hand;
            btnStop.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112539;
            btnStop.Location = new Point(12, 32);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(79, 75);
            btnStop.SizeMode = PictureBoxSizeMode.StretchImage;
            btnStop.TabIndex = 6;
            btnStop.TabStop = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnPlay
            // 
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112534;
            btnPlay.Location = new Point(97, 32);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(84, 75);
            btnPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPlay.TabIndex = 7;
            btnPlay.TabStop = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblCancion
            // 
            lblCancion.AutoSize = true;
            lblCancion.Location = new Point(13, 10);
            lblCancion.Name = "lblCancion";
            lblCancion.Size = new Size(21, 20);
            lblCancion.TabIndex = 8;
            lblCancion.Text = "--";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(282, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 729);
            Controls.Add(pictureBox3);
            Controls.Add(lblCancion);
            Controls.Add(btnPlay);
            Controls.Add(btnStop);
            Controls.Add(mTrackEstatus);
            Controls.Add(mTrackVolumen);
            Controls.Add(btnAdjuntar);
            Controls.Add(ltsCanciones);
            Controls.Add(Reproductor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Reproductor MP3";
            ((System.ComponentModel.ISupportInitialize)Reproductor).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdjuntar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private ListBox ltsCanciones;
        private PictureBox btnAdjuntar;
        private XComponent.SliderBar.MACTrackBar mTrackVolumen;
        private XComponent.SliderBar.MACTrackBar mTrackEstatus;
        private PictureBox btnStop;
        private PictureBox btnPlay;
        private Label lblCancion;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}