using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_World
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
                textBox1.Text = ofd.SafeFileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pathAux = textBox2.Text;
            if (pathAux.Contains(".txt"))
            {
                
                
                Program.path = pathAux;
                Program.leerArchivo();

                if (!Program.errorFile)
                {
                    this.Close();
                    Program.continuar = true;
                    Program.TerrenosEncontrados();
                }
                else
                {
                    this.Close();
                    MessageBox.Show("ERROR AL CARGAR LA MATRIZ", "ERROR",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    
                }
                
                
            }
            else
            {
                MessageBox.Show("NO ES UN ARCHIVO TXT", "ERROR AL ABRIR",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
