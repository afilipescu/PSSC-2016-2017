using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tipMaterie { examen, distribuita };
    class Materie
    {
        tipMaterie tipMaterie;
        string nume { get; set; }
        float notaFinala { get; set; }
        float notaActivitate { get; set; }
        int prezenta { get; set; }
    }
}
