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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public object Musica { get; private set; }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer Musica;
            Musica = new SoundPlayer(@"C:\Users\ERICK GALLARDO\Desktop\MiniCientifica\MiniJuego\musicas\Titanium_-_Pavane_Piano-Cello_Cover_-_David_Guetta.wav");
            Musica.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Niveles MiNivel = new Niveles();
            MiNivel.Show();
            Hide();
        }
    }
}
