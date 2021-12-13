using System;

namespace LocacaoDeVeiculo.Services
{
    class BrasilTaxService
    {
        public double Tax(double mont)
        {
            if (mont <= 100.00)
            {
                return mont * 0.20;
            }
            else
            {
                return mont * 0.15;
            }
        }
    }
}
