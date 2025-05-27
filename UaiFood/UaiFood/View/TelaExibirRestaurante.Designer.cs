namespace UaiFood.View
{
    partial class TelaExibirRestaurante
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
            lblNome = new Label();
            lblTelefone = new Label();
            lblCep = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            lblRua = new Label();
            lblNumero = new Label();
            picturePerfil = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(301, 36);
            button1.Name = "button1";
            button1.Size = new Size(591, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(284, 215);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 21);
            lblNome.TabIndex = 9;
            lblNome.Text = "label1";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(284, 314);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(52, 21);
            lblTelefone.TabIndex = 10;
            lblTelefone.Text = "label1";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Segoe UI", 12F);
            lblCep.Location = new Point(284, 401);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(52, 21);
            lblCep.TabIndex = 11;
            lblCep.Text = "label1";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Segoe UI", 12F);
            lblCidade.Location = new Point(284, 492);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(52, 21);
            lblCidade.TabIndex = 12;
            lblCidade.Text = "label1";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(284, 597);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(52, 21);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "label1";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.BackColor = Color.Transparent;
            lblRua.Font = new Font("Segoe UI", 12F);
            lblRua.Location = new Point(763, 401);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(52, 21);
            lblRua.TabIndex = 14;
            lblRua.Text = "label1";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(763, 492);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(52, 21);
            lblNumero.TabIndex = 15;
            lblNumero.Text = "label1";
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.restaurante;
            picturePerfil.Location = new Point(23, 152);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(222, 248);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 19;
            picturePerfil.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(44, 432);
            button2.Name = "button2";
            button2.Size = new Size(167, 36);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TelaExibirRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaExibirRestaurante1;
            ClientSize = new Size(1350, 729);
            Controls.Add(button2);
            Controls.Add(picturePerfil);
            Controls.Add(lblNumero);
            Controls.Add(lblRua);
            Controls.Add(lblEstado);
            Controls.Add(lblCidade);
            Controls.Add(lblCep);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "TelaExibirRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaExibirRestaurante_Load;
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblCep;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblRua;
        private Label lblNumero;
        private PictureBox picturePerfil;
        private Button button2;
    }
}