using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaSledzenia
{
    public class ModelWpisuNaMecz
    {
        /// <summary>
        /// Reprezentuje jedną drużynę w meczu
        /// </summary>
        public ModelZespolu RywalizacjaDruzynowa { get; set; }
        /// <summary>
        /// Reprezentuje wynik poszczególnych zespołów
        /// </summary>
        public double Wynik { get; set; }
        /// <summary>
        /// Reprezentuje pojedynek z którego dana drużyna zostaje zwyciężcą
        /// </summary>
        public ModelPojedynku RodzicPojedynku { get; set; }
        
    }
}
