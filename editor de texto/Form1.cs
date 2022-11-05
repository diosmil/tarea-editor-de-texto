using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace editor_de_texto
{
    public partial class Form1 : Form
    {
        string archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void deshaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto |*.txt";


            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                archivo = OpenFile.FileName;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }




        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto |*.txt";


            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = SaveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }

            }
        }


        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
} 
