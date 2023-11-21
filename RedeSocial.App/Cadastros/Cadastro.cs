using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;
using System.Net.Mail;

namespace RedeSocial.App
{
    public partial class Cadastro : CrownForm
    {

        private readonly IBaseService<Usuario> _cadService;
        public Cadastro(IBaseService<Usuario> cadService)
        {
            _cadService = cadService;
            InitializeComponent();
        }

        private void hopePictureBox3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void PreencheObjeto(Usuario usuario)
        {
            usuario.NomeCompleto = firstName.Text + lastName.Text;
            usuario.NomeUsuario = userName.Text;
            usuario.Email = email.Text;
            usuario.Senha = password.Text;
            usuario.DataDeRegistro = DateTime.Now;
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
    }
}
