using CodeTur.Comum;
using CodeTur.Comum.Commands;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetur.dominio.Commands.Usuario
{
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand()
        {
        }

        public CriarContaCommand(string nome, string email, string senha, EnTipoUsuario tipoUsuario)
        {
            AddNotifications(
            new Contract<Notification>()
            .Requires()
            .IsNotEmpty(Nome, "Nome", "Deve haver um Nome")
            .IsEmail(Email, "Email", "O Formato do email está incorreto")
            .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 Caracteres")
             );
            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Senha = senha;
                TipoUsuario = tipoUsuario;
            }
           
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }
        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
            .Requires()
            .IsNotEmpty(Nome, "Nome", "Deve haver um Nome")
            .IsEmail(Email, "Email", "O Formato do email está incorreto")
            .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 Caracteres")
             );
        }
    }
}
