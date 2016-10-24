using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tipExamen { examen, distribuita };
    class Materie
    {
        tipExamen tipMaterie;
        string nume { get; set; }
        int numarCredite { get; set; }
        int prezenta { get; set; }
        float notaFinala { get; set; }
        float notaActivitate { get; set; }


        public Materie(tipExamen tipMaterie, string nume, int numarCredite, int prezenta, float notaFinala, float notaActivitate)
        {
            this.tipMaterie = tipMaterie;
            this.nume = nume;
            this.numarCredite = numarCredite;
            this.prezenta = prezenta;
            this.notaFinala = notaFinala;
            this.notaActivitate = notaActivitate;
        }

    }
}
