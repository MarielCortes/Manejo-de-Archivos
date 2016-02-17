using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manejo_de_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Enabled = false;
        }

        Class1 Mariel = new Class1();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mariel.CrearArchivo(textBox1, richTextBox1);
            Mariel.FEHO(label4, label5);
        }

        private void cargarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mariel.CargarTexto(richTextBox1, textBox1);
        }

        private void gusrdarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mariel.GuardarCambios(textBox2,richTextBox1);
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mariel.CrearArchivo(textBox1, richTextBox1);
            Mariel.FEHO(label4, label5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mariel.CargarTexto(richTextBox1, textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mariel.GuardarCambios(textBox2, richTextBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
