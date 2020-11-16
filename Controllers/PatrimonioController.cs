using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoPatrimonial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoPatrimonial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatrimonioController : ControllerBase
    {
        private static List<Patrimonio> patrimonio = new List<Patrimonio>();

        public List<Patrimonio>Get()
        {
            return patrimonio;
        }

        public void Post(string nome, int marcaId, string descricao)
        {
            patrimonio.Add(new Patrimonio(nome, marcaId, descricao));
        }
    }
}
