using codetur.dominio;
using codetur.dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Testes.Repositorios
{
    public class FakeUsuarioReposiotorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {
            
        }

        public void Alterar(Usuario usuario)
        {
            
        }

        public void AlterarSenha(Usuario usuario)
        {
            
        }

        public Usuario BuscaPorEmail(string email)
        {
            //retorna nulo
            return null;
        }

        public Usuario BuscarPorID(Guid id)
        {
            return new Usuario("ruan", "Ruan@gmail.com", "12345678", CodeTur.Comum.EnTipoUsuario.Admin);
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
               new Usuario(),
               new Usuario()
            };
        }
    }
}
