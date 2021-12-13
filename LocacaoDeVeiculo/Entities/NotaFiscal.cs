using System;
using System.Globalization;

namespace LocacaoDeVeiculo.Entities
{
    class NotaFiscal

    {
        public double Pagamento { get; set; }
        public double Taxa { get; set; }

        public NotaFiscal(double pagamento, double taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }

        public double TotalPagamento
        {
            get { return Pagamento + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento: "
                + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal a Pagar: " 
                +TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
