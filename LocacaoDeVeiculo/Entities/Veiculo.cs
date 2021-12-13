using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeVeiculo.Entities
{
    class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string modelo)
        {
            Modelo = modelo;

        }

    }
}
