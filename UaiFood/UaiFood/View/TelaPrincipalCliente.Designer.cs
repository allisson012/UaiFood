namespace UaiFood.View
{
    partial class TelaPrincipalCliente
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowPanelRestaurantes = new FlowLayoutPanel();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(265, 34);
            button1.Name = "button1";
            button1.Size = new Size(591, 40);
            button1.TabIndex = 0;
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
            button2.Location = new Point(1273, 12);
            button2.Name = "button2";
            button2.Size = new Size(65, 74);
            button2.TabIndex = 1;
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
            button3.Location = new Point(978, 34);
            button3.Name = "button3";
            button3.Size = new Size(62, 52);
            button3.TabIndex = 2;
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
            button4.Location = new Point(1093, 34);
            button4.Name = "button4";
            button4.Size = new Size(125, 52);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // flowPanelRestaurantes
            // 
            flowPanelRestaurantes.AutoScroll = true;
            flowPanelRestaurantes.BackColor = Color.White;
            flowPanelRestaurantes.Location = new Point(-2, 195);
            flowPanelRestaurantes.Name = "flowPanelRestaurantes";
            flowPanelRestaurantes.Size = new Size(1354, 297);
            flowPanelRestaurantes.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.icons8_código_qr_80__1_;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(105, 23);
            button5.Name = "button5";
            button5.Size = new Size(62, 52);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // TelaPrincipalCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPrincipalUsuario;
            ClientSize = new Size(1350, 729);
            Controls.Add(button5);
            Controls.Add(flowPanelRestaurantes);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1364, 766);
            Name = "TelaPrincipalCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaPrincipalCliente_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel flowPanelRestaurantes;
        private Button button5;
    }
}