using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoljeTest
{
    public class Okvir
    {
        public Okvir()
        {
            _gornjiDesni = "╗";
            _gornjiLijevi = "╔";
            _donjiDesni = "╝";
            _donjiLijevi = "╚";
            _bocni = "║";
            _gornji = "═";
        }

        public void populacijaReda(int sirina, string elReda)
        {
            if (elReda == null)
            {
                red.Add(_gornjiLijevi);
                foreach (string s in red)
                {
                    red.Add(_gornji);
                }
                red.Add(_gornjiDesni);
            }
            else if (iteracijaReda<_visina)
            {
                red.Add(_bocni);
                red.AddRange(red);
                red.Add(elReda);
                red.Add(_bocni);
            }
            else 
            {
                red.Add(_donjiLijevi);
                foreach (string s in red)
                {
                    red.Add(_gornji);
                }
                red.Add(_donjiDesni);
            }

        }

        List<string> red = new List<string>();

        string _gornjiDesni;
        string _gornjiLijevi;
        string _donjiDesni;
        string _donjiLijevi;
        string _bocni;
        string _gornji;

        int iteracijaReda;

        int _sirina;
        public int Sirina 
        {
            get 
            {
                return _sirina;  
            }
            set 
            {
                if (value != 0) 
                {
                    _sirina = value;
                }
            }
        }

        int _visina;
        public int Visina
        {
            get
            {
                return _visina;
            }
            set
            {
                if (value != 0)
                {
                    _visina = value;
                }
            }
        }

    }
}
