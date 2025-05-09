namespace UaiFood.View
{
    partial class TelaCriarPerfilRestaurante
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
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtCep = new MaskedTextBox();
            txtCidade = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtEstado = new TextBox();
            button2 = new Button();
            button1 = new Button();
            picturePerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(327, 184);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 22);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(327, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(421, 22);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.ControlLight;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefone.Location = new Point(805, 287);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 19);
            txtTelefone.TabIndex = 10;
            // 
            // txtCep
            // 
            txtCep.BackColor = SystemColors.ControlLight;
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Microsoft Sans Serif", 12F);
            txtCep.Location = new Point(327, 395);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(159, 19);
            txtCep.TabIndex = 11;
            txtCep.Leave += txtCep_Leave;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLight;
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Microsoft Sans Serif", 12F);
            txtCidade.Location = new Point(327, 485);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(393, 19);
            txtCidade.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Microsoft Sans Serif", 12F);
            txtNumero.Location = new Point(805, 485);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(393, 19);
            txtNumero.TabIndex = 13;
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ControlLight;
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Microsoft Sans Serif", 12F);
            txtRua.Location = new Point(805, 395);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(393, 19);
            txtRua.TabIndex = 14;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Microsoft Sans Serif", 12F);
            txtEstado.Location = new Point(327, 596);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(393, 19);
            txtEstado.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(104, 441);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Size = new Size(30, 30);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.restaurante;
            picturePerfil.Location = new Point(77, 148);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(191, 239);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 18;
            picturePerfil.TabStop = false;
            // 
            // TelaCriarPerfilRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCriarPerfilRestaurante;
            ClientSize = new Size(1350, 729);
            Controls.Add(picturePerfil);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txtEstado);
            Controls.Add(txtRua);
            Controls.Add(txtNumero);
            Controls.Add(txtCidade);
            Controls.Add(txtCep);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaCriarPerfilRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCep;
        private TextBox txtCidade;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtEstado;
        private Button button2;
        private Button button1;
        private PictureBox picturePerfil;
    }
}