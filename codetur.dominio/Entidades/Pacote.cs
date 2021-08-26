using System;
using CodeTur.Comum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTur.Comum.Enum;
using Flunt.Validations;
using Flunt.Notifications;

namespace codetur.dominio.Entidades
{
    class Pacote : Base
    {
        public Pacote(string titulo, string imagem, string descricao, EnStatusPacote status)
        {
            //para gerar um construtor rapido selecione todos os modelos e aperte crtl+. vai ter a opção de gerar construtor
            AddNotifications(
                new Contract<Notification>()
                .Requires()
                .IsNotEmpty(titulo, "Nome", "Nome não Pode ser Vazio")
                .IsNotEmpty(imagem, "Imagem", "Deve Haver uma Imagem")
                .IsNotEmpty(descricao,"Descrição", "a descrição não pode ser nula")
                .IsNotNull(status, "Status", "Status não pode ser nulo")
            );

            Titulo = titulo;
            Imagem = imagem;
            Descricao = descricao;
            Status = status;
        }

        public string Titulo { get;  private set; }
        public string Imagem { get; private set; }
        public string Descricao { get; private set; }

        //Instanciar pacote de Enumeração
        //Apenas Booleano seria 1 ou 2 com Enum pode ter mais opções
        public EnStatusPacote Status { get; private set; }
    }
}
