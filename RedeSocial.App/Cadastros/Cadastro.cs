using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;
using System.Net.Mail;
using System.Windows.Forms;

namespace RedeSocial.App
{
    public partial class Cadastro : CrownForm
    {
        private string caminhoDaImagemSelecionada;
        private readonly IBaseService<Usuario> _cadService;
        public Cadastro(IBaseService<Usuario> cadService)
        {
            _cadService = cadService;
            InitializeComponent();
            CarregarImagemRedimensionada();
        }

        private void CarregarImagemRedimensionada()
        {
            Image imagemOriginal = Image.FromFile("C:/Users/Giova/OneDrive - ifsp.edu.br/Imagens/Profile/imgPadrao.jpg");
            Image imagemRedimensionada = Service.ImageService.RedimensionarImagem(imagemOriginal, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = imagemRedimensionada;
        }

        private void hopePictureBox3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void PreencheObjeto(Usuario usuario)
        {
            byte[] dadosImagem = File.ReadAllBytes(caminhoDaImagemSelecionada);
            usuario.NomeCompleto = firstName.Text + lastName.Text;
            usuario.NomeUsuario = userName.Text;
            usuario.Email = email.Text;
            usuario.Senha = password.Text;
            usuario.DataDeRegistro = DateTime.Now;
            usuario.FotoPerfil = dadosImagem;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario();
                PreencheObjeto(usuario);
                _cadService.Add<Usuario, Usuario, UsuarioValidator>(usuario);


                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Rede Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoDaImagemSelecionada = openFileDialog.FileName;
                    Image imagemOriginal = Image.FromFile(caminhoDaImagemSelecionada);
                    Image imagemRedimensionada = RedimensionarImagem(imagemOriginal, pictureBox.Width, pictureBox.Height);
                    pictureBox.Image = imagemRedimensionada;
                }
            }
        }

        private Image RedimensionarImagem(Image imagemOriginal, int larguraAlvo, int alturaAlvo)
        {
            Bitmap imagemRedimensionada = new Bitmap(larguraAlvo, alturaAlvo);

            using (Graphics g = Graphics.FromImage(imagemRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagemOriginal, 0, 0, larguraAlvo, alturaAlvo);
            }

            return imagemRedimensionada;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
