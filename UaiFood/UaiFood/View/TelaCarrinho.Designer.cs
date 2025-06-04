namespace UaiFood.View
{
    partial class TelaCarrinho
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
            flowPanelCarrinho = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.BackColor = Color.Transparent;
            lblItens.Font = new Font("Segoe UI", 13F);
            lblItens.Location = new Point(1089, 299);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(22, 25);
            lblItens.TabIndex = 0;
            lblItens.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.Location = new Point(1055, 440);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "00,00";
            // 
            // flowPanelCarrinho
            // 
            flowPanelCarrinho.BackColor = Color.FromArgb(228, 228, 228);
            flowPanelCarrinho.Location = new Point(21, 212);
            flowPanelCarrinho.Name = "flowPanelCarrinho";
            flowPanelCarrinho.Size = new Size(809, 492);
            flowPanelCarrinho.TabIndex = 2;
            flowPanelCarrinho.Paint += flowPanelCarrinho_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(950, 540);
            button1.Name = "button1";
            button1.Size = new Size(271, 55);
            button1.TabIndex = 21;
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
            button2.Location = new Point(1178, 129);
            button2.Name = "button2";
            button2.Size = new Size(111, 43);
            button2.TabIndex = 22;
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
            button3.Location = new Point(1255, 12);
            button3.Name = "button3";
            button3.Size = new Size(69, 64);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(292, 31);
            button4.Name = "button4";
            button4.Size = new Size(603, 45);
            button4.TabIndex = 24;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(75, 64);
            button5.TabIndex = 25;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(1081, 31);
            button6.Name = "button6";
            button6.Size = new Size(126, 45);
            button6.TabIndex = 26;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // TelaCarrinho
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCarrinho;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowPanelCarrinho);
            Controls.Add(lblTotal);
            Controls.Add(lblItens);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 766);
            Name = "TelaCarrinho";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaCarrinho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItens;
        private Label lblTotal;
        private FlowLayoutPanel flowPanelCarrinho;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}