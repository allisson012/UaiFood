namespace UaiFood.View
{
    partial class TelaPesquisa
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
            cbFiltro = new ComboBox();
            txtPesquisa = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            flowPanelProdutos = new FlowLayoutPanel();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(813, 41);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.Font = new Font("Segoe UI", 15F);
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Items.AddRange(new object[] { "Restaurante ", "Produtos" });
            cbFiltro.Location = new Point(159, 112);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(144, 36);
            cbFiltro.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.FromArgb(217, 217, 217);
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Font = new Font("Segoe UI", 15F);
            txtPesquisa.Location = new Point(244, 48);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(535, 27);
            txtPesquisa.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(81, 69);
            button2.TabIndex = 4;
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
            button3.Location = new Point(1009, 32);
            button3.Name = "button3";
            button3.Size = new Size(53, 49);
            button3.TabIndex = 5;
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
            button4.Location = new Point(1270, 12);
            button4.Name = "button4";
            button4.Size = new Size(68, 69);
            button4.TabIndex = 6;
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
            button5.Location = new Point(1098, 32);
            button5.Name = "button5";
            button5.Size = new Size(123, 43);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // flowPanelProdutos
            // 
            flowPanelProdutos.AutoScroll = true;
            flowPanelProdutos.BackColor = Color.White;
            flowPanelProdutos.Location = new Point(-3, 154);
            flowPanelProdutos.Name = "flowPanelProdutos";
            flowPanelProdutos.Size = new Size(1354, 576);
            flowPanelProdutos.TabIndex = 8;
            flowPanelProdutos.Paint += flowPanelProdutos_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.icons8_código_qr_80__1_;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(99, 23);
            button6.Name = "button6";
            button6.Size = new Size(62, 52);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // TelaPesquisa
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPesquisa1;
            ClientSize = new Size(1350, 729);
            Controls.Add(button6);
            Controls.Add(flowPanelProdutos);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtPesquisa);
            Controls.Add(cbFiltro);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "TelaPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaPesquisa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbFiltro;
        private TextBox txtPesquisa;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel flowPanelProdutos;
        private Button button6;
    }
}