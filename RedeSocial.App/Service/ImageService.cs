using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.App.Service
{
    internal class ImageService
    {
        public static Image RedimensionarImagembyte(byte[] dadosImagem, int largura, int altura)
        {
            Image imagemOriginal = ByteArrayParaImagem(dadosImagem);
            return RedimensionarImagem(imagemOriginal, largura, altura);
        }

        public static Image ByteArrayParaImagem(byte[] dados)
        {
            using (MemoryStream ms = new MemoryStream(dados))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image RedimensionarImagem(Image imagemOriginal, int largura, int altura)
        {
            Bitmap imagemRedimensionada = new Bitmap(largura, altura);

            using (Graphics g = Graphics.FromImage(imagemRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagemOriginal, 0, 0, largura, altura);
            }

            return imagemRedimensionada;
        }
    }
}
