using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Entities.Concrete
{
    public class Kargo
    {
        public int Id { get; set; }
        public string SiparisId { get; set; }
        public string KargoDurumu { get; set; }
        public string KargoNumarasi { get; set; }
    }
}
