using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class Form1 : Form
    {
        private string[] lines;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private string Sorteio(string[] sts)
        {
            Random random = new Random();
            return sts[random.Next(sts.Length)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                         lines = sr.ReadLine().Split(' ');
                        lblGanhador.Text += lines.ToString();
                    }

                    lblGanhador.Text = Sorteio(lines).ToString();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
