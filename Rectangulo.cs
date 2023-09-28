using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public class Rectangulo
    {
        public virtual int Ancho { get; set; }
        public virtual int Alto { get; set; }

        public int CalcularArea()
        {
            return Ancho * Alto;
        }
    }
}
