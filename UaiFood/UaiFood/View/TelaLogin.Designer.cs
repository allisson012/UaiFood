namespace UaiFood
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TelaLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 721);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaLogin_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
