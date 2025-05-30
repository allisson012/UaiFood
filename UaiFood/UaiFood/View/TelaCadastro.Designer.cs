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
            linkLabel1 = new LinkLabel();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(855, 45);
            button1.Name = "button1";
            button1.Size = new Size(300, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(637, 315);
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
            txtSenha.Location = new Point(637, 395);
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
            txtRepeteSenha.Location = new Point(637, 483);
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
            button2.Location = new Point(973, 410);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(158, 35);
            button2.TabIndex = 9;
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
            button3.Location = new Point(1113, 545);
            button3.Name = "button3";
            button3.Size = new Size(172, 47);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(917, 216);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Já possui conta?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.olho;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1238, 437);
            button4.Name = "button4";
            button4.Size = new Size(47, 28);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCadastro;
            ClientSize = new Size(1350, 729);
            Controls.Add(button4);
            Controls.Add(linkLabel1);
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
            Load += TelaCadastro_Load;
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
        private LinkLabel linkLabel1;
        private Button button4;
    }
}