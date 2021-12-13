using System;
using System.Globalization;
using LocacaoDeVeiculo.Entities;
using LocacaoDeVeiculo.Services;

namespace LocacaoDeVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados de Locação ");
            Console.WriteLine();

            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Digite o inicio do Aluguel (dd/MM/yyyy HH:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o Fim do Aluguel (dd/MM/yyyy HH:mm): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Digite o Preço por Hora: ");
            double phora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite o Preço da Diaria: ");
            double pdia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            AlugelCarro carroAlugado = new AlugelCarro(inicio, fim, new Veiculo(modelo));

            AluguelService aluguelservice = new AluguelService(phora, pdia);

            aluguelservice.ProcessaNota(carroAlugado);

            Console.WriteLine("NOTA FISCAL :  ");
            Console.WriteLine(carroAlugado.NotaFiscal);
            Console.ReadLine();
        }
    }
}
