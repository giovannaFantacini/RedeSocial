using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using RedeSocial.App.Componentes;
using RedeSocial.App.Infra;
using RedeSocial.App.Login;
using RedeSocial.App.Model;
using RedeSocial.App.Models;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;
using System;
using static System.Windows.Forms.ListViewItem;
using Button = ReaLTaiizor.Controls.Button;

namespace RedeSocial.App
{
    public partial class BaseTelaPrincipal : MaterialForm
    {
        #region Construtor
        public static Usuario Usuario { get; set; }

        private readonly IBaseService<Postagem> _postService;
        private readonly IBaseService<Amizade> _amizadeService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Curtida> _curtidaService;
        private readonly IBaseService<Comentario> _commentService;
        public BaseTelaPrincipal(IBaseService<Postagem> potService, IBaseService<Amizade> amizadeService,
            IBaseService<Usuario> usuarioService, IBaseService<Curtida> curtidaService,
            IBaseService<Comentario> commentService)
        {
            InitializeComponent();
            Exibeformulario<Login.Login>();
            _postService = potService;
            _amizadeService = amizadeService;
            _usuarioService = usuarioService;
            _curtidaService = curtidaService;
            _commentService = commentService;
            InicializarProfileView();
            InicializaFriendsPage();
            InicializarHomeView();

            label_name.Text = Usuario.NomeUsuario;


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

                }
            }
        }

        private void InicializarProfileView()
        {
            var postagens = _postService.Get<Postagem>(new[] { "Usuario" }).Where(x => x.Usuario.Id == Usuario.Id).ToList().OrderByDescending(x => x.DataHoraPostagem);
            foreach (var postagem in postagens)
            {
                Componentes.ComponentePostagem post = new Componentes.ComponentePostagem();
                post.lbl_userName.Text = postagem.Usuario.NomeUsuario;
                post.lbl_postagem.Text = postagem.TextoDaPostagem;
                post.btn_curtir.Tag = postagem;
                post.btn_comentar.Tag = postagem;
                post.btn_curtir.Click += btn_curtir_Click;
                post.btn_comentar.Click += btn_comment_Click;
                post.btnExcluir.Tag = postagem;
                post.btnExcluir.Click += btn_delete_post;

                if (!verifica_curtitda(postagem))
                {
                    post.btn_curtir.Enabled = false;
                }



                post.btn_curtir.Text = $"{cont_curtidas(postagem)} Curtir";

                flowLayoutPanelProfile.Controls.Add(post);
            }
        }

        private void delete_curtidas_comments(Postagem post)
        {
            var curtidas = _curtidaService.Get<Curtida>(new[] { "Postagem" }).Where(x => x.Postagem!.Id == post.Id).ToList();
            foreach (var curtida in curtidas)
                _curtidaService.Delete(curtida.Id);

            var comentarios = _commentService.Get<Comentario>(new[] { "Usuario", "Postagem" }).Where(x => x.Postagem!.Id == post.Id).ToList();
            foreach (var comentario in comentarios)
                _commentService.Delete(comentario.Id);
        }
        private void btn_delete_post(object? sender, EventArgs e)
        {
            var post1 = (Postagem)((System.Windows.Forms.Button)sender).Tag;
            delete_curtidas_comments(post1);
            _postService.Delete(post1.Id);
            limpa_pagina(flowLayoutPanelProfile);
            InicializarProfileView();

        }

        private void btn_comment_Click(object? sender, EventArgs e)
        {
            InputComent.Usuario = Usuario;
            var post1 = (Postagem)((MaterialButton)sender).Tag;
            InputComent.Post = post1;
            Exibeformulario<InputComent>();
        }

        private void InicializarHomeView()
        {

            var postagens = _postService.Get<Postagem>(new[] { "Usuario" }).Where(x => x.Usuario.Id != Usuario.Id).ToList().OrderByDescending(x => x.DataHoraPostagem);
            foreach (var postagem in postagens)
            {
                Componentes.ComponentePostagem post = new Componentes.ComponentePostagem();
                post.lbl_userName.Text = postagem.Usuario.NomeUsuario;
                post.lbl_postagem.Text = postagem.TextoDaPostagem;
                post.btn_curtir.Tag = postagem;
                post.btn_comentar.Tag = postagem;
                post.btn_curtir.Click += btn_curtir_Click;
                post.btn_comentar.Click += btn_comment_Click;
                post.btnExcluir.Visible = false;

                if (!verifica_curtitda(postagem))
                {
                    post.btn_curtir.Enabled = false;
                }



                post.btn_curtir.Text = $"{cont_curtidas(postagem)} Curtir";


                flowLayoutPanel.Controls.Add(post);
            }
        }

        private int cont_curtidas(Postagem post)
        {
            var curtida = _curtidaService.Get<Curtida>(new[] { "Postagem" }).Where(x => x.Postagem!.Id == post.Id).ToList();
            return curtida.Count;

        }

        private bool verifica_curtitda(Postagem post)
        {
            var curtida = _curtidaService.Get<Curtida>(new[] { "Postagem", "Usuario" }).Any(x => x.Usuario!.Id == Usuario.Id && x.Postagem!.Id == post.Id);
            if (curtida) { return false; }
            return true;

        }

        private void btn_curtir_Click(object sender, EventArgs e)
        {
            var post1 = (Postagem)((MaterialButton)sender).Tag;

            var curtida = new Curtida()
            {
                Postagem = post1,
                DataHoraCurtida = DateTime.Now,
                Usuario = Usuario
            };

            _curtidaService.Add<Curtida, Curtida, CurtidaValidator>(curtida);
            limpa_pagina(flowLayoutPanelProfile);
            limpa_pagina(flowLayoutPanel);
            InicializarProfileView();
            InicializarHomeView();

        }


        private void btnAddPost_Click_1(object sender, EventArgs e)
        {
            InputDialogPost.Usuario = Usuario;
            Exibeformulario<InputDialogPost>();
            limpa_pagina(flowLayoutPanelProfile);
            InicializarProfileView();

        }

        private bool VerificaAmizade(Usuario user)
        {
            var amizades = _amizadeService.Get<Amizade>(new[] { "Usuario1", "Usuario2" }).Where(x => x.Usuario1!.Id == Usuario.Id).ToList();
            if (amizades is null)
            {
                return false;
            }
            foreach (var amizade in amizades)
            {
                if (user.Id == amizade.Usuario2!.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private void InicializaFriendsPage()
        {

            var usuarios = _usuarioService.Get<Usuario>().Where(x => x.Id != Usuario.Id).ToList();
            foreach (var usuario in usuarios)
            {
                if (!VerificaAmizade(usuario))
                {

                    Componentes.ComponenteAmizade amizade = new Componentes.ComponenteAmizade();
                    amizade.lblUserName.Text = usuario.NomeUsuario;
                    amizade.btnAddFriend.Tag = usuario;
                    amizade.btnAddFriend.Click += Add_friend;

                    flowLayoutPanelFriends.Controls.Add(amizade);

                }


            }
        }

        private void limpa_pagina(FlowLayoutPanel fl)
        {
            fl.Controls.Clear();
        }

        private void Add_friend(object? sender, EventArgs e)
        {
            try
            {
                var user = (Usuario)((MaterialButton)sender).Tag;
                var amizade = new Amizade()
                {
                    Usuario1 = Usuario,
                    Usuario2 = user,
                    EstadoAmizade = "Seguindo",
                };

                _amizadeService.Add<Amizade, Amizade, AmizadeValidator>(amizade);

                limpa_pagina(flowLayoutPanelFriends);
                InicializarFriendsView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Rede Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InicializarFriendsView()
        {
            throw new NotImplementedException();
        }
    }

}

