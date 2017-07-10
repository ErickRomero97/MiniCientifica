using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MiniJuego
{
    public partial class NumerosInstrucciones : Form
    {
        public NumerosInstrucciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numeros MiNumero = new Numeros();
            MiNumero.Show();
            Close();
        }

        private void NumerosInstrucciones_Load(object sender, EventArgs e)
        {
            SoundPlayer Musica;
            Musica = new SoundPlayer(@"C:\Users\ERICK GALLARDO\Desktop\MiniCientifica\MiniJuego\musicas\M_sica_electr_nica_lenta.wav");
            Musica.Play();
        }
    }
}
