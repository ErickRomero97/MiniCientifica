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
    public partial class ColoresInstrucciones : Form
    {
        public ColoresInstrucciones()
        {
            InitializeComponent();
        }

        private void ColoresInstrucciones_Load(object sender, EventArgs e)
        {
            SoundPlayer Musica;
            Musica = new SoundPlayer(@"C:\Users\Miguel\Desktop\MiniJuego\musicas\Electric_Daisy_Violin.wav");
            Musica.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Colores MiColor = new Colores();
            MiColor.Show();
            Close();
        }
    }
}
