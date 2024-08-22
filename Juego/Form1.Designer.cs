namespace Juego
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTiempo = new Label();
            lblNumeroJugadores = new Label();
            lblTurnoJugador = new Label();
            txtColumna = new TextBox();
            panel1 = new Panel();
            BtnJugar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnRestart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(41, 44);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(45, 20);
            lblTiempo.TabIndex = 0;
            lblTiempo.Text = "Time:";
            // 
            // lblNumeroJugadores
            // 
            lblNumeroJugadores.AutoSize = true;
            lblNumeroJugadores.Location = new Point(41, 91);
            lblNumeroJugadores.Name = "lblNumeroJugadores";
            lblNumeroJugadores.Size = new Size(58, 20);
            lblNumeroJugadores.TabIndex = 1;
            lblNumeroJugadores.Text = "Players:";
            // 
            // lblTurnoJugador
            // 
            lblTurnoJugador.AutoSize = true;
            lblTurnoJugador.Location = new Point(41, 133);
            lblTurnoJugador.Name = "lblTurnoJugador";
            lblTurnoJugador.Size = new Size(41, 20);
            lblTurnoJugador.TabIndex = 2;
            lblTurnoJugador.Text = "Turn:";
            // 
            // txtColumna
            // 
            txtColumna.Location = new Point(41, 180);
            txtColumna.Name = "txtColumna";
            txtColumna.Size = new Size(125, 27);
            txtColumna.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(195, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 437);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // BtnJugar
            // 
            BtnJugar.BackColor = Color.Transparent;
            BtnJugar.Location = new Point(41, 232);
            BtnJugar.Name = "BtnJugar";
            BtnJugar.Size = new Size(94, 29);
            BtnJugar.TabIndex = 6;
            BtnJugar.Text = "Play";
            BtnJugar.UseVisualStyleBackColor = false;
            BtnJugar.Click += BtnJugar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(891, 622);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 38);
            button1.TabIndex = 7;
            button1.Text = "Listen Something!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.KernelOS_Wallpaper_3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1076, 721);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(41, 291);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 721);
            Controls.Add(btnRestart);
            Controls.Add(button1);
            Controls.Add(BtnJugar);
            Controls.Add(txtColumna);
            Controls.Add(lblTurnoJugador);
            Controls.Add(lblNumeroJugadores);
            Controls.Add(lblTiempo);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "4 En Linea";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTiempo;
        private Label lblNumeroJugadores;
        private Label lblTurnoJugador;
        private TextBox txtColumna;
        private Panel panel1;
        private Button BtnJugar;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnRestart;
    }
}
