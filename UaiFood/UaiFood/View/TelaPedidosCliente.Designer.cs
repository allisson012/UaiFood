namespace UaiFood.View
{
    partial class TelaPedidosCliente
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            flowPanelPedidos = new FlowLayoutPanel();
            lblItens = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1203, 157);
            button3.Name = "button3";
            button3.Size = new Size(122, 37);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(982, 32);
            button1.Name = "button1";
            button1.Size = new Size(55, 49);
            button1.TabIndex = 7;
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
            button2.Location = new Point(1275, 12);
            button2.Name = "button2";
            button2.Size = new Size(63, 69);
            button2.TabIndex = 8;
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
            button4.Location = new Point(271, 36);
            button4.Name = "button4";
            button4.Size = new Size(588, 40);
            button4.TabIndex = 9;
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
            button5.Size = new Size(75, 69);
            button5.TabIndex = 10;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // flowPanelPedidos
            // 
            flowPanelPedidos.AutoScroll = true;
            flowPanelPedidos.BackColor = Color.FromArgb(228, 228, 228);
            flowPanelPedidos.FlowDirection = FlowDirection.TopDown;
            flowPanelPedidos.Location = new Point(30, 146);
            flowPanelPedidos.Name = "flowPanelPedidos";
            flowPanelPedidos.Size = new Size(840, 560);
            flowPanelPedidos.TabIndex = 11;
            flowPanelPedidos.WrapContents = false;
            flowPanelPedidos.Paint += flowPanelPedidos_Paint;
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.BackColor = Color.Transparent;
            lblItens.Font = new Font("Segoe UI", 13F);
            lblItens.Location = new Point(1236, 316);
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
            lblTotal.Location = new Point(1037, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "00,00";
            // 
            // TelaPedidosCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPedidosCliente;
            ClientSize = new Size(1350, 729);
            Controls.Add(lblTotal);
            Controls.Add(lblItens);
            Controls.Add(flowPanelPedidos);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaPedidosCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaPedidosCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private FlowLayoutPanel flowPanelPedidos;
        private Label lblItens;
        private Label lblTotal;
    }
}