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
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            txtSenha = new TextBox();
            txtRepeteSenha = new TextBox();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(217, 217, 217);
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(623, 332);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "00,000,000/0000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(451, 22);
            maskedTextBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(909, 41);
            button1.Name = "button1";
            button1.Size = new Size(255, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(623, 400);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 22);
            textBox1.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(623, 471);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(494, 22);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtRepeteSenha.BorderStyle = BorderStyle.None;
            txtRepeteSenha.Font = new Font("Segoe UI", 12F);
            txtRepeteSenha.Location = new Point(623, 556);
            txtRepeteSenha.Margin = new Padding(3, 2, 3, 2);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(494, 22);
            txtRepeteSenha.TabIndex = 8;
            txtRepeteSenha.UseSystemPasswordChar = true;
            txtRepeteSenha.TextChanged += txtRepeteSenha_TextChanged;
            // 
            // TelaCadastroRestaurante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaLoginRestaurante;
            ClientSize = new Size(1350, 729);
            Controls.Add(txtRepeteSenha);
            Controls.Add(txtSenha);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaCadastroRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaCadastroRestaurante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox txtSenha;
        private TextBox txtRepeteSenha;
    }
}