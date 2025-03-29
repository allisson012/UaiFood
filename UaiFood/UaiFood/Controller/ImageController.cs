using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UaiFood.Controller
{
    class ImageController
    {
        public byte [] SelectImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Imagens (*.png; *.jpeg; *.jpg) |*.png; *.jpeg; *.jpg";
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFile.FileName;
                System.Diagnostics.Debug.WriteLine(caminho);
                return ConvertImage(caminho);
            }
            else
            {
                return null;
            }
        }
        public byte[] ConvertImage(string caminho)
        {
            byte[] ImageBytes = File.ReadAllBytes(caminho);
            System.Diagnostics.Debug.WriteLine("Tamanho do array de bytes: " + ImageBytes.Length + " bytes");
            return ImageBytes;
        }
        public Image ExibirImage(byte[] image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    return Image.FromStream(ms);
                }
            }catch(Exception e)
            {
                return null; 
            }

        }
        

    }
}
