using gerencia.Models;
using gerencia;
using System.Linq;

namespace gerencia.Controllers
{
    public class LoginController
    {
        public bool ValidarLogin(string email, string senha)
        {
            if (email == "" || senha == "") { return false; }
            using (var db = new EventosContext())
            {
                // consultar a tabela de usuários usando LINQ
                var usuario = db.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

                // verificar se o usuário foi encontrado
                if (usuario != null)
                {
                    UserSession.SetUserId(usuario.IdUsuario); //usuario.IdUsuario
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

