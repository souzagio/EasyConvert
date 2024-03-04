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

            string result = "";

            string input = cmbIn.Text;
            string output = cmbOut.Text;
            if(input == output)
            {
                MessageBox.Show("Escolha tipos diferentes para entrada e saída.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            //Check In
            switch(input)
            {
                case "Decimal":
                    result = Med.DecToBin(Convert.ToInt16(txtValue.Text));
                    break;
                case "Binário":
                    result = txtValue.Text;
                    break;
                case "Octal":
                    result = Med.OctaToBin(txtValue.Text).ToUpper();
                    break;
                case "HexDecimal":
                    result = Med.HexToBin(txtValue.Text).ToUpper();
                    break;
                default:
                    MessageBox.Show("Por favor, selecione um dos tipo de entrada e saída válidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show(input);
                    LimparTxt();
                    break;
                    
            }
            switch (output)
            {
                case "Decimal":
                    result = Med.BinToDec(result);
                    txtResult.Text = result;
                    break;
                case "Binário":
                    txtResult.Text = result;
                    break;
                case "Octal":
                    result = Med.BinToOcta(result).ToUpper();
                    txtResult.Text = result;
                    break;
                case "HexDecimal":
                    result = Med.BinToHex(result).ToUpper();
                    txtResult.Text = result;
                    break;
                default:
                    MessageBox.Show("Por favor, selecione um dos tipos válidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparTxt();
                    break;
            }
            //LimparTxt();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //ArrayTest frm = new ArrayTest();
            //frm.Show();
        }

        //Métodos
        void LimparTxt()
        {
            txtValue.Clear();
            txtValue.Focus();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
            button1.ForeColor = Color.Black;
            button1.Width = 384;
            button1.Height = 30;
            button1.Location = new System.Drawing.Point(215, 198);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.WindowFrame;
            button1.ForeColor = Color.White;
            button1.Width = 420;
            button1.Height = 45;
            button1.Location = new System.Drawing.Point(199, 186);
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
