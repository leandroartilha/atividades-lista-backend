using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtividadesApi.Controllers
{
    [Route("api/[controller]")]
    public class AtividadeController : Controller
    {
        // GET: api/values
        [HttpGet]


        [HttpGet]
        public IEnumerable<Atividade> Get()
        {

            return new List<Atividade>() {
                new Atividade(),
                new Atividade(),
                new Atividade()
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"meu primeiro get com parametro: {id}";
        }

        // POST api/values
        [HttpPost]
        public Atividade Post(Atividade atividade)
        {
            atividade.Id = 1;
            atividade.Titulo = "bunda!";
            return atividade;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Atividade Put(int id, [FromBody] Atividade atividade)
        {
            atividade.Id = 1;
            atividade.Titulo = "Geralda";
            return atividade;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

