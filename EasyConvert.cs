using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyConvert.EasyConvert
{
    public partial class EasyConvert : Form
    {
        public EasyConvert()
        {
            InitializeComponent();
        }
        //Variáveis para controle do form
        bool MouseDwn;
        Point lastPt;
        ConvertClass CnClass = new ConvertClass();
        private void EasyConvert_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDwn = true;
            lastPt = e.Location;
        }

        private void EasyConvert_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDwn = false;
        }

        private void EasyConvert_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDwn)
            {
                this.Location = new Point(this.Location.X - lastPt.X + e.X, this.Location.Y - lastPt.Y + e.Y);
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Você deseja encerrar a aplicação?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EasyConvert_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Um projeto para a disciplina de [Aula]","Iniciando");
        }

        private void EasyConvert_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar os nossos serviços.","Encerrando . . .");
            MessageBox.Show("Volte sempre!!!","Obrigado!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sIn = cmbIn.Text;
            string sOut = cmbOut.Text;
            int iEntrada = 0;
            if ((sIn == null) || (sOut == null))
            {
                MessageBox.Show("Por favor, selecione um\n valor para converter(entrada) e um valor para saída.");
            }
            else if (txtValue.Text == "")
            {
                MessageBox.Show("Por favor, insira um valor de entrada.");
                txtValue.Focus();
            }
            else
                try
                {
                    iEntrada = Convert.ToInt32(txtValue.Text);

                }
                catch
                {
                    MessageBox.Show("Insira somente números compatíveis com\na base de entrada selecionada.");
                    txtValue.Focus();
                }
        }
    }
}
