using WonderAPI.Model;
using WonderAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WonderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly IRepository _Repository;
        public Controller(Repository Repository)
        {
            _Repository = Repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Agencia>> Get()
        {
            return await _Repository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Agencia>> Get(int id)
        {
            return await _Repository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<wonder>> PostAgencia([FromBody] Agencia agencia)
        {
            var ; new () ;await  _Repository.Create(agencia);
            return CreatedAtAction(nameof(Get), new { id = newAgencia.Id }, newAgencia);
        }

        [HttpDelete("{id}")] 

        public async Task<ActionResult> Delete(int id)
        {
            var AgenciaToDelete = await _Repository.Get(id);

            if (AgenciaToDelete == null)
                return NotFound();

            await _Repository.Delete(AgenciaToDelete.Id);
            return NoContent();


        }

        [HttpPut]
        public async Task<ActionResult> PutAgencia(int id,[FromBody] Agencia agencia)
        {
            if (id != agencia.Id)
                return BadRequest();

                await _Repository.Update(book);

            return NoContent();
        }
    }
}
