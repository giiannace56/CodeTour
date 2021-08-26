using CodeTur.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Comum.Handlers.Contracts
{
    //Where -> gera uma condição para que o objeto genérico obrigatoriamente herde de um ICommand
    //<T> tipo genérico que aceita qualquer Tipo de objeto
    //recebendo comando de Validar herdando de ICommand
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}
