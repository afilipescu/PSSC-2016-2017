using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor : iProfesor
    {
        string nume { get; set; }


        public Profesor(string nume)
        {
            this.nume = nume;
        }

        public void consultaDiscipline()
        {
            throw new NotImplementedException();
        }

        public void introducereSituatie()
        {
            throw new NotImplementedException();
        }
    }
}
