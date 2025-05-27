namespace UaiFood.View
{
    partial class TelaCadastroRestaurante
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
            txtCNPJ = new MaskedTextBox();
            button1 = new Button();
            txtSenha = new TextBox();
            txtRepeteSenha = new TextBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(217, 217, 217);
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.Location = new Point(628, 330);
            txtCNPJ.Margin = new Padding(3, 2, 3, 2);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(451, 22);
            txtCNPJ.TabIndex = 0;
            txtCNPJ.MaskInputRejected += txtCNPJ_MaskInputRejected;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(910, 40);
            button1.Name = "button1";
            button1.Size = new Size(245, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(628, 416);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(494, 22);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtRepeteSenha.BorderStyle = BorderStyle.None;
            txtRepeteSenha.Font = new Font("Segoe UI", 12F);
            txtRepeteSenha.Location = new Point(628, 501);
            txtRepeteSenha.Margin = new Padding(3, 2, 3, 2);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(494, 22);
            txtRepeteSenha.TabIndex = 9;
            txtRepeteSenha.UseSystemPasswordChar = true;
            txtRepeteSenha.TextChanged += txtRepeteSenha_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1099, 540);
            button2.Name = "button2";
            button2.Size = new Size(167, 40);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(1029, 247);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Já possui conta?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.olho;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1219, 451);
            button3.Name = "button3";
            button3.Size = new Size(47, 28);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TelaCadastroRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCadastroRestaurante;
            ClientSize = new Size(1350, 729);
            Controls.Add(button3);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(txtRepeteSenha);
            Controls.Add(txtSenha);
            Controls.Add(button1);
            Controls.Add(txtCNPJ);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaCadastroRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaCadastroRestaurante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCNPJ;
        private Button button1;
        private TextBox txtSenha;
        private Button button2;
        private TextBox txtRepeteSenha;
        private LinkLabel linkLabel1;
        private Button button3;
    }
}