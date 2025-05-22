namespace UaiFood.View
{
    partial class TelaEditarPerfilRestaurante
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
            button2 = new Button();
            button3 = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCep = new MaskedTextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.restaurante;
            picturePerfil.Location = new Point(77, 145);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(191, 239);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 19;
            picturePerfil.TabStop = false;
            picturePerfil.Click += picturePerfil_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(77, 388);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(93, 432);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 21;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(93, 481);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(104, 37);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(324, 186);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(421, 22);
            txtNome.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(324, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(421, 22);
            txtEmail.TabIndex = 24;
            // 
            // txtCep
            // 
            txtCep.BackColor = SystemColors.ControlLight;
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Microsoft Sans Serif", 12F);
            txtCep.Location = new Point(324, 399);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(133, 19);
            txtCep.TabIndex = 25;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLight;
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Microsoft Sans Serif", 12F);
            txtCidade.Location = new Point(324, 488);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(393, 19);
            txtCidade.TabIndex = 26;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Microsoft Sans Serif", 12F);
            txtEstado.Location = new Point(324, 595);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(393, 19);
            txtEstado.TabIndex = 27;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.ControlLight;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefone.Location = new Point(807, 292);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 19);
            txtTelefone.TabIndex = 28;
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ControlLight;
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Microsoft Sans Serif", 12F);
            txtRua.Location = new Point(807, 399);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(393, 19);
            txtRua.TabIndex = 29;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Microsoft Sans Serif", 12F);
            txtNumero.Location = new Point(807, 488);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(393, 19);
            txtNumero.TabIndex = 30;
            // 
            // TelaEditarPerfilRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaEditarPerfilRestaurante;
            ClientSize = new Size(1350, 729);
            Controls.Add(txtNumero);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtCep);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(picturePerfil);
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 766);
            Name = "TelaEditarPerfilRestaurante";
            Text = "UaiFood";
            Load += TelaEditarPerfilRestaurante_Load;
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturePerfil;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox txtCep;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private MaskedTextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtNumero;
    }
}