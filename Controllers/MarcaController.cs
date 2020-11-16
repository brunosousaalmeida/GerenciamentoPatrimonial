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
    public class MarcaController : ControllerBase
    {
        private static List<Marca> marca =  new List<Marca>();

        public List<Marca> Get()
        {
            return marca;
        }

        public void Post(string nome)
        {
            marca.Add(new Marca(nome));
        }
    }
}

