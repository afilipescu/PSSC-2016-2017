using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat : iDecanat, Materie
    {
        public Dictionary<int, string> materii { get; set; }
        public Dictionary<Profesor, string> profesori { get; set; }


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
