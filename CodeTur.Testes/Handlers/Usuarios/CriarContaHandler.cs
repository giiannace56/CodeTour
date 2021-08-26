using codetur.dominio.Commands.Usuario;
using CodeTur.Comum.Commands;
using CodeTur.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes.Handlers.Usuarios
{
    public class CriarContaHandler
    {
        [Fact]
        public void DeveRetornarCasoDadosDoHandlerSejamValidos()
        {
            //Criar um command
            var command = new CriarContaCommand("ruan", "Ruan123@gmail.com", "12345678", CodeTur.Comum.EnTipoUsuario.Comum);
            //Criar manipulador
            var handler = new CriarContaHandler(new FakeUsuarioReposiotorio() );
            //Pegar um Resultado
            var resultado = (GenericCommandResult)handler.Handler(command);
            //Validar uma condição
            Assert.True(resultado.Sucesso, "Usuario Válido");
        }
    }
}
