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
    public partial class Personajes : Form
    {
        public Personajes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Program.ya)
            {

                Program.ya = true;
                string cantidad = textBox1.Text;
                Program.cantidadPersonajes = 1;
                if (!Int32.TryParse(cantidad, out Program.cantidadPersonajes))
                {
                    Program.cantidadPersonajes = 1;
                }
                if (Program.cantidadPersonajes > 5)
                {
                    MessageBox.Show("Solo puede agregar 5 personajes", "ERROR",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Program.cantidadPersonajes = 5;
                }
                dataGridView1.ColumnCount = 3 + Program.cantidadPersonajes;

                for (int i = 0; i < Program.cantidadPersonajes; i++)
                {
                    dataGridView1.Columns[i + 3].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dataGridView1.Columns[i + 3].Name = "Personaje" + (i + 1);
                    Program.personajes[i] = "Personaje" + (i + 1);
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //carga datos al grid

                for (int i = 0; i < Program.terre; i++)
                {
                    string[] a = new string[15];
                    for (int j = 0; j < 3 + Program.cantidadPersonajes; j++)
                    {
                        if (Program.terrenos[i, j] == null)
                        {
                            a[j] = "0";
                        }
                        else
                        {
                            a[j] = Program.terrenos[i, j];
                        }


                    }
                    dataGridView1.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Ya has seleccionado la cantidad de personajes", "ERROR",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Program.cantidadPersonajes == 0)
            {
                MessageBox.Show("No has agregado ningun personaje", "ERROR",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                //Guarda en array los valores de los personajes y sus costos por terrenos.
                for (int i = 0; i < Program.terre; i++)
                {
                    string valorCelda = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    Program.terrenos[i, 1] = valorCelda;
                    for(int j = 0; j < Program.cantidadPersonajes; j++)
                    {
                        string valorCelda2 = dataGridView1.Rows[i].Cells[3+j].Value.ToString();
                        Program.terrenos[i, 3+j] = valorCelda2;
                        
                    }
                }
                Program.continuar3 = true;
                this.Close();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Personajes_Load(object sender, EventArgs e)
        {

        }
    }
}
