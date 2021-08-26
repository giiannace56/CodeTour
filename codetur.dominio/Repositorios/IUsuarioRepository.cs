using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetur.dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        //isso é quase um CRUD
        void Adicionar(Usuario usuario);
        void Alterar(Usuario usuario);
        void AlterarSenha(Usuario usuario);
        Usuario BuscaPorEmail(string email);
        Usuario BuscarPorID(Guid id);
        ICollection<Usuario> Listar(bool? ativo = null);
    }
}
