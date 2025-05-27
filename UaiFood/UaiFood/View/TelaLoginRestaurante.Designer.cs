namespace UaiFood.View
{
    partial class TelaLoginRestaurante
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
            button1 = new Button();
            txtCNPJ = new MaskedTextBox();
            txtSenha = new TextBox();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(916, 44);
            button1.Name = "button1";
            button1.Size = new Size(234, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(217, 217, 217);
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.Location = new Point(641, 355);
            txtCNPJ.Margin = new Padding(3, 2, 3, 2);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(487, 22);
            txtCNPJ.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(641, 482);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(494, 22);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(900, 248);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(196, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clique aqui para se cadastrar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1049, 546);
            button2.Name = "button2";
            button2.Size = new Size(170, 48);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button3.Location = new Point(1217, 480);
            button3.Name = "button3";
            button3.Size = new Size(47, 28);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TelaLoginRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCadastroRestautrante;
            ClientSize = new Size(1350, 729);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(txtSenha);
            Controls.Add(txtCNPJ);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaLoginRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtCNPJ;
        private TextBox txtSenha;
        private LinkLabel linkLabel1;
        private Button button2;
        private Button button3;
    }
}