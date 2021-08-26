using codetur.dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes.Commands
{
    //Deixar Publica
    public class CriarContaCommandTeste
    {
        //Parametro para TESTE
        //biblioteca para Xunit
        [Fact]
        public void DeveRetornarSucessoSeDadosForemValidados() 
        {
            var command = new CriarContaCommand();
            command.Nome = "Paulo";
            command.Email = "paulo123@gmail.com";
            command.Senha = "12345678";
            command.TipoUsuario = CodeTur.Comum.EnTipoUsuario.Admin;

            command.Validar();

            Assert.True(command.IsValid, "Os Dados estão preenchidos corretamente");
        }
    }
}
