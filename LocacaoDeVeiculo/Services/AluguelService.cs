using System;
using System.Globalization;
using LocacaoDeVeiculo.Entities;
using LocacaoDeVeiculo.Services;

namespace LocacaoDeVeiculo.Services
{
    class AluguelService
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private BrasilTaxService _brasilTaxService = new BrasilTaxService();

        public AluguelService(double precoHora, double precoDia)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessaNota(AlugelCarro CarroAlugado)
        {
            TimeSpan duracao = CarroAlugado.Fim.Subtract(CarroAlugado.Inicio);

            double pagamento = 0.0;

            if (duracao.TotalHours <=12)
            {
                pagamento = PrecoHora * Math.Ceiling(duracao.TotalHours); //Mapth.Ceiling arredonda pra cima
            }
            else
            {
                pagamento = PrecoDia * Math.Ceiling(duracao.TotalDays); // TotalDays e TotalHours são nativas

            }

            double tax = _brasilTaxService.Tax(pagamento);

            CarroAlugado.NotaFiscal = new NotaFiscal(pagamento, tax);
        }
    }
}
