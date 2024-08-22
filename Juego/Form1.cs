using System;
using System.Drawing;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int tiempoTranscurrido = 0;
        private int turnoJugador = 1;
        private int[,] tablero;
        private const int filas = 6;
        private const int columnas = 6;

        public Form1()
        {
            InitializeComponent();
            InicializarJuego();


            txtColumna.KeyDown += TxtColumna_KeyDown;
        }

        private void InicializarJuego()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            tablero = new int[filas, columnas];

            lblTiempo.Text = "0:00";
            lblNumeroJugadores.Text = "Jugadores: 2";
            lblTurnoJugador.Text = "Turno del Jugador 1";
            tiempoTranscurrido = 0;
            turnoJugador = 1;
            panel1.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido++;
            TimeSpan tiempo = TimeSpan.FromSeconds(tiempoTranscurrido);
            lblTiempo.Text = tiempo.ToString(@"m\:ss");
        }

        private void CambiarTurno()
        {
            turnoJugador = turnoJugador == 1 ? 2 : 1;
            lblTurnoJugador.Text = $"Turno del Jugador {turnoJugador}";
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            InsertarFichaDesdeTextBox();
        }

        private void TxtColumna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertarFichaDesdeTextBox();
                e.Handled = true; // Prevenir que el sonido de error suene cuando se presiona Enter
                e.SuppressKeyPress = true;
            }
        }

        private void InsertarFichaDesdeTextBox()
        {
            if (int.TryParse(txtColumna.Text, out int columnaSeleccionada))
            {
                if (columnaSeleccionada >= 1 && columnaSeleccionada <= columnas)
                {
                    if (InsertarFicha(columnaSeleccionada - 1))
                    {
                        if (VerificarGanador())
                        {
                            MessageBox.Show($"¡Jugador {turnoJugador} es el ganador!");
                            ReiniciarJuego();
                        }
                        else
                        {
                            CambiarTurno();
                            panel1.Invalidate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La columna está llena. Elige otra columna.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de columna entre 1 y 5.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }

            txtColumna.Clear();
            txtColumna.Focus();
        }

        private bool InsertarFicha(int columna)
        {
            for (int fila = filas - 1; fila >= 0; fila--)
            {
                if (tablero[fila, columna] == 0)
                {
                    tablero[fila, columna] = turnoJugador;
                    return true;
                }
            }
            return false;
        }

        private bool VerificarGanador()
        {
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna <= columnas - 4; columna++)
                {
                    if (tablero[fila, columna] == turnoJugador &&
                        tablero[fila, columna + 1] == turnoJugador &&
                        tablero[fila, columna + 2] == turnoJugador &&
                        tablero[fila, columna + 3] == turnoJugador)
                    {
                        return true;
                    }
                }
            }

            for (int columna = 0; columna < columnas; columna++)
            {
                for (int fila = 0; fila <= filas - 4; fila++)
                {
                    if (tablero[fila, columna] == turnoJugador &&
                        tablero[fila + 1, columna] == turnoJugador &&
                        tablero[fila + 2, columna] == turnoJugador &&
                        tablero[fila + 3, columna] == turnoJugador)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void ReiniciarJuego()
        {
            timer.Stop();
            tiempoTranscurrido = 0;
            lblTiempo.Text = "0:00";

            tablero = new int[filas, columnas];
            turnoJugador = 1;
            lblTurnoJugador.Text = "Turno del Jugador 1";

            panel1.Invalidate();
            timer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int anchoCelda = panel1.Width / columnas;
            int altoCelda = panel1.Height / filas;

            for (int i = 0; i <= columnas; i++)
            {
                g.DrawLine(Pens.Black, i * anchoCelda, 0, i * anchoCelda, panel1.Height);
            }

            for (int i = 0; i <= filas; i++)
            {
                g.DrawLine(Pens.Black, 0, i * altoCelda, panel1.Width, i * altoCelda);
            }

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (tablero[fila, columna] != 0)
                    {
                        Brush brush = tablero[fila, columna] == 1 ? Brushes.Red : Brushes.Blue;
                        g.FillEllipse(brush, columna * anchoCelda, fila * altoCelda, anchoCelda, altoCelda);
                    }
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            tiempoTranscurrido = 0;
            lblTiempo.Text = "0:00";

            tablero = new int[filas, columnas];
            turnoJugador = 1;
            lblTurnoJugador.Text = "Turno del Jugador 1";

            panel1.Invalidate();
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}

