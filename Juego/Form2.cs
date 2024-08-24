using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form2 : Form
    {
        bool play = false;
        string[] ArchivoMP3;
        string[] rutasArchivosMP3;

        public Form2()
        {
            InitializeComponent();
        }

        //Here the songs are added
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;

            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivoMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchivoMP3)
                {
                    ltsCanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                ltsCanciones.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112539;
            }
        }

        //Added songs will be displayed
        private void ltsCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivosMP3[ltsCanciones.SelectedIndex];
            lblCancion.Text = ArchivoMP3[ltsCanciones.SelectedIndex];
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {

        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mTrackVolumen.Value;
        }

        //Makeover when the Play button is touched
        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112534;
                    play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112539;
                    play = true;
                    break;
            }
        }

        //makes stop the song
        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.Captura_de_pantalla_2024_08_16_112534;
            play = false;
        }

        //Controls the volume
        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mTrackEstatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mTrackVolumen.Value = Reproductor.settings.volume;
        }
        public void ActualizarDatosTrack()
        //Controls the time max
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mTrackEstatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mTrackEstatus.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void mTrackEstatus_ValueChanged(object sender, decimal value)
        {

        }
    }
}
