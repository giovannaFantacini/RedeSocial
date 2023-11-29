using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial.App.Componentes
{
    public partial class ComponenteAmizade : UserControl
    {
        public ComponenteAmizade()
        {
            InitializeComponent();
            CarregarImagemRedimensionada();
        }

        private void CarregarImagemRedimensionada()
        {
            Image imagemOriginal = Image.FromFile("C:/Users/Giova/OneDrive - ifsp.edu.br/Imagens/Profile/imgPadrao.jpg");
            Image imagemRedimensionada = Service.ImageService.RedimensionarImagem(imagemOriginal, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = imagemRedimensionada;
        }

    }
}
