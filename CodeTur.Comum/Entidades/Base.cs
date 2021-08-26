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
    }
}
