using ReaLTaiizor.Forms;
using RedeSocial.Domain.Base;
using RedeSocial.Domain.Entities;
using RedeSocial.Service.Validators;
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
    public partial class InputComent : MaterialForm
    {
        private readonly IBaseService<Comentario> _comentService;
        public static Postagem Post { get; set; }

        public static Usuario Usuario { get; set; }
        public InputComent(IBaseService<Comentario> comentService)
        {
            InitializeComponent();
            _comentService = comentService;
            InicializeComentsPage();
        }

        public void InicializeComentsPage()
        {
            var comentarios = _comentService.Get<Comentario>(new[] { "Usuario", "Postagem" }).Where(x => x.Postagem!.Id == Post.Id).ToList();
            foreach (var comentario in comentarios)
            {
                Componentes.ComponenteComentario comment = new Componentes.ComponenteComentario();
                comment.lblUserName.Text = comentario.Usuario.NomeUsuario;
                comment.lblTextoComent.Text = comentario.TextoComentario;
                flowLayoutPanel.Controls.Add(comment);
            }
        }

        private void PreencheObjeto(Comentario coment)
        {
            coment.DataHoraComentario = DateTime.Now;
            coment.Usuario = Usuario;
            coment.TextoComentario = comentText.Text;
            coment.Postagem = Post;
        }

        private void limpa_pagina(FlowLayoutPanel fl)
        {
            fl.Controls.Clear();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                var comentario = new Comentario();
                PreencheObjeto(comentario);
                _comentService.Add<Comentario, Comentario, ComentarioValidator>(comentario);
                limpa_pagina(flowLayoutPanel);
                InicializeComentsPage();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Rede Social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
