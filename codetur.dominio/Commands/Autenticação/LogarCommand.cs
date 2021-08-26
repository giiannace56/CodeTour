using CodeTur.Comum.Commands;
using Flunt.Notifications;
using Flunt.Validations;

//Remover Bibiliotecas Desnecessarias
namespace codetur.dominio.Commands.Autenticação
{
    public class LogarCommand : Notifiable<Notification>, ICommand
    {
        //Metodo Construtor
        public LogarCommand(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }

        public string Senha { get; set; }


        public void Validar()
        {
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsEmail(Email, "Email","O Formato do email está incorreto")
                .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 Caracteres")
                );
        }
    }
}
