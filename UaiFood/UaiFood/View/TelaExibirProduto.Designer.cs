namespace UaiFood.View
{
    partial class TelaExibirProduto
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
            lblNome = new Label();
            lblPreco = new Label();
            lblCategoria = new Label();
            lblDescricao = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(376, 195);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 21);
            lblNome.TabIndex = 13;
            lblNome.Text = "label1";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(414, 295);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(52, 21);
            lblPreco.TabIndex = 14;
            lblPreco.Text = "label1";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(376, 404);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(52, 21);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "label1";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(376, 508);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(52, 21);
            lblDescricao.TabIndex = 16;
            lblDescricao.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(376, 295);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 17;
            label4.Text = "R$";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comida;
            pictureBox1.Location = new Point(64, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // TelaExibirProduto
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaExibirProduto;
            ClientSize = new Size(1350, 729);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaExibirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaExibirProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblPreco;
        private Label lblCategoria;
        private Label lblDescricao;
        private Label label4;
        private PictureBox pictureBox1;
    }
}