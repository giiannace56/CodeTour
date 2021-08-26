using CodeTur.Comum.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetur.dominio.Commands.Autenticação
{
    class RecuperarSenhaCommand : Notifiable<Notification>, ICommand
    {
        public RecuperarSenhaCommand(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
