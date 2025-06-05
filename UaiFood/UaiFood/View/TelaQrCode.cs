using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaQrCode : Form
    {
        public TelaQrCode()
        {
            InitializeComponent();

            int? userId = IdController.GetIdUser();

            if (userId.HasValue)
            {
                var qrController = new qrCodeController();
                Bitmap qrBitmap = qrController.GerarQRCode(userId.Value.ToString());
                pictureBox1.Image = qrBitmap; // exibe o QRCode no PictureBox
            }
            else
            {
                MessageBox.Show("Usuário não logado ou id inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
