using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Carros_v2.classes
{
    public class classCarros
    {
        public int id     { get; set; }
        public string cor    { get; set; }
        public string marca  { get; set; }
        public string modelo { get; set; }
        public string ano    { get; set; }

        // Adicionais :D
        public bool   aerofolio { get; set; }
        public int    portas    { get; set; }
        public string potencia  { get; set; }

    }
}
