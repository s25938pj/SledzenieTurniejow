using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaSledzenia
{
    public class ModelZespolu
    {
        public List<ModelOsoby> CzlonekZespolu { get; set; } = new List<ModelOsoby>();
        public string NazwaZespolu { get; set; }
    }
}
