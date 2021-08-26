using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codetur.dominio.Entidades;
using CodeTur.Comum;
using Flunt.Notifications;
using Flunt.Validations;

namespace codetur.dominio
{
    public class Usuario : Base
    {
        //Metodo Construtor
        public Usuario(string nome, string email, string senha, EnTipoUsuario tipoUsuario)
        {
            //Validação
            //Notificações para caso Errado
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome,"nome","Nome não Pode ser Vazio")
                .IsEmail(email, "Email", "Email não pode ser vazio")
                .IsGreaterThan(senha,7,"Senha","a Senha deve obter mais de oito Caracteres")
            );


            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Senha = senha;
                TipoUsuario = tipoUsuario; 
            }
            
        }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }

        //public List<Comentario> Comentario { get; private set; }

        //Apenas lê
        public IReadOnlyCollection<Comentario> Comentario { get { return Comentarios; } }

        private List<Comentario> _Comentarios { get;  set; }

        //Manipulando Propriedades
        public void AtualizarSenha(string senha)
        {
            //Metodo de validação
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsGreaterThan(senha, 7, "Senha", "a Senha deve obter mais de oito Caracteres")
            );
            //Validação com isvalid = Valida se a senha está correta dentro dos parametros colocados
            if(IsValid)
            Senha = senha;
        }

        public void AlterarUsuario(string Usuario)
        {
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "nome", "Nome não Pode ser Vazio")
                .IsEmail(Email, "Email", "Email não pode ser vazio")
                
            );
            if (IsValid)
            {
                Email = Email;
                Nome = Nome;
            }
        }
    }
}
