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
            textBox1 = new TextBox();
            txtSenha = new TextBox();
            txtRepeteSenha = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(217, 217, 217);
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.Location = new Point(628, 327);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(515, 27);
            txtCNPJ.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(909, 39);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(258, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(628, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(565, 27);
            textBox1.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(628, 467);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(565, 27);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtRepeteSenha
            // 
            txtRepeteSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtRepeteSenha.BorderStyle = BorderStyle.None;
            txtRepeteSenha.Font = new Font("Segoe UI", 12F);
            txtRepeteSenha.Location = new Point(628, 550);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(565, 27);
            txtRepeteSenha.TabIndex = 9;
            txtRepeteSenha.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1095, 593);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(173, 46);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TelaCadastroRestaurante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaLoginRestaurante;
            ClientSize = new Size(1348, 721);
            Controls.Add(button2);
            Controls.Add(txtRepeteSenha);
            Controls.Add(txtSenha);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(txtCNPJ);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private TextBox textBox1;
        private TextBox txtSenha;
        private Button button2;
        private TextBox txtRepeteSenha;
    }
}