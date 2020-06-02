using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SimpleBase
{
    public class Items
    {
        //public int ID { get; set; }
        public int Variant { get; set; }
        public string Surname { get; set; }
        public string Cable { get; set; }
        public string Closure { get; set; }
        public string Converter { get; set; }
        public string Transiver { get; set; }
        public string Transponder { get; set; }
        public string Switch { get; set; }
        public string OpticalAmplifier { get; set; }
        public string MUX { get; set; }
        public int Price { get; set; }
       
    }
}
