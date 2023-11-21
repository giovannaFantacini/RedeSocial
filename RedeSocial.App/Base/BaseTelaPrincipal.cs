using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using RedeSocial.App.Infra;
using RedeSocial.Domain.Entities;
using Button = ReaLTaiizor.Controls.Button;

namespace RedeSocial.App
{
    public partial class BaseTelaPrincipal : MaterialForm
    {
        #region Construtor
        public static Usuario Usuario { get; set; }
        public BaseTelaPrincipal()
        {
            InitializeComponent();
            Exibeformulario<Login.Login>();

        }
        #endregion

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var form = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (form != null && !form.IsDisposed)
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    form.Close();
                }
                else
                {
                    // lblUsuario.Text = $"Usuário: {Usuario.Nome}";
                }
            }
        }

        private void btnAddPost_Click_1(object sender, EventArgs e)
        {
            InputDialogPost.Usuario = Usuario;
            Exibeformulario<InputDialogPost>();
           
        }
    }

}

