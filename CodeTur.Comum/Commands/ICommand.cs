using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Comum.Commands
{
    public interface ICommand
    {
        //interface responsavel pelos comandos aonde eles estejam 
        void Validar();
    }
}
