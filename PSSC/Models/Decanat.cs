using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat : iDecanat
    {
        public Dictionary<int, Materie> materii { get; set; }
        public Dictionary<Profesor, string> profesori { get; set; }


        public Decanat(Dictionary<int, Materie> materii, Dictionary<Profesor, string> profesori)
        {
            this.materii = materii;
            this.profesori = profesori;
        }


        public void adaugareMaterie()
        {
            throw new NotImplementedException();
        }

        public void generareRapoarte()
        {
            throw new NotImplementedException();
        }

        public void calculareMedie()
        {
            throw new NotImplementedException();
        }
    }
}
