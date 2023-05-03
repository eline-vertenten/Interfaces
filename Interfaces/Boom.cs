using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Boom : IOuderdom
    {
        private int _ringen;

        public Boom(int eenJaarGeplant)
        {
            _ringen = DateTime.Now.Year - eenJaarGeplant;
        }

        public int Ouderdom
        {
            get
            {
                return _ringen;
            }
        }

        public string Naam
        {
            get
            {
                return "Boom";
            }
        }
    }
}
