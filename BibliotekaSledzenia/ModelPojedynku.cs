using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaSledzenia
{
    public class ModelPojedynku
    {
        public List<ModelWpisuNaMecz> Wpisy { get; set; } = new List<ModelWpisuNaMecz>();
        public ModelZespolu Wygrany { get; set; }
        public int RundaPojedynku { get; set; }
    }
}
