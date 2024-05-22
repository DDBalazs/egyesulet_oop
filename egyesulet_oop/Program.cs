using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyesulet_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Egyesulet> lista = new List<Egyesulet>();
            FileStream fs = new FileStream("bevasarlolista.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Egyesulet b = new Egyesulet(sr.ReadLine());
                lista.Add(b);
            }
            sr.Close();
            fs.Close();

            int bef = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                bef += lista[i].Fo;
            }        
        
        }
    }
}
