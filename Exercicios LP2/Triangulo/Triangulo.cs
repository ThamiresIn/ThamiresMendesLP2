using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo
    {

        public int PrimLado { get; set; }
        public int SeguLado { get; set; }
        public int TercLado { get; set; }
        public int id { get; set; }
        private int _cor;
        public int Cor
        {
            get { return _cor; }
            set{
                if (value <= (Math.Pow(2,24) - 1) && value >= 0)
                {
                    _cor = value;
                }

            }
        }
        public Triangulo() { }
        public Triangulo (int PrimLado, int SeguLado, int TercLado)
        {
           if ( PrimLado > 0 && SeguLado > 0 && TercLado >0)
           {
               if ( (PrimLado + SeguLado) > TercLado && (PrimLado + TercLado) > SeguLado && (SeguLado + TercLado) > PrimLado )
               {
                   this.PrimLado = PrimLado;
                   this.SeguLado = SeguLado;
                   this.TercLado = TercLado;
               }
           }
        }

        
        



    }
}
