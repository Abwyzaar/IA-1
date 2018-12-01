using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_World
{
    static class Program
    {
        public static bool ya = false;
        public static bool continuar = false;
        public static bool continuar2 = false;
        public static bool errorFile = false;
        public static bool continuar3 = false;
        public static string[,] matriz = new string[15, 15];
        public static int terre = 0;
        public static string[,] terrenos = new string[10,8];  //id, nombre, color, costo1, costo2...costo5
        public static string path = null;
        public static int rows = 0;
        public static int columns = 0;
        public static int columnsOrg = 0;
        public static string[] personajes = new string[5];
        public static int cantidadPersonajes = new int();
        public static bool jugando = false;
        public static string personajeJugando;
        public static bool reiniciar = false;
        public static int movimientos = 0;
        public static int inicioI = 0;
        public static int inicioJ = 0;
        public static int posicionI = 0;
        public static int posicionJ = 0;
        public static bool inicio = false;
        public static bool final = false;
        public static int finalI = 0;
        public static int finalJ = 0;
        public static int[] columnasEncontradas = new int[15];
        public static int[] rowsEncontrados = new int[15];
        public static int auxColumnas2 = 10000;
        public static int auxRows2 = 10000;
        public static int auxColumnas = 0;
        public static int auxRows = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inicio();
            
        }

        public static void Inicio()
        {
            
            Application.Run(new Inicio());

            if (continuar)
            {
                Application.Run(new Terrenos());
                if (continuar2)
                {
                    Application.Run(new Personajes());
                    if (continuar3)
                    {
                        Application.Run(new Mapa());
                        if (reiniciar)
                        {
                            Reiniciar();
                            do
                            {
                                Reiniciar();
                                Application.Run(new Mapa());
                            } while (reiniciar);
                        }
                    }
                }
            }
        }

        public static void leerArchivo()
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            rows = 0;
            foreach (string line in lines)
            {
                columns = 0;
                // Use a tab to indent each line of the file.
                foreach (char a in line)
                {
                    
                    if (a != ',' && a != '\n')
                    {
                        matriz[rows, columns] += a;
                    }
                    else
                    {
                        columns++;
                    }

                }
                if(rows == 0)
                {
                    
                    columnsOrg = columns;
                }
               
                columnasEncontradas[rows] = columns;
               
                rows++;
            }
            rows = lines.Length;

            for(int i = 0; i < rows; i++)
            {
                if(columnasEncontradas[i] != columnsOrg)
                {
                    errorFile = true;
                    MessageBox.Show("Error al abrir el archivo", "ERROR",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                    break;
                }
            }

        }

        public static void TerrenosEncontrados()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (PosEncontrado(matriz[i, j]) == -1)
                    {
                        terrenos[terre,0] = matriz[i, j];
                        terre++;
                    }
                }
            }
        }

        public static int PosEncontrado(string x)
        {
            for (int i = 0; i < Program.terre; i++)
            {
                if (Program.terrenos[i,0] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int PosEncontradoPersonaje(string x)
        {
            for (int i = 0; i < Program.cantidadPersonajes; i++)
            {
                
                if (Program.personajes[i] == x)
                {
                    
                    return i;
                }
            }
            return -1;
        }

        public static void Reiniciar()
        {

            jugando = false;
            personajeJugando = null ;
            movimientos = 0;
            inicioI = 0;
            inicioJ = 0;
            posicionI = 0;
            posicionJ = 0;
            inicio = false;
            final = false;
            finalI = 0;
            finalJ = 0;
            reiniciar = false;
    }
    }
}
