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
        Intermed Med = new Intermed();
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
            if(txtValue.Text == "")
            {
                MessageBox.Show("Por favor, insira um valor válido\n contido na base de entrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTxt();
                return;
            }
            //string result = Med.DecToBin(Convert.ToInt32(txtValue.Text));
            //string result = Med.BinToDec(txtValue.Text);
            string result = Med.OctaToBin(txtValue.Text);
            txtResult.Text = result;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ArrayTest frm = new ArrayTest();
            frm.Show();
        }

        //Métodos
        void LimparTxt()
        {
            txtValue.Clear();
            txtValue.Focus();
        }
    }
}
