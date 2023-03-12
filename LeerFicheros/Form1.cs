using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LeerFicheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




            private void button1_Click(object sender, EventArgs e)
            {
            string path = @"C:\Users\Raul\source\repos\escribirFicheros\escribirFicheros\bin\Debug\net6.0-windows\tecleado.txt";
                int lineNumber = 1;

                // Abrimos el archivo con un objeto StreamReader
                using (StreamReader reader = File.OpenText(path))
                {
                    string line;
                    while (  lineNumber <= 3 && (line = reader.ReadLine()) != null)
                {

                    label1.Text += line + Environment.NewLine;
                    lineNumber++;
                    }
                }
            Console.ReadLine();
            // MessageBox.Show("Se han leído las tres primeras líneas del archivo.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


