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
            cbFiltro.TabIndex = 2;
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
            // TelaPesquisa
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.TelaPesquisa1;
            ClientSize = new Size(1350, 729);
            Controls.Add(txtPesquisa);
            Controls.Add(cbFiltro);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "TelaPesquisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UaiFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbFiltro;
        private TextBox txtPesquisa;
    }
}