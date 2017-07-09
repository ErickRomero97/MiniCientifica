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
    public partial class AnimalesInstrucciones : Form
    {
        public AnimalesInstrucciones()
        {
            InitializeComponent();
        }

        private void AnimalesInstrucciones_Load(object sender, EventArgs e)
        {
            SoundPlayer Musica;
            Musica = new SoundPlayer(@"C:\Users\Miguel\Desktop\MiniJuego\musicas\Deadmau5_-_Animal_Rights_4x4_12_.wav");
            Musica.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animales MiAnimal = new Animales();
            MiAnimal.Show();
            Close();
        }
    }
}
