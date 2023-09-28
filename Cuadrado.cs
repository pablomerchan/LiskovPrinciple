using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public class Cuadrado : Rectangulo
    {
        private int _lado;

        public override int Ancho
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public override int Alto
        {
            get { return _lado; }
            set { _lado = value; }
        }
    }
}
