namespace MiniJuego
{
    partial class Animales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.txtMalas = new System.Windows.Forms.TextBox();
            this.txtBuenas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.rdbCrocodile = new System.Windows.Forms.RadioButton();
            this.rdbWhale = new System.Windows.Forms.RadioButton();
            this.rdbCat = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbRabbit = new System.Windows.Forms.RadioButton();
            this.rdbDog = new System.Windows.Forms.RadioButton();
            this.pbGato = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBallena = new System.Windows.Forms.PictureBox();
            this.pbConejo = new System.Windows.Forms.PictureBox();
            this.pbCocodrilo = new System.Windows.Forms.PictureBox();
            this.pbPerro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCocodrilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MiniJuego.Properties.Resources.zelva;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(907, 478);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::MiniJuego.Properties.Resources.Confi;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(687, 292);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 66);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPuntaje);
            this.groupBox1.Controls.Add(this.txtMalas);
            this.groupBox1.Controls.Add(this.txtBuenas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(637, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(94, 67);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 20);
            this.txtPuntaje.TabIndex = 8;
            // 
            // txtMalas
            // 
            this.txtMalas.Location = new System.Drawing.Point(94, 41);
            this.txtMalas.Name = "txtMalas";
            this.txtMalas.Size = new System.Drawing.Size(100, 20);
            this.txtMalas.TabIndex = 7;
            // 
            // txtBuenas
            // 
            this.txtBuenas.Location = new System.Drawing.Point(94, 17);
            this.txtBuenas.Name = "txtBuenas";
            this.txtBuenas.Size = new System.Drawing.Size(100, 20);
            this.txtBuenas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puntaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Malas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Buenas";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = global::MiniJuego.Properties.Resources.Siguente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(687, 374);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(132, 66);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.rdbCrocodile);
            this.panel1.Controls.Add(this.rdbWhale);
            this.panel1.Controls.Add(this.rdbCat);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.rdbRabbit);
            this.panel1.Controls.Add(this.rdbDog);
            this.panel1.Location = new System.Drawing.Point(91, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 142);
            this.panel1.TabIndex = 17;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(312, 71);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 28);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "Duck";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // rdbCrocodile
            // 
            this.rdbCrocodile.AutoSize = true;
            this.rdbCrocodile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCrocodile.Location = new System.Drawing.Point(165, 71);
            this.rdbCrocodile.Name = "rdbCrocodile";
            this.rdbCrocodile.Size = new System.Drawing.Size(109, 28);
            this.rdbCrocodile.TabIndex = 6;
            this.rdbCrocodile.Text = "Crocodile";
            this.rdbCrocodile.UseVisualStyleBackColor = true;
            // 
            // rdbWhale
            // 
            this.rdbWhale.AutoSize = true;
            this.rdbWhale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWhale.Location = new System.Drawing.Point(364, 33);
            this.rdbWhale.Name = "rdbWhale";
            this.rdbWhale.Size = new System.Drawing.Size(82, 28);
            this.rdbWhale.TabIndex = 4;
            this.rdbWhale.Text = "Whale";
            this.rdbWhale.UseVisualStyleBackColor = true;
            // 
            // rdbCat
            // 
            this.rdbCat.AutoSize = true;
            this.rdbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCat.Location = new System.Drawing.Point(60, 71);
            this.rdbCat.Name = "rdbCat";
            this.rdbCat.Size = new System.Drawing.Size(55, 28);
            this.rdbCat.TabIndex = 3;
            this.rdbCat.Text = "Cat";
            this.rdbCat.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(240, 33);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Chicken";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdbRabbit
            // 
            this.rdbRabbit.AutoSize = true;
            this.rdbRabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRabbit.Location = new System.Drawing.Point(138, 33);
            this.rdbRabbit.Name = "rdbRabbit";
            this.rdbRabbit.Size = new System.Drawing.Size(81, 28);
            this.rdbRabbit.TabIndex = 1;
            this.rdbRabbit.Text = "Rabbit";
            this.rdbRabbit.UseVisualStyleBackColor = true;
            // 
            // rdbDog
            // 
            this.rdbDog.AutoSize = true;
            this.rdbDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDog.Location = new System.Drawing.Point(20, 33);
            this.rdbDog.Name = "rdbDog";
            this.rdbDog.Size = new System.Drawing.Size(63, 28);
            this.rdbDog.TabIndex = 0;
            this.rdbDog.Text = "Dog";
            this.rdbDog.UseVisualStyleBackColor = true;
            // 
            // pbGato
            // 
            this.pbGato.Image = global::MiniJuego.Properties.Resources._0fd3781e76efde73f9003b46ce4e29cd;
            this.pbGato.Location = new System.Drawing.Point(219, 92);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(186, 128);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGato.TabIndex = 22;
            this.pbGato.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 35);
            this.label4.TabIndex = 23;
            this.label4.Text = "¿Conoces este animal?";
            // 
            // pbBallena
            // 
            this.pbBallena.Image = global::MiniJuego.Properties.Resources.b02483c9a2e09ca60aa2260ee58272d0;
            this.pbBallena.Location = new System.Drawing.Point(219, 92);
            this.pbBallena.Name = "pbBallena";
            this.pbBallena.Size = new System.Drawing.Size(186, 128);
            this.pbBallena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBallena.TabIndex = 24;
            this.pbBallena.TabStop = false;
            this.pbBallena.Visible = false;
            // 
            // pbConejo
            // 
            this.pbConejo.Image = global::MiniJuego.Properties.Resources.conejo_con_zanahoria_fiestas_pascua_pintado_por_paocarranz_9777011;
            this.pbConejo.Location = new System.Drawing.Point(219, 92);
            this.pbConejo.Name = "pbConejo";
            this.pbConejo.Size = new System.Drawing.Size(186, 128);
            this.pbConejo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConejo.TabIndex = 25;
            this.pbConejo.TabStop = false;
            this.pbConejo.Visible = false;
            // 
            // pbCocodrilo
            // 
            this.pbCocodrilo.Image = global::MiniJuego.Properties.Resources.images__1_;
            this.pbCocodrilo.Location = new System.Drawing.Point(219, 92);
            this.pbCocodrilo.Name = "pbCocodrilo";
            this.pbCocodrilo.Size = new System.Drawing.Size(186, 128);
            this.pbCocodrilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCocodrilo.TabIndex = 26;
            this.pbCocodrilo.TabStop = false;
            this.pbCocodrilo.Visible = false;
            // 
            // pbPerro
            // 
            this.pbPerro.Image = global::MiniJuego.Properties.Resources.Perro_en_dibujo;
            this.pbPerro.Location = new System.Drawing.Point(219, 92);
            this.pbPerro.Name = "pbPerro";
            this.pbPerro.Size = new System.Drawing.Size(186, 128);
            this.pbPerro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerro.TabIndex = 27;
            this.pbPerro.TabStop = false;
            this.pbPerro.Visible = false;
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniJuego.Properties.Resources.zelva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 478);
            this.Controls.Add(this.pbPerro);
            this.Controls.Add(this.pbCocodrilo);
            this.Controls.Add(this.pbConejo);
            this.Controls.Add(this.pbBallena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbGato);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Animales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCocodrilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton rdbCrocodile;
        private System.Windows.Forms.RadioButton rdbWhale;
        private System.Windows.Forms.RadioButton rdbCat;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbRabbit;
        private System.Windows.Forms.RadioButton rdbDog;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.TextBox txtMalas;
        private System.Windows.Forms.TextBox txtBuenas;
        private System.Windows.Forms.PictureBox pbGato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbBallena;
        private System.Windows.Forms.PictureBox pbConejo;
        private System.Windows.Forms.PictureBox pbCocodrilo;
        private System.Windows.Forms.PictureBox pbPerro;
    }
}