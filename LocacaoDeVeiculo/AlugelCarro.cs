using System;
using LocacaoDeVeiculo.Entities;

namespace LocacaoDeVeiculo
{
    class AlugelCarro
    {
        public DateTime Inicio { set; get; }
        public DateTime Fim { set; get; }

        public Veiculo Modelo { set; get; }
        public NotaFiscal NotaFiscal { set; get; }

        public AlugelCarro(DateTime inicio, DateTime fim, Veiculo modelo)
        {
            Inicio = inicio;
            Fim = fim;
            Modelo = modelo;
        }
    }
}