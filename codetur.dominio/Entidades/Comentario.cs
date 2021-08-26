using CodeTur.Comum;
using CodeTur.Comum.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetur.dominio.Entidades
{
    class Comentario : Base
    {
        public Comentario(string texto, string sentimento, EnStatusComentario status, Guid idUsuario, Usuario usuario, Guid idPacote)
        {

            AddNotifications(
               new Contract<Notification>()
               .Requires()
               .IsNotEmpty(texto, "texto", "Texto não Pode ser Vazio")
               .IsNotEmpty(sentimento, "sentimento", "Deve Haver um sentimento")
               .IsNotNull(status, "status", "O status não pode ser nula")
               .IsNotNull(idUsuario, "idUsuario", "idUsuario não pode ser nulo")
               .IsNotNull(idPacote, "idPacote", "idPacote não pode ser nulo")
           );
            if (IsValid)
            {
                Texto = texto;
                Sentimento = sentimento;
                Status = status;
                IdUsuario = idUsuario;
                Usuario = usuario;
                IdPacote = idPacote;
            }
            
        }

        public string Texto { get; set; }
        public string Sentimento { get; set; }
        public EnStatusComentario Status { get; set; }

        // Composição em GUID = Global Unique Identifier(ele gera um string aleatorio, pode ser interpretado como um id, key ou qualquer outra coisa que te identifique como unico no sistema brigado nauber <3. 

        //Depende de Usuario 
        public Guid IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        //Depende de Pacote
        public Guid IdPacote { get; set; }
        public virtual Pacote Pacote { get; set; }
    }
}
