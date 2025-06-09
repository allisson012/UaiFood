using System;
using QRCoder;
using System.Drawing;

namespace UaiFood.Controller
{
    internal class qrCodeController
    {
        public Bitmap GerarQRCode(string userId)
        {
            string url = $"https://t.me/uaifoodbot?start={userId}";

            System.Diagnostics.Debug.WriteLine($"URL gerada: {url}");

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    return qrCodeImage; // Retorna o bitmap para o formulário exibir
                }
            }
        }
    }
}
