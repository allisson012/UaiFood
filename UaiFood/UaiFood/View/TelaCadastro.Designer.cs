﻿namespace UaiFood.View
{
    partial class TelaCadastro
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtRepeteSenha = new TextBox();
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
            button1.Location = new Point(744, 26);
            button1.Name = "button1";
            button1.Size = new Size(273, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(646, 314);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 22);
            txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(217, 217, 217);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(646, 399);
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
            txtRepeteSenha.Location = new Point(646, 480);
            txtRepeteSenha.Margin = new Padding(3, 2, 3, 2);
            txtRepeteSenha.Name = "txtRepeteSenha";
            txtRepeteSenha.Size = new Size(494, 22);
            txtRepeteSenha.TabIndex = 8;
            txtRepeteSenha.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(963, 410);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(168, 35);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1113, 543);
            button3.Name = "button3";
            button3.Size = new Size(170, 52);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaCadastro;
            ClientSize = new Size(1350, 729);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtRepeteSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtRepeteSenha;
        private Button button2;
        private Button button3;
    }
}