using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Comum.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        //Retorno para usuario não autorizado
        public GenericCommandResult(bool sucesso, string mensagem, object data)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Data = data;
        }

        //padronizando tipo de retorno 
        public bool Sucesso { get; private set; }

        //Mostar mensagem de erro e o porquê
        public string Mensagem { get; private set; }

        //determinar objeto 
        public Object  Data { get; private set; }
    }
}
