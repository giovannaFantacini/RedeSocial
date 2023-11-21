// Adicione os using necessários
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedeSocial.Domain.Entities;
using System;

namespace RedeSocial.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        // Teste para a entidade Usuario
        [TestMethod]
        public void TestUsuario()
        {
            var usuario = new Usuario
            {
                NomeUsuario = "teste",
                NomeCompleto = "Nome Completo",
                DataDeRegistro = DateTime.Today,
                Email = "teste@gmail.com",
                Senha = "senha",
                FotoPerfil = new byte[] { 0x00, 0x01, 0x02 }
            };

            Assert.AreEqual(usuario.NomeUsuario, "teste");
            Assert.AreEqual(usuario.NomeCompleto, "Nome Completo");
            Assert.AreEqual(usuario.DataDeRegistro, DateTime.Today);
            Assert.AreEqual(usuario.Email, "teste@gmail.com");
            Assert.AreEqual(usuario.Senha, "senha");
            Assert.IsNotNull(usuario.FotoPerfil);
        }

        // Teste para a entidade Postagem
        [TestMethod]
        public void TestPostagem()
        {
            var usuario = new Usuario
            {
                NomeUsuario = "teste",
                NomeCompleto = "Nome Completo",
                DataDeRegistro = DateTime.Today,
                Email = "teste@gmail.com",
                Senha = "senha",
                FotoPerfil = new byte[] { 0x00, 0x01, 0x02 }
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Isso é um teste de postagem",
                DataHoraPostagem = DateTime.Now
            };

            Assert.AreEqual(postagem.Usuario, usuario);
            Assert.AreEqual(postagem.TextoDaPostagem, "Isso é um teste de postagem");
            Assert.IsNotNull(postagem.DataHoraPostagem);
        }

        // Teste para a entidade Curtida
        [TestMethod]
        public void TestCurtida()
        {
            var usuario = new Usuario
            {
                NomeUsuario = "teste",
                NomeCompleto = "Nome Completo",
                DataDeRegistro = DateTime.Today,
                Email = "teste@gmail.com",
                Senha = "senha",
                FotoPerfil = new byte[] { 0x00, 0x01, 0x02 }
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Isso é um teste de postagem",
                DataHoraPostagem = DateTime.Now
            };

            var curtida = new Curtida
            {
                Usuario = usuario,
                Postagem = postagem,
                DataHoraCurtida = DateTime.Now
            };

            Assert.AreEqual(curtida.Usuario, usuario);
            Assert.AreEqual(curtida.Postagem, postagem);
            Assert.IsNotNull(curtida.DataHoraCurtida);
        }

        // Teste para a entidade Comentario
        [TestMethod]
        public void TestComentario()
        {
            var usuario = new Usuario
            {
                NomeUsuario = "teste",
                NomeCompleto = "Nome Completo",
                DataDeRegistro = DateTime.Today,
                Email = "teste@gmail.com",
                Senha = "senha",
                FotoPerfil = new byte[] { 0x00, 0x01, 0x02 } 
            };

            var postagem = new Postagem
            {
                Usuario = usuario,
                TextoDaPostagem = "Isso é um teste de postagem",
                DataHoraPostagem = DateTime.Now
            };

            var comentario = new Comentario
            {
                Usuario = usuario,
                Postagem = postagem,
                TextoComentario = "Isso é um teste de comentário",
                DataHoraComentario = DateTime.Now
            };

            Assert.AreEqual(comentario.Usuario, usuario);
            Assert.AreEqual(comentario.Postagem, postagem);
            Assert.AreEqual(comentario.TextoComentario, "Isso é um teste de comentário");
            Assert.IsNotNull(comentario.DataHoraComentario);
        }

        // Teste para a entidade RelacaoAmizade
        [TestMethod]
        public void TestAmizade()
        {
            var usuario1 = new Usuario
            {
                NomeUsuario = "teste1",
                NomeCompleto = "Nome Completo 1",
                DataDeRegistro = DateTime.Today,
                Email = "teste1@gmail.com",
                Senha = "senha1",
                FotoPerfil = new byte[] { 0x00, 0x01, 0x02 } 
            };

            var usuario2 = new Usuario
            {
                NomeUsuario = "teste2",
                NomeCompleto = "Nome Completo 2",
                DataDeRegistro = DateTime.Today,
                Email = "teste2@gmail.com",
                Senha = "senha2",
                FotoPerfil = new byte[] { 0x03, 0x04, 0x05 } 
            };

            var relacaoAmizade = new Amizade
            {
                Usuario1 = usuario1,
                Usuario2 = usuario2,
                EstadoAmizade = "Amigos"
            };

            Assert.AreEqual(relacaoAmizade.Usuario1, usuario1);
            Assert.AreEqual(relacaoAmizade.Usuario2, usuario2);
            Assert.AreEqual(relacaoAmizade.EstadoAmizade, "Amigos");
        }
    }
}
