using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Carro> carros = new List<Carro>();
            
            for (int i = 0; i < n; i++)
            {
                Carro c = new Carro();
                c.Placa = Console.ReadLine();
                c.Ano = int.Parse(Console.ReadLine());
                c.Modelo = Console.ReadLine();
                carros.Add(c);
            }

            Console.WriteLine("Digite uma placa.");
            string placa = Console.ReadLine();

             for (int i = 0; i < n ; i++)
             {
                 if (placa == carros[i].Placa)
                 {
                     Console.WriteLine(carros[i].Placa +" "+ carros[i].Ano +" "+ carros[i].Modelo);
                 }
             }

              
        }
    }
}
