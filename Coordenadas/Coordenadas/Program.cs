using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double sx = 0, sy = 0, x, y, xm, ym , dp, sd = 0;

            int N = int.Parse(Console.ReadLine());

            List<Ponto> pontos = new List<Ponto>();
            for (int i = 0; i < N; i++)
            {                
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Beep();
                Ponto p = new Ponto(x,y);
                pontos.Add(p);                
                Console.Clear();
            }
            for (int i = 0; i < N - 1; i++)
            {
                sx += pontos[i].x;
                sy += pontos[i].y;
                dp = Math.Sqrt(Math.Pow(pontos[i + 1].x - pontos[i].x, 2) + Math.Pow(pontos[i + 1].y - pontos[i].y, 2));
                Console.WriteLine("distância ({0} , {1}  ,  {2} , {3}) = {4}", pontos[i].x, pontos[i].y, pontos[i + 1].x, pontos[i + 1].y, dp);
                sd += dp;
            }
            xm = sx / N;
            ym = sy / N;
            Console.WriteLine("O ponto médio é ({0} , {1}) ", xm, ym);
            Console.WriteLine("A soma das distâncias é = {0}", sd);

        }
    }
}
