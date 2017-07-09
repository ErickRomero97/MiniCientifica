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
    public partial class Animales : Form
    {
        public Animales()
        {
            InitializeComponent();
        }

        int contBuenas, contMalas, acumPuntaje, puntos;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (pbPerro.Visible == true && rdbDog.Checked == true)
            {
                contBuenas++;
                puntos = 20;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbGato.Visible == true && rdbCat.Checked == true)
            {
                contBuenas++;
                puntos = 20;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbConejo.Visible == true && rdbRabbit.Checked == true)
            {
                contBuenas++;
                puntos = 20;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbCocodrilo.Visible == true && rdbCrocodile.Checked == true)
            {
                contBuenas++;
                puntos = 20;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbBallena.Visible == true && rdbWhale.Checked == true)
            {
                contBuenas++;
                puntos = 20;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                contMalas++;
                puntos = 0;
                MessageBox.Show("Incorrecto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnConfirmar.Enabled = false;
            acumPuntaje += puntos;

            txtBuenas.Text = contBuenas.ToString();
            txtMalas.Text = contMalas.ToString();
            txtPuntaje.Text = acumPuntaje.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            if (pbGato.Visible == true)
            {
                pbBallena.Visible = true;
                pbGato.Visible = false;
            }

            else if (pbBallena.Visible == true)
            {
                pbCocodrilo.Visible = true;
                pbBallena.Visible = false;
            }

            else if (pbCocodrilo.Visible == true)
            {
                pbConejo.Visible = true;
                pbCocodrilo.Visible = false;
            }

            else if (pbConejo.Visible == true)
            {
                pbPerro.Visible = true;
                pbConejo.Visible = false;
            }

            else
            {
                MessageBox.Show("Fin del juego", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (contBuenas == 5)
                {
                    MessageBox.Show("Felicidades ahora conoces los animales en inglés.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (contBuenas <= 4 && contBuenas >= 2)
                {
                    MessageBox.Show("Ya te falta poco para aprender todos los animales en ingles.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Debes estudiar mas el tutorial.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Close();
            }
        }
    }
}
