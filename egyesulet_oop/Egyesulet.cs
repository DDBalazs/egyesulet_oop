using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyesulet_oop
{
    class Egyesulet
    {
        string nev;
        string szulo;
        int fo;
        int osszeg;

        private string Nev { get => nev; set => nev = value; }
        private string Szulo { get => szulo; set => szulo = value; }
        private int Fo { get => fo; set => fo = value; }
        private int Osszeg { get => osszeg; set => osszeg = value; }

        public Egyesulet(string sor)
        {
            string[] darabok = sor.Split(';');
            Nev = darabok[0];
            Szulo = darabok[1];
            Fo = Convert.ToInt32(darabok[2]);
            Osszeg = Convert.ToInt32(darabok[3]);
        }
    }
}
