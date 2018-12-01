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
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Program.columns+1;
            for(int i = 0; i <= Program.columns; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if(Program.columns == 0)
            {
                dataGridView1.Columns[0].Name = "A";
            }
            else if (Program.columns == 1)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
            }
            else if (Program.columns == 2)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
               
            }
            else if (Program.columns == 3)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                
            }
            else if (Program.columns == 4)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                
            }
            else if(Program.columns == 5)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                
            }
            else if (Program.columns == 6)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
            }
            else if (Program.columns == 7)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                
            }
            else if (Program.columns == 8)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                
            }
            else if (Program.columns == 9)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
               
            }
            else if(Program.columns == 10)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                
            }
            else if (Program.columns == 11)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                dataGridView1.Columns[11].Name = "L";
                
            }
            else if (Program.columns == 12)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                dataGridView1.Columns[11].Name = "L";
                dataGridView1.Columns[12].Name = "M";
                
            }

            else if (Program.columns == 13)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                dataGridView1.Columns[11].Name = "L";
                dataGridView1.Columns[12].Name = "M";
                dataGridView1.Columns[13].Name = "N";
                
            }
            else if (Program.columns == 14)
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                dataGridView1.Columns[11].Name = "L";
                dataGridView1.Columns[12].Name = "M";
                dataGridView1.Columns[13].Name = "N";
                dataGridView1.Columns[14].Name = "Ñ";
            }

            else 
            {
                dataGridView1.Columns[0].Name = "A";
                dataGridView1.Columns[1].Name = "B";
                dataGridView1.Columns[2].Name = "C";
                dataGridView1.Columns[3].Name = "D";
                dataGridView1.Columns[4].Name = "E";
                dataGridView1.Columns[5].Name = "F";
                dataGridView1.Columns[6].Name = "G";
                dataGridView1.Columns[7].Name = "H";
                dataGridView1.Columns[8].Name = "I";
                dataGridView1.Columns[9].Name = "J";
                dataGridView1.Columns[10].Name = "K";
                dataGridView1.Columns[11].Name = "L";
                dataGridView1.Columns[12].Name = "M";
                dataGridView1.Columns[13].Name = "N";
                dataGridView1.Columns[14].Name = "Ñ";
            }

           

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < Program.rows; i++)
            {
                string[] a = new string[Program.columns];
                for (int j = 0; j < Program.columns; j++)
                {
                    a[j] = "";
                }
                dataGridView1.Rows.Add(a);
            }

            dibujar();

            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);

            comboBox1.DataSource = Program.personajes;

        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, j;
            i = e.RowIndex;
            j = e.ColumnIndex;
            //dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;
            MessageBox.Show("Click", "IA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Program.Reiniciar();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i, j;
            i = e.RowIndex;
            j = e.ColumnIndex;
            string combo = comboBox2.Text;
            string perso = comboBox1.Text;
            string value = Program.matriz[i,j];
            int pos = Program.PosEncontrado(value);
            int posP = Program.PosEncontradoPersonaje(perso);
            //MessageBox.Show(posP.ToString(), "",
            //MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            if (Program.terrenos[pos, 3 + posP] != "N/A")
            {
                if (combo == "Inicio." && !Program.inicio)
                {
                    Program.inicioI = i;
                    Program.inicioJ = j;
                    //Program.inicioC = Color.Violet;
                    Program.inicio = true;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Indigo;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Indigo;

                    treeView1.Nodes.Add("Nodo[" +Program.inicioI + "," + Program.inicioJ +"]");

                }
                else if (combo == "Meta." && !Program.final)
                {
                    Program.finalI = i;
                    Program.finalJ = j;
                   // Program.finalC = Color.Black;
                    Program.final = true;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.White;

                    //treeView1.Nodes.Add("Nodo[" + (Program.finalI+1) + "," + (Program.finalJ+1) + "]");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("No puede posicionar el personaje en dicho terreno. Intente de nuevo.", "ERROR",
                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, j;
            i = e.RowIndex;
            j = e.ColumnIndex;
            string value = Program.matriz[i,j];
            
            //dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;
            int pos = Program.PosEncontrado(value);
            int posP = Program.PosEncontradoPersonaje(comboBox1.Text);
            
            string mensaje = "Tipo: " + Program.terrenos[pos, 1] + ".\nCosto: " + Program.terrenos[pos, (3  +posP)];
            MessageBox.Show(mensaje, "Posición (" + (i + 1) + " , " + (j + 1) + ")",
            MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Program.inicio && Program.final)
            {
                dibujarNegro();
                dataGridView1.Rows[Program.inicioI].Cells[Program.inicioJ].Style.BackColor = Color.Indigo;
                dataGridView1.Rows[Program.finalI].Cells[Program.finalJ].Style.BackColor = Color.White;
                //dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Indigo;
                Program.jugando = true;
                Program.personajeJugando = comboBox1.Text;
                dataGridView1.GridColor = Color.White;
                
                Program.posicionI = Program.inicioI;
                Program.posicionJ = Program.inicioJ;

                Colorear();
                AddNode();

            }
            else
            {
                MessageBox.Show("No has terminado de configurar la partida","ERROR",
                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            

            

        }

        private void Mapa_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void dibujarNegro()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
                    dataGridView1.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Transparent;
                    dataGridView1.GridColor = Color.Black;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                }
            }
        }
        
        public void dibujar()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int x = Program.PosEncontrado(Program.matriz[i, j]);
                    dataGridView1.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
                    dataGridView1.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Transparent;

                    if (x != -1)
                    {
                        string y = Program.terrenos[x, 2];

                        if (y == "0")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Green;

                        }
                        else if (y == "1")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Blue;
                        }
                        else if (y == "2")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Orange;
                        }
                        else if (y == "3")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        }
                        else if (y == "4")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Yellow;
                        }
                        else if (y == "5")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Pink;
                        }
                        else if (y == "6")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Purple;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Purple;
                        }
                        else if (y == "7")
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        }
                        dataGridView1.GridColor = Color.Black;
                    }

                }
            }
        }

        private void Mapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Mapa_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Mapa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.jugando)
            {
                
                if (e.KeyData.ToString() == "Up")
                {

                    if (Program.posicionI > 0)
                    {
                        string value = Program.matriz[Program.posicionI - 1, Program.posicionJ];
                        //string value = dataGridView1.Rows[Program.posicionI-1].Cells[Program.posicionJ].Value.ToString();
                        int pos = Program.PosEncontrado(value);
                        int posP = Program.PosEncontradoPersonaje(value);
                        if(Program.terrenos[pos, 4 + posP] != "N/A")
                        {
                            Program.movimientos++;
                            Program.posicionI--;
                            Colorear();
                            AddNode();
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Value += (Program.movimientos + ",");
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                            if (Program.posicionI == Program.finalI && Program.posicionJ == Program.finalJ)
                            {
                                MessageBox.Show("¡FELICIDADES! \n Terminaste", "FINISH",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            }
                            
                        }
                        
                    }
                    
                }
                else if (e.KeyData.ToString() == "Down")
                {
                    if (Program.posicionI < Program.rows-1)
                    {
                        string value = Program.matriz[Program.posicionI+1, Program.posicionJ];
                        //string value = dataGridView1.Rows[Program.posicionI+1].Cells[Program.posicionJ].Value.ToString();
                        int pos = Program.PosEncontrado(value);
                        int posP = Program.PosEncontradoPersonaje(value);
                        if (Program.terrenos[pos, 4 + posP] != "N/A")
                        {
                            Program.movimientos++;
                            Program.posicionI++;
                            Colorear();
                            AddNode();
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Value += (Program.movimientos + ",");
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                            if (Program.posicionI == Program.finalI && Program.posicionJ == Program.finalJ)
                            {
                                MessageBox.Show("¡FELICIDADES! \n Terminaste", "FINISH",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            }
                           
                        }
                    }
                }
                else if (e.KeyData.ToString() == "Right")
                {
                    if (Program.posicionJ < Program.columns)
                    {
                       
                        string value = Program.matriz[Program.posicionI, (Program.posicionJ + 1)];
                        int pos = Program.PosEncontrado(value);
                        int posP = Program.PosEncontradoPersonaje(value);
                        if (Program.terrenos[pos, 4 + posP] != "N/A")
                        {
                            Program.movimientos++;
                            Program.posicionJ++;
                            Colorear();
                            AddNode();
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Value += (Program.movimientos + ",");
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                            if (Program.posicionI == Program.finalI && Program.posicionJ == Program.finalJ)
                            {
                                MessageBox.Show("¡FELICIDADES! \n Terminaste", "FINISH",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            }
                            
                        }
                    }
                }
                else if (e.KeyData.ToString() == "Left")
                {
                    if (Program.posicionJ > 0)
                    {
                        
                        string value = Program.matriz[Program.posicionI,(Program.posicionJ)-1];
                        int pos = Program.PosEncontrado(value);
                        int posP = Program.PosEncontradoPersonaje(value);
                        if (Program.terrenos[pos, 4 + posP] != "N/A")
                        {
                            Program.movimientos++;
                            Program.posicionJ--;
                            Colorear();
                            AddNode();
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Value += (Program.movimientos + ",");
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                            if (Program.posicionI == Program.finalI && Program.posicionJ == Program.finalJ)
                            {
                                MessageBox.Show("¡FELICIDADES! \n Terminaste", "FINISH",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            }
                           
                        }
                    }
                }
                else
                {
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            
                
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.inicio = false;
            Program.final = false;
            dibujar();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.reiniciar = true;
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private TreeNode GetNodeByName(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Name == searchtext)
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByName(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        private TreeNode GetNodeByText(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Text == searchtext)
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByText(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        public void Colorear()
        {
            if (Program.posicionI >= 0 && Program.posicionJ >= 0)
            {
                int x = Program.PosEncontrado(Program.matriz[Program.posicionI, Program.posicionJ]); //actual

                if (x != -1) // Actual
                {
                    string y = Program.terrenos[x, 2];

                    if (y == "0")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Green;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;

                    }
                    else if (y == "1")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Blue;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "2")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "3")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Red;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "4")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Yellow;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "5")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Pink;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "6")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Purple;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else if (y == "7")
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                        dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                    }
                    dataGridView1.GridColor = Color.Black;
                } 

                if (Program.posicionJ + 1 < 15)
                {
                    int x1 = Program.PosEncontrado(Program.matriz[Program.posicionI, Program.posicionJ + 1]); //izquierda

                    if (x1 != -1) //Izquierda
                    {
                        string y = Program.terrenos[x1, 2];

                        if (y == "0")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Green;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;

                        }
                        else if (y == "1")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Blue;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "2")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "3")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Red;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "4")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Yellow;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "5")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Pink;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "6")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Purple;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "7")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ + 1].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        dataGridView1.GridColor = Color.Black;
                    }

                }

                if (Program.posicionI + 1 < 15)
                {
                    
                    int x2 = Program.PosEncontrado(Program.matriz[Program.posicionI + 1, Program.posicionJ]); //abajo

                    if (x2 != -1) //Abajo
                    {
                        string y = Program.terrenos[x2, 2];

                        if (y == "0")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Green;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;

                        }
                        else if (y == "1")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Blue;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "2")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "3")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Red;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "4")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Yellow;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "5")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Pink;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "6")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Purple;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "7")
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI + 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        dataGridView1.GridColor = Color.Black;
                    }

                }

                if (Program.posicionJ -1 > 0 )
                {
                    
                    int x3 = Program.PosEncontrado(Program.matriz[Program.posicionI, Program.posicionJ - 1]); //Derecha
                    if (x3 != -1)
                    {
                        string y = Program.terrenos[x3, 2];

                        if (y == "0")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Green;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;

                        }
                        else if (y == "1")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Blue;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "2")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "3")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Red;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "4")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Yellow;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "5")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Pink;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "6")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Purple;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else if (y == "7")
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI].Cells[Program.posicionJ - 1].Style.ForeColor = Color.White;
                        }
                        dataGridView1.GridColor = Color.Black;
                    }

                }

                if (Program.posicionI -1 > 0)
                {
                    
                    int x4 = Program.PosEncontrado(Program.matriz[Program.posicionI - 1, Program.posicionJ]); //Arriba

                    if (x4 != -1)
                    {
                        string y = Program.terrenos[x4, 2];

                        if (y == "0")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Green;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;

                        }
                        else if (y == "1")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Blue;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "2")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "3")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Red;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "4")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Yellow;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "5")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Pink;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "6")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Purple;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else if (y == "7")
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.BackColor = Color.Black;
                            dataGridView1.Rows[Program.posicionI - 1].Cells[Program.posicionJ].Style.ForeColor = Color.White;
                        }
                        dataGridView1.GridColor = Color.Black;
                    }
                }
            }
        }

        public void AddNode()
        {
            treeView1.SelectedNode = GetNodeByText(treeView1.Nodes, "Nodo[" + Program.posicionI + "," + Program.posicionJ + "]");
            treeView1.SelectedNode.Nodes.Add("Nodo[" + Program.posicionI + "," + (Program.posicionJ + 1) + "]");
            treeView1.SelectedNode.Nodes.Add("Nodo[" + (Program.posicionI + 1) + "," + Program.posicionJ + "]");
            treeView1.SelectedNode.Nodes.Add("Nodo[" + Program.posicionI + "," + (Program.posicionJ - 1) + "]");
            treeView1.SelectedNode.Nodes.Add("Nodo[" + (Program.posicionI - 1) + "," + Program.posicionJ + "]");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
