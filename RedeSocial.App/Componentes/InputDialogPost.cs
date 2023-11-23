using ReaLTaiizor.Forms;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;


namespace RedeSocial.App
{
    public partial class InputDialogPost : MaterialForm
    {
        private readonly IBaseService<Postagem> _postService;
        public static Usuario Usuario { get; set; }
        public InputDialogPost(IBaseService<Postagem> postService)
        {
            _postService = postService;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PreencheObjeto(Postagem post)
        {
            post.TextoDaPostagem = postText.Text;
            post.DataHoraPostagem = DateTime.Now;
            post.Usuario = Usuario;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                var post = new Postagem();
                PreencheObjeto(post);
                _postService.Add<Postagem, Postagem, PostagemValidator>(post);


                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Rede Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
