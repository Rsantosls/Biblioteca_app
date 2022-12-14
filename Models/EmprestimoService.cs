using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System;


namespace Biblioteca.Models
{
    public class EmprestimoService 
    {
        public void Inserir(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Add(e);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Emprestimo emprestimo = bc.Emprestimos.Find(e.Id);
                emprestimo.NomeUsuario = e.NomeUsuario;
                emprestimo.Telefone = e.Telefone;
                emprestimo.LivroId = e.LivroId;
                emprestimo.DataEmprestimo = e.DataEmprestimo;
                emprestimo.DataDevolucao = e.DataDevolucao;
                emprestimo.Devolvido = e.Devolvido;

                bc.SaveChanges();
            }
        }

        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro = null)
        {
             
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Include(e => e.Livro).ToList();

                IQueryable<Emprestimo> query;
                if (filtro !=null)
                {

                switch(filtro.TipoFiltro)
                    {
                        case "Usuario":
                            query = bc.Emprestimos.Where(e => e.NomeUsuario.ToLower().Contains(filtro.Filtro));
                        break;

                        case "Livro":
                            query = bc.Emprestimos.Where(e => e.Livro.Titulo.ToLower().Contains(filtro.Filtro));
                        break;

                        default:
                            query = bc.Emprestimos;
                        break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Emprestimos;
                }

                //return bc.Emprestimos.Include(e => e.Livro).ToList();
                //return query.OrderBy(l => l.Titulo).ToList();
                return query.OrderByDescending(e => e.DataDevolucao).ToList();
            }
        }

        public Emprestimo ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Find(id);
            }
        }
    }
}