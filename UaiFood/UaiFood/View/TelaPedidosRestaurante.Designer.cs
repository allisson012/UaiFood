namespace UaiFood.View
{
    partial class TelaPedidosRestaurante
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            flowPanelPedidos = new FlowLayoutPanel();
            lblItens = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(926, 32);
            button2.Name = "button2";
            button2.Size = new Size(165, 40);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(508, 32);
            button1.Name = "button1";
            button1.Size = new Size(342, 40);
            button1.TabIndex = 4;
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
            button3.Location = new Point(1202, 154);
            button3.Name = "button3";
            button3.Size = new Size(122, 40);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // flowPanelPedidos
            // 
            flowPanelPedidos.AutoScroll = true;
            flowPanelPedidos.BackColor = Color.FromArgb(228, 228, 228);
            flowPanelPedidos.FlowDirection = FlowDirection.TopDown;
            flowPanelPedidos.Location = new Point(28, 154);
            flowPanelPedidos.Name = "flowPanelPedidos";
            flowPanelPedidos.Size = new Size(840, 560);
            flowPanelPedidos.TabIndex = 12;
            flowPanelPedidos.WrapContents = false;
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.BackColor = Color.Transparent;
            lblItens.Font = new Font("Segoe UI", 13F);
            lblItens.Location = new Point(1210, 315);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(22, 25);
            lblItens.TabIndex = 2;
            lblItens.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 13F);
            lblTotal.Location = new Point(1079, 373);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "00,00";
            // 
            // TelaPedidosRestaurante
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPedidosRestaurante;
            ClientSize = new Size(1350, 729);
            Controls.Add(lblTotal);
            Controls.Add(lblItens);
            Controls.Add(flowPanelPedidos);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaPedidosRestaurante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaPedidosRestaurante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private FlowLayoutPanel flowPanelPedidos;
        private Label lblItens;
        private Label lblTotal;
    }
}