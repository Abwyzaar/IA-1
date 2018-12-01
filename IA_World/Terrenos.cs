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
    public partial class Terrenos : Form
    {
        public Terrenos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Terrenos_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridView1.Columns[2].Name = "Nombre";
           // dataGridView1.Columns[2].Name = "Color";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Color";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 7;
            cmb.Items.Add("Azul");
            cmb.Items.Add("Naranja");
            cmb.Items.Add("Rojo");
            cmb.Items.Add("Amarillo");
            cmb.Items.Add("Rosa");
            cmb.Items.Add("Morado");
            cmb.Items.Add("Negro");

            for (int i = 0; i < Program.terre; i++)
            {
                string[] a = new string[15];
                for (int j = 0; j < 3; j++)
                {
                    
                    a[1] = "Terreno"+i;

                    a[j] = Program.terrenos[i, j];
                }
                dataGridView1.Rows.Add(a);
            }
            dataGridView1.Columns.Add(cmb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.terre; i++)
            {
                string valorCelda = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string valorColor = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string idColor = "8";
                if (valorColor == "Verde")
                {
                    idColor = "0";

                }
                else if (valorColor == "Azul")
                {
                    idColor = "1";
                }
                else if (valorColor == "Naranja")
                {
                    idColor = "2";
                }
                else if (valorColor == "Rojo")
                {
                    idColor = "3";
                }
                else if (valorColor == "Amarillo")
                {
                    idColor = "4";
                }
                else if (valorColor == "Rosa")
                {
                    idColor = "5"; 
                }
                else if (valorColor == "Morado")
                {
                    idColor = "6";
                }
                else if (valorColor == "Negro")
                {
                    idColor = "7";
                }
                else
                {
                    idColor = "8";
                }

                Program.terrenos[i, 1] = valorCelda;
                Program.terrenos[i, 2] = idColor;
                Program.terrenos[i, 3] = "0";
                Program.terrenos[i, 4] = "0";
                Program.terrenos[i, 5] = "0";
                Program.terrenos[i, 6] = "0";
                Program.terrenos[i, 7] = "0";
            }
            Program.continuar2 = true;
            this.Close();
        }
    }
}
