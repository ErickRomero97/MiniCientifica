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
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        int contBuenas, contMalas, acumPuntaje, puntos;

        private void Colores_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            if (pbAmarillo.Visible==true)
            {
                pbNegro.Visible = true;
                pbAmarillo.Visible = false;
            }

            else if (pbNegro.Visible == true)
            {
                pbAzul.Visible = true;
                pbNegro.Visible = false;
            }

            else if (pbAzul.Visible == true)
            {
                pbBlanco.Visible = true;
                pbAzul.Visible = false;
            }

            else if (pbBlanco.Visible == true)
            {
                pbRosado.Visible = true;
                pbBlanco.Visible = false;
            }

            else if (pbRosado.Visible == true)
            {
                pbCafe.Visible = true;
                pbRosado.Visible = false;
            }

            else if (pbCafe.Visible == true)
            {
                pbRojo.Visible = true;
                pbCafe.Visible = false;
            }

            else if (pbRojo.Visible == true)
            {
                pbAnaranjado.Visible = true;
                pbRojo.Visible = false;
            }

            else if (pbAnaranjado.Visible == true)
            {
                pbVerde.Visible = true;
                pbAnaranjado.Visible = false;
            }

            else
            {
                MessageBox.Show("Fin del juego", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (contBuenas == 10)
                {
                    MessageBox.Show("Felicidades ahora sabes los colores en inglés.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (contBuenas <= 7 && contBuenas >= 5)
                {
                    MessageBox.Show("Ya te falta poco para aprender todos los colores en ingles.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Debes estudiar mas el tutorial.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Close();
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (pbAmarillo.Visible == true && rdbYellow.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbAnaranjado.Visible == true && rdbOrange.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbAzul.Visible == true && rdbBlue.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbBlanco.Visible == true && rdbWhite.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbCafe.Visible == true && rdbBrown.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNegro.Visible == true && rdbBlack.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbRojo.Visible == true && rdbRed.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbRosado.Visible == true && rdbPink.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbVerde.Visible == true && rdbGreen.Checked == true)
            {
                contBuenas++;
                puntos = 10;
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
    }
}
