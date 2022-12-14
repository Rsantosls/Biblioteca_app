using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Biblioteca.Models
{
    public class LoginServices
    {
        // Inserção de novos usuarios
        public void Inserir(Login l)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                l.Senha = MD5Hash.senhaHash(l.Senha).ToLower();
                bc.Login.Add(l);
                bc.SaveChanges();
            }
        }

        // Atualização de usuarios
        public void Atualizar(Login l)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Login login = bc.Login.Find(l.Id);
                login.Nome = l.Nome;
                login.Usuario = l.Usuario;
                // Aqui eu uso uma variavel que salva temporiamente uma nova senha que substituirá a que está na database.
                login.Senha = MD5Hash.senhaHash(l.NovaSenha).ToLower();
                bc.SaveChanges();
            }
        }

        // Listagem de usuarios cadastrados
        public ICollection<Login> ListarTodos()
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Login> query;
                query = bc.Login;
                return query.OrderBy(l => l.Id).ToList();
            }
        }

        // Busca pela id para edição de cadastro
        public Login ObterPorId(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Login.Find(id);
            }
        }

        // Remoção de usuarios
        public void Remover(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Login login = bc.Login.Find(id);
                bc.Login.Remove(login);
                bc.SaveChanges();
            }
        }
    }
}