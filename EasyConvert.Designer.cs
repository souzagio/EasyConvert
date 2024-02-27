namespace EasyConvert.EasyConvert
{
    partial class EasyConvert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbIn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lvlIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbOut = new System.Windows.Forms.ComboBox();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Navy;
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(642, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(179, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bin, Dec, Oct, Hex Conversor";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(329, 109);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(270, 23);
            this.txtValue.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValue.Location = new System.Drawing.Point(215, 109);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(63, 19);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Valor:";
            // 
            // cmbIn
            // 
            this.cmbIn.FormattingEnabled = true;
            this.cmbIn.Items.AddRange(new object[] {
            "Decimal",
            "Binário",
            "HexDecimal",
            "Octal"});
            this.cmbIn.Location = new System.Drawing.Point(329, 147);
            this.cmbIn.Name = "cmbIn";
            this.cmbIn.Size = new System.Drawing.Size(91, 23);
            this.cmbIn.TabIndex = 5;
            this.cmbIn.Text = "Decimal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(215, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(176, 356);
            this.panelMenu.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 280);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(174, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sair";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 210);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(174, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "O outro do outro";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 140);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(174, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Outro Mano";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(0, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(174, 70);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Gabriel Cunha";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(174, 70);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Giovany Souza";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lvlIn
            // 
            this.lvlIn.AutoSize = true;
            this.lvlIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvlIn.Location = new System.Drawing.Point(215, 151);
            this.lvlIn.Name = "lvlIn";
            this.lvlIn.Size = new System.Drawing.Size(90, 19);
            this.lvlIn.TabIndex = 8;
            this.lvlIn.Text = "Entrada :";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOut.Location = new System.Drawing.Point(430, 151);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(72, 19);
            this.lblOut.TabIndex = 9;
            this.lblOut.Text = "Saída :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Location = new System.Drawing.Point(215, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(108, 19);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Resultado :";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(329, 249);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(270, 23);
            this.txtResult.TabIndex = 11;
            // 
            // cmbOut
            // 
            this.cmbOut.FormattingEnabled = true;
            this.cmbOut.Items.AddRange(new object[] {
            "Decimal",
            "Binário",
            "HexDecimal",
            "Octal"});
            this.cmbOut.Location = new System.Drawing.Point(508, 147);
            this.cmbOut.Name = "cmbOut";
            this.cmbOut.Size = new System.Drawing.Size(91, 23);
            this.cmbOut.TabIndex = 13;
            this.cmbOut.Text = "Binário";
            // 
            // EasyConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(642, 436);
            this.ControlBox = false;
            this.Controls.Add(this.cmbOut);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lvlIn);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbIn);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasyConvert";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyConvert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EasyConvert_FormClosing);
            this.Load += new System.EventHandler(this.EasyConvert_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EasyConvert_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EasyConvert_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EasyConvert_MouseUp);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelTitleBar;
        private Label lblTitle;
        private TextBox txtValue;
        private Label lblValue;
        private ComboBox cmbIn;
        private Button button1;
        private Panel panelMenu;
        private Button button3;
        private Button button2;
        private Button btnLogin;
        private Button btnHome;
        private Button button4;
        private Label lvlIn;
        private Label lblOut;
        private Label lblResult;
        private TextBox txtResult;
        private ComboBox cmbOut;
    }
}