using codetur.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes
{
    public class UsuarioTestes
    {
        //Tudo Certo
        //Parametro para identificar que é um teste unitário 
        [Fact]
        public void DeveRetornarSeUsuarioForValido()
        {
            Usuario usuario = new Usuario(
                    "Ruan",
                    "RuanGustavo@gmail.com",
                    "pastel231",
                    CodeTur.Comum.EnTipoUsuario.Admin
                );
            //Metodos estático para verificar condições nos teste
            Assert.True(usuario.IsValid, "Usuario Validado");

            //Isvalid verifica se é verdadeiro ou falso
        }

        //senha Fraca
        [Fact]
        public void DeveRetornarSeUsuarioForInvalidosememailcomsenhafraca()
        {
            Usuario usuario = new Usuario(
                    "Ruan",
                    "RuanGustavo@gmail.com",
                    "pastel",
                    CodeTur.Comum.EnTipoUsuario.Admin
                );
            //Metodos estático para verificar condições nos teste
            Assert.True(!usuario.IsValid, "Usuario Validado");

            //Isvalid verifica se é verdadeiro ou falso
        }

        //Sem Email
        [Fact]
        public void DeveRetornarSeUsuarioForInvalidosememail()
        {
            Usuario usuario = new Usuario(
                    "Ruan",
                    "",
                    "pastel231",
                    CodeTur.Comum.EnTipoUsuario.Admin
                );
            //Metodos estático para verificar condições nos teste
            //Retorna Se tudo estiver certo e validado 
            Assert.True(!usuario.IsValid, "Usuario Validado");

            //Isvalid verifica se é verdadeiro ou falso
        }


        //Sem usuario
        [Fact]
        public void DeveRetornarSeUsuarioForInvalidosemUsuario()
        {
            Usuario usuario = new Usuario(
                    "",
                    "ruangustavo@gmail.com",
                    "pastel231",
                    CodeTur.Comum.EnTipoUsuario.Admin
                );
            //Metodos estático para verificar condições nos teste
            Assert.True(!usuario.IsValid, "Usuario Validado");

            //Isvalid verifica se é verdadeiro ou falso
        }
    }
}
