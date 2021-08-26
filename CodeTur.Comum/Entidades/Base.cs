using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Comum
{
    public abstract class Base : Notifiable<Notification>
    {
        //metodo construtor
        public Base()
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }
        public Guid ID { get; set; }

        public DateTime  DataCriacao { get; set;}

        //Adicionando algo na lista(Comentarios com Spam
        //Usuario pode apenas comentar 1 comentário por pacote
        public void AdicionarComentario(Comentario comentario)
        {
            //Expressão lambda
            if (_Comentarios.Any(x => x.IdUsuario == comentario.IdUsuario))
            {
                AddNotification("Comentários", "Usuario pode comentar apenas uma vez ");
            }
        }
    }
}
//.