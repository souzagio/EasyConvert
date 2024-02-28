using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyConvert
{
    public partial class ArrayTest : Form
    {
        public ArrayTest()
        {
            InitializeComponent();
            cores = new List<string>() { "Azul", "Preto", "Amarelo" };
        }
        private List<string> cores;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            
            string novoValor = "";

            if (textBox1.Text != "" && string.IsNullOrEmpty(novoValor))
            {
                novoValor = textBox1.Text;
                cores.Add(novoValor);
                novoValor = "";
            }
            
            foreach(var item in cores)
            {
                textBox2.Lines = textBox2.Lines.Concat(new[] { item.ToString() }).ToArray();
            }
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
