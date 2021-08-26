using codetur.dominio.Commands.Usuario;
using codetur.dominio.Repositorios;
using CodeTur.Comum.Commands;
using CodeTur.Comum.Handlers.Contracts;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetur.dominio.Handlers.Usuarios
{
    public class CriarContaHandler : Notifiable<Notification>, IHandler<CriarContaCommand>
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public CriarContaHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public ICommandResult Handler(CriarContaCommand command)
        {
            //Antes de começar as execuções, temos que validar se o command está correto
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Informe corretamente os dados do usúario", command.Notifications);
            }
            //O que pode Fazer
            //Verficar se o email existe
            var UsuarioExiste = _usuarioRepositorio.BuscaPorEmail(command.Email);
            //Caso exista retorna uma resposta
            if (UsuarioExiste != null)
            {
                return new GenericCommandResult(false, "Email Já Cadastrado", "informe outro Email");
            }
            //Criptografar a senha 
            // Salvar no banco repositorio.Adicionar(Usuario)
            Usuario User1 = new Usuario(command.Nome,
                command.Email,
                command.Senha,
                command.TipoUsuario
                );
            //Válida denovo 
            if (User1.IsValid)
                return new GenericCommandResult(false, "Dados de usuario inválido", User1.Notifications);
                _usuarioRepositorio.Adicionar(User1);
            
            //enviar email de boas vindas

            return new GenericCommandResult(true, "Usuario Criado", "Token");
        }
    }
}
