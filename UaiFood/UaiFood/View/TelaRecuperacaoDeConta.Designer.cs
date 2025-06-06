namespace UaiFood.View
{
    partial class TelaRecuperacaoDeConta
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
            txtEmail = new TextBox();
            txtCodigo = new TextBox();
            txtSenha = new TextBox();
            txtRepete = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(239, 239, 239);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 16F);
            txtEmail.Location = new Point(131, 237);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(366, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(239, 239, 239);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Segoe UI", 16F);
            txtCodigo.Location = new Point(131, 317);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(366, 29);
            txtCodigo.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(239, 239, 239);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 16F);
            txtSenha.Location = new Point(131, 396);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(366, 29);
            txtSenha.TabIndex = 9;
            // 
            // txtRepete
            // 
            txtRepete.BackColor = Color.FromArgb(239, 239, 239);
            txtRepete.BorderStyle = BorderStyle.None;
            txtRepete.Font = new Font("Segoe UI", 16F);
            txtRepete.Location = new Point(131, 478);
            txtRepete.Margin = new Padding(3, 2, 3, 2);
            txtRepete.Name = "txtRepete";
            txtRepete.Size = new Size(366, 29);
            txtRepete.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(250, 544);
            button3.Name = "button3";
            button3.Size = new Size(135, 32);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TelaRecuperacaoDeConta
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Salvar_nova_senha;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(633, 696);
            Controls.Add(button3);
            Controls.Add(txtRepete);
            Controls.Add(txtSenha);
            Controls.Add(txtCodigo);
            Controls.Add(txtEmail);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(649, 735);
            MinimumSize = new Size(649, 735);
            Name = "TelaRecuperacaoDeConta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaRecuperacaoDeConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtCodigo;
        private TextBox txtSenha;
        private TextBox txtRepete;
        private Button button3;
    }
}