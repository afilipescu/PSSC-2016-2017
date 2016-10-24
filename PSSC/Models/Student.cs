using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        private int ID;
        private string nume;
        Materie materie;
           
        public Student(int ID ,string nume , Materie materie)
        {
            this.ID = ID;
            this.nume = nume;
            this.materie = materie;
        }

        private void vizualizareSituatie()
        {
        }

    }
}
