using System;
using AbstractFactory.Client;

namespace AbstractFactory
{
    class Program
    {
        private static void Main(string[] args)
        {
            var fordClient = CarroClient.CriarCarro("Ford");
            var GMClient = CarroClient.CriarCarro("GM");

            Console.WriteLine("*************** GM ***************");
            Console.WriteLine();
            Console.WriteLine(GMClient.BuscarCarroNovoDetalhes());
            Console.WriteLine(GMClient.BuscarCarroAntigoDetalhes());

            Console.WriteLine("\n");

            Console.WriteLine("*************** Ford ***************");
            Console.WriteLine();
            Console.WriteLine(fordClient.BuscarCarroNovoDetalhes());
            Console.WriteLine(fordClient.BuscarCarroAntigoDetalhes());
        }
    }
}
