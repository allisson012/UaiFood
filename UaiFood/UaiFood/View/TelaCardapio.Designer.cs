namespace UaiFood.View
{
    partial class TelaCardapio
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
            flowPanelProdutos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowPanelProdutos
            // 
            flowPanelProdutos.AutoScroll = true;
            flowPanelProdutos.BackColor = Color.White;
            flowPanelProdutos.Location = new Point(-3, 89);
            flowPanelProdutos.Name = "flowPanelProdutos";
            flowPanelProdutos.Size = new Size(1354, 639);
            flowPanelProdutos.TabIndex = 0;
            // 
            // TelaCardapio
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaCardapio;
            ClientSize = new Size(1350, 729);
            Controls.Add(flowPanelProdutos);
            MaximizeBox = false;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "TelaCardapio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            Load += TelaCardapio_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelProdutos;
    }
}