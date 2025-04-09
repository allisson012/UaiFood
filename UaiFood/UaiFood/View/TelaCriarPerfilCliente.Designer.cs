namespace UaiFood.View
{
    partial class TelaCriarPerfilCliente
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
            picturePerfil = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.FotoPerfil;
            picturePerfil.Location = new Point(77, 148);
            picturePerfil.Margin = new Padding(3, 2, 3, 2);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(191, 235);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 0;
            picturePerfil.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(77, 387);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(34, 30);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaCriarPerfilCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaCriarPerfilCliente;
            ClientSize = new Size(1350, 729);
            Controls.Add(button1);
            Controls.Add(picturePerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "TelaCriarPerfilCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picturePerfil;
        private Button button1;
    }
}