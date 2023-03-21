using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadesApi.Contexto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtividadesApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : Controller
    {
        private readonly AppDbContext _context;

        public AtividadeController(AppDbContext context)
        {
            _context = context;
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<Atividade> Get()
        {
            return _context.Atividades;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Atividade Get(int id)
        {
            //return $"meu primeiro get com parametro: {id}";
            return _context.Atividades.FirstOrDefault(a => a.Id == id);
        }

        // POST api/values
        [HttpPost]
        public Atividade Post(Atividade atividade)
        {
            _context.Atividades.Add(atividade);
            if (_context.SaveChanges() > 0)
            {
                return atividade;
            }
            else
            {
                throw new Exception("Erro ao adicionar atividade");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Atividade Put(int id, [FromBody] Atividade atividade)
        {
            if (atividade.Id != id)
            {
                throw new Exception("Id inexistente, tente novamente");
            }
            else
            {
                _context.Update(atividade);
            }
            
            if (_context.SaveChanges() > 0)
            {
                return _context.Atividades.FirstOrDefault(a => a.Id == id);
            }
            else
            {
                return new Atividade();
            }
                
            
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var atividade = _context.Atividades.FirstOrDefault(a => a.Id == id);

            if (atividade == null)
            {
                throw new Exception("Atividade não encontrada!");
            }
            else
            {
                _context.Atividades.Remove(atividade);
            }

            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}

