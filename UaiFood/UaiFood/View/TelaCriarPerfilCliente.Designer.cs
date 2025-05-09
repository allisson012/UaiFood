namespace UaiFood.View
{
    partial class TelaCriarPerfilCliente
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
            picturePerfil = new PictureBox();
            button1 = new Button();
            txtNome = new TextBox();
            txtCpf = new MaskedTextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtCep = new MaskedTextBox();
            txtDataNascimento = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.FotoPerfil;
            picturePerfil.Location = new Point(77, 148);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(191, 235);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 0;
            picturePerfil.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(77, 387);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(327, 181);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 22);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ControlLight;
            txtCpf.BorderStyle = BorderStyle.None;
            txtCpf.Font = new Font("Segoe UI", 12F);
            txtCpf.Location = new Point(327, 286);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(350, 22);
            txtCpf.TabIndex = 3;
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ControlLight;
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Segoe UI", 12F);
            txtRua.Location = new Point(857, 293);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(393, 22);
            txtRua.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Segoe UI", 12F);
            txtNumero.Location = new Point(857, 394);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(81, 22);
            txtNumero.TabIndex = 5;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLight;
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Segoe UI", 12F);
            txtCidade.Location = new Point(857, 496);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(393, 22);
            txtCidade.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(857, 604);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(393, 22);
            txtEstado.TabIndex = 7;
            // 
            // txtCep
            // 
            txtCep.BackColor = SystemColors.ControlLight;
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Segoe UI", 12F);
            txtCep.Location = new Point(857, 181);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(159, 22);
            txtCep.TabIndex = 8;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.BackColor = SystemColors.ControlLight;
            txtDataNascimento.BorderStyle = BorderStyle.None;
            txtDataNascimento.Font = new Font("Segoe UI", 12F);
            txtDataNascimento.Location = new Point(327, 394);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(350, 22);
            txtDataNascimento.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.ControlLight;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(327, 489);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(350, 22);
            txtTelefone.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(103, 442);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TelaCriarPerfilCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCriarPerfilCliente1;
            ClientSize = new Size(1350, 729);
            Controls.Add(button2);
            Controls.Add(txtTelefone);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCep);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Controls.Add(picturePerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaCriarPerfilCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturePerfil;
        private Button button1;
        private TextBox txtNome;
        private MaskedTextBox txtCpf;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private MaskedTextBox txtCep;
        private MaskedTextBox txtDataNascimento;
        private MaskedTextBox txtTelefone;
        private Button button2;
    }
}