namespace UaiFood.View
{
    partial class TelaEditarPerfilCliente
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
            txtNome = new TextBox();
            txtCpf = new MaskedTextBox();
            txtDataNascimento = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtCep = new MaskedTextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            picturePerfil = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(324, 183);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 22);
            txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ControlLight;
            txtCpf.BorderStyle = BorderStyle.None;
            txtCpf.Font = new Font("Segoe UI", 12F);
            txtCpf.Location = new Point(324, 288);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(350, 22);
            txtCpf.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.BackColor = SystemColors.ControlLight;
            txtDataNascimento.BorderStyle = BorderStyle.None;
            txtDataNascimento.Font = new Font("Segoe UI", 12F);
            txtDataNascimento.Location = new Point(324, 394);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(107, 22);
            txtDataNascimento.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.ControlLight;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 12F);
            txtTelefone.Location = new Point(324, 501);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 22);
            txtTelefone.TabIndex = 11;
            // 
            // txtCep
            // 
            txtCep.BackColor = SystemColors.ControlLight;
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Segoe UI", 12F);
            txtCep.Location = new Point(860, 183);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(124, 22);
            txtCep.TabIndex = 12;
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ControlLight;
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Segoe UI", 12F);
            txtRua.Location = new Point(860, 288);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(393, 22);
            txtRua.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Segoe UI", 12F);
            txtNumero.Location = new Point(860, 394);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(81, 22);
            txtNumero.TabIndex = 14;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLight;
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Segoe UI", 12F);
            txtCidade.Location = new Point(860, 501);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(393, 22);
            txtCidade.TabIndex = 15;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(860, 605);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(393, 22);
            txtEstado.TabIndex = 16;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.FotoPerfil;
            picturePerfil.Location = new Point(77, 148);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(191, 235);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 17;
            picturePerfil.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(77, 391);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(93, 431);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(93, 480);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 45);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = false;
            // 
            // TelaEditarPerfilCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaEditarPerfilUsuario;
            ClientSize = new Size(1350, 729);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(picturePerfil);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtCep);
            Controls.Add(txtTelefone);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaEditarPerfilCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtDataNascimento;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCep;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private PictureBox picturePerfil;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}