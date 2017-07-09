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
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void Numeros_Load(object sender, EventArgs e)
        {
            ptbNumero1.Visible = true;
        }

        int contBuenas, contMalas, acumPuntaje, puntos;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {            
            btnConfirmar.Enabled = true;
            if (ptbNumero1.Visible == true)
            {
                pbNumero3.Visible = true;
                ptbNumero1.Visible = false;
            }

            else if (pbNumero3.Visible == true)
            {
                pbNumero5.Visible = true;
                pbNumero3.Visible = false;
            }

            else if (pbNumero5.Visible == true)
            {
                pbNumero7.Visible = true;
                pbNumero5.Visible = false;
            }

            else if (pbNumero7.Visible == true)
            {
                pbNumero9.Visible = true;
                pbNumero7.Visible = false;
            }

            else if (pbNumero9.Visible == true)
            {
                pbNumero2.Visible = true;
                pbNumero9.Visible = false;
            }

            else if (pbNumero2.Visible == true)
            {
                pbNumero4.Visible = true;
                pbNumero2.Visible = false;
            }

            else if (pbNumero4.Visible == true)
            {
                pbNumero6.Visible = true;
                pbNumero4.Visible = false;
            }

            else if (pbNumero6.Visible == true)
            {
                pbNumero8.Visible = true;
                pbNumero6.Visible = false;
            }

            else if (pbNumero8.Visible == true)
            {
                pbNumero10.Visible = true;
                pbNumero8.Visible = false;
            }
            else
            {
                MessageBox.Show("Fin del juego", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(contBuenas==10)
                {
                    MessageBox.Show("Felicidades ahora sabes los números en inglés.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if(contBuenas <=7 && contBuenas>=5)
                {
                    MessageBox.Show("Ya te falta poco para aprender todos los números en ingles.", "Aprende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (ptbNumero1.Visible == true && rdbNumero1.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto","Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero3.Visible == true && rdbNumero3.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero5.Visible == true && rdbNumero5.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero7.Visible == true && rdbNumero7.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero9.Visible == true && rdbNumero9.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero2.Visible == true && rdbNumero2.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero4.Visible == true && rdbNumero4.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero6.Visible == true && rdbNumero6.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero8.Visible == true && rdbNumero8.Checked == true)
            {
                contBuenas++;
                puntos = 10;
                MessageBox.Show("Correcto", "Apende ingles jugando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pbNumero10.Visible == true && rdbNumero10.Checked == true)
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
