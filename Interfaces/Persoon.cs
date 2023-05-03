using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Persoon : IOuderdom
    {
        private string _voornaam;
        private string _familienaam;
        private int _geboortejaar;

        public Persoon(string eenVoornaam, string eenFamilienaam, int Geboortejaar) 
        {
            _voornaam = eenVoornaam;
            _familienaam = eenFamilienaam;
            _geboortejaar = Geboortejaar;
        }

        public int Ouderdom 
        {
            get 
            {
                return DateTime.Now.Year - _geboortejaar;
            }
        }

        public string Naam
        {
            get
            {
                return _voornaam + " " + _familienaam;
            }
        }
    }
}
