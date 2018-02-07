using AutenticacaoEfCookie.Models;

namespace AutenticacaoEfCookie.Dados
{
    public class CodeFirst
    {
        public static void Inicializar(AutenticacaoContexto contexto)
        {
            contexto.Database.EnsureCreated();
            var usuario = new Usuario(){
                Nome = "Bro 1",
                Email = "bro1@bangbros.com",
                Senha = "123456"
            };

            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                Nome = "Financeiro"
            };

            var usuariopermissao = new UsuarioPermissao(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao

            };

            contexto.UsuarioPermissao.Add(usuariopermissao);
            contexto.SaveChanges();
        }
    }
}