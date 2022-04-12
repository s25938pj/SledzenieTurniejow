using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaSledzenia
{
    public class ModelTurnieju
    {
        public string NazwaTurnieju { get; set; }
        public decimal Wpisowe { get; set; }
        public List<ModelZespolu> ZgloszoneDruzyny { get; set; } = new List<ModelZespolu>();
        public List<ModelNagrody> Nagrody { get; set; } = new List<ModelNagrody>();
        public List<List<ModelPojedynku>> Rundy { get; set; } = new List<List<ModelPojedynku>>();

    }
}
