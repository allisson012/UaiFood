namespace UaiFood.View
{
    partial class TelaPagamento
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
            lblItens = new Label();
            lblTotal = new Label();
            opDinheiro = new RadioButton();
            opCartao = new RadioButton();
            opPix = new RadioButton();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.BackColor = Color.Transparent;
            lblItens.Font = new Font("Segoe UI", 13F);
            lblItens.Location = new Point(1115, 334);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(22, 25);
            lblItens.TabIndex = 1;
            lblItens.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.Location = new Point(1081, 483);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "00,00";
            // 
            // opDinheiro
            // 
            opDinheiro.AutoSize = true;
            opDinheiro.BackColor = Color.Transparent;
            opDinheiro.Location = new Point(51, 277);
            opDinheiro.Name = "opDinheiro";
            opDinheiro.Size = new Size(14, 13);
            opDinheiro.TabIndex = 3;
            opDinheiro.TabStop = true;
            opDinheiro.UseVisualStyleBackColor = false;
            // 
            // opCartao
            // 
            opCartao.AutoSize = true;
            opCartao.BackColor = Color.Transparent;
            opCartao.Location = new Point(51, 334);
            opCartao.Name = "opCartao";
            opCartao.Size = new Size(14, 13);
            opCartao.TabIndex = 4;
            opCartao.TabStop = true;
            opCartao.UseVisualStyleBackColor = false;
            // 
            // opPix
            // 
            opPix.AutoSize = true;
            opPix.BackColor = Color.Transparent;
            opPix.Location = new Point(51, 388);
            opPix.Name = "opPix";
            opPix.Size = new Size(14, 13);
            opPix.TabIndex = 5;
            opPix.TabStop = true;
            opPix.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1208, 155);
            button2.Name = "button2";
            button2.Size = new Size(111, 43);
            button2.TabIndex = 23;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1263, 12);
            button4.Name = "button4";
            button4.Size = new Size(84, 75);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(296, 27);
            button1.Name = "button1";
            button1.Size = new Size(603, 45);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(76, 75);
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(1013, 578);
            button5.Name = "button5";
            button5.Size = new Size(194, 45);
            button5.TabIndex = 28;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // TelaPagamento
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPagamento;
            ClientSize = new Size(1350, 729);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(opPix);
            Controls.Add(opCartao);
            Controls.Add(opDinheiro);
            Controls.Add(lblTotal);
            Controls.Add(lblItens);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 766);
            Name = "TelaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItens;
        private Label lblTotal;
        private RadioButton opDinheiro;
        private RadioButton opCartao;
        private RadioButton opPix;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button5;
    }
}