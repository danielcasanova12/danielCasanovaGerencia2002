using gerencia.Models;
using gerencia;
using System.Linq;
using System.Windows.Forms;

namespace gerencia.Controllers
{
    public class LoginController
    {
        public bool ValidarLogin(string email, string senha)
        {
            try
            {
                using (var db = new EventosContext())
                {
                    // consultar a tabela de usuários usando LINQ
                    var usuario = db.Usuarios.FirstOrDefault(u => u.EmailUsuario == email && u.SenhaUsuario == senha);

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

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return false;
            }

}
    }
    
}

