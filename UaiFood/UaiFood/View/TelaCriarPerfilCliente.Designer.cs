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
            picturePerfil.Location = new Point(77, 149);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(192, 237);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 0;
            picturePerfil.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(77, 392);
            button1.Name = "button1";
            button1.Size = new Size(67, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaCriarPerfilCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaCriarPerfilCliente;
            ClientSize = new Size(1348, 721);
            Controls.Add(button1);
            Controls.Add(picturePerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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