using ETicaret.Business.Abstract;
using ETicaret.Business.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KargoController : ControllerBase
    {
        private IKaracaService _karacaService;
        public KargoController(IKaracaService karacaService)
        {
            _karacaService = karacaService;
        }

        [HttpPost("KargoDurumuAktar")]
        public IActionResult KargoDurumuAktar(KargoDto kargo)
        {
            _karacaService.KargoDurumuAktar(kargo);
            return Ok();
        }

        [HttpGet("KargoDurumuGetir")]
        public IActionResult KargoDurumuGetir(string siparisId)
        {
            var kargo = _karacaService.KargoDurumuGetir(siparisId);
            return Ok(kargo);
        }
    }
}
