using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using RedeSocial.App.Infra;
using RedeSocial.App.Model;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;

namespace RedeSocial.App.Login
{
    public partial class Login : CrownForm
    {
        private Form currentForm;
        private readonly IBaseService<Usuario> _usuarioService;

        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
            #if DEBUG
            email.Text = @"giovanna@mail.com";
            password.Text = @"123";
            #endif
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                //this.Hide();
                //cad.MdiParent = this;
                cad.ShowDialog();
            }
        }

        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuariosCadastrados();

            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == login).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuariosCadastrados()
        {
            var usuarios = _usuarioService.Get<UsuarioModel>().ToList();
        }



        private void btnsignIn_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(email.Text, password.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "Rede Social", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
            }
            else
            {
                BaseTelaPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            //  Exibeformulario<BaseTelaPrincipal>();

        }

        private void btnsignUp_Click(object sender, EventArgs e)
        {
            Exibeformulario<Cadastro>();
        }
    }
}
