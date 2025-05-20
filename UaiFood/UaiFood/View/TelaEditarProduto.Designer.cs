namespace UaiFood.View
{
    partial class TelaEditarProduto
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
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            cbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comida;
            pictureBox1.Location = new Point(76, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 16F);
            txtNome.Location = new Point(376, 199);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 29);
            txtNome.TabIndex = 18;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = SystemColors.ControlLight;
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Font = new Font("Segoe UI", 16F);
            txtPreco.Location = new Point(376, 301);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(84, 29);
            txtPreco.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(466, 301);
            label1.Name = "label1";
            label1.Size = new Size(38, 30);
            label1.TabIndex = 21;
            label1.Text = "R$";
            // 
            // cbCategoria
            // 
            cbCategoria.BackColor = SystemColors.ControlLight;
            cbCategoria.FlatStyle = FlatStyle.Flat;
            cbCategoria.Font = new Font("Segoe UI", 16F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(376, 404);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(502, 38);
            cbCategoria.TabIndex = 22;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.ControlLight;
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Font = new Font("Segoe UI", 16F);
            txtDescricao.Location = new Point(376, 506);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(740, 188);
            txtDescricao.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(76, 387);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 24;
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
            button3.Location = new Point(76, 438);
            button3.Name = "button3";
            button3.Size = new Size(178, 43);
            button3.TabIndex = 25;
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(76, 487);
            button1.Name = "button1";
            button1.Size = new Size(110, 47);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaEditarProduto
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaEditarProduto;
            ClientSize = new Size(1350, 729);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtDescricao);
            Controls.Add(cbCategoria);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaEditarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Label label1;
        private ComboBox cbCategoria;
        private TextBox txtDescricao;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}