using ETicaret.Business.Abstract;
using ETicaret.Business.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using KaracaService;
using System.Linq;
using ETicaret.Entities.Concrete;

namespace ETicaret.Business.Concrete
{
    public class KaracaManager : IKaracaService
    {
        public bool KargoDurumuAktar(KargoDto kargo)
        {
            try
            {
                CalculatorSoapClient karacaService = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);

                karacaService.OpenAsync();

                karacaService.AddAsync(5, 3);

                karacaService.CloseAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public KargoDto KargoDurumuGetir(string siparisId)
        {
            List<Kargo> kargolar = new List<Kargo>();

            kargolar.Add(new Kargo
            {
                Id = 1,
                SiparisId = "A123456",
                KargoDurumu = "Taşınıyor",
                KargoNumarasi = "SK20221011001"
            });

            kargolar.Add(new Kargo
            {
                Id = 2,
                SiparisId = "A123457",
                KargoDurumu = "Taşınıyor",
                KargoNumarasi = "SK20221011002"
            });

            var kargo = kargolar.Select(x => new KargoDto
            {
                KargoDurumu = x.KargoDurumu,
                KargoNumarasi = x.KargoNumarasi,
                SiparisId = x.SiparisId
            }).FirstOrDefault(x => x.SiparisId == siparisId);
            return kargo;
        }
    }
}
