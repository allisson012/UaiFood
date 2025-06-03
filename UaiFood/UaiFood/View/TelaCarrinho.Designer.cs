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
            // TelaCarrinho
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCarrinho;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
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
    }
}