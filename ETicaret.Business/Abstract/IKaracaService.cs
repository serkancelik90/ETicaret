using ETicaret.Business.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Business.Abstract
{
    public interface IKaracaService
    {
        bool KargoDurumuAktar(KargoDto kargo);
        KargoDto KargoDurumuGetir(string siparisId);
    }
}
