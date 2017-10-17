using System;

namespace WebApiVagas.Models.Entities
{
    public class Vaga
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Empresa { get; set; }

        public string Requisitos { get; set; }

        public decimal SalarioInicial { get; set; }

        public decimal SalarioMaximo { get; set; }

        public bool Ativa { get; set; } = true;

        public DateTime DataCadastro { get; private set; } = DateTime.Today;
 
        public string EstadoTrabalho { get; set; }

        public string CidadeTrabalho { get; set; }

        public string EmailContato { get; set; }
    }
}