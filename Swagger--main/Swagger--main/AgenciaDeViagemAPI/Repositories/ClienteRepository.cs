using WonderAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WonderAPI.Repositories
{
    public class ClienteRepository : ClientesRepository
    {
        public readonly ClienteContext _context;

        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }
        public async Task<agencia> Create(Agencia agencia)
        {
            _context.Agencia.Add(agencia);
           await _context.SaveChangesAsync();

            return agencia;
        }

        public async Task Delete(int id)
        {
            var agenciaToDelete = await _context.Agencia.FindAsync(id);
            _context.Agencia.Remove(agenciaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<agencia>> Get()
        {
          return await  _context.agencia.ToListAsync();
        }

        public async Task<Agencia> Get(int id)
        {
            return await _context.Agencia.FindAsync(id);
        }

        public async Task Update(Agencia agencia)
        {
            _context.Entry(agencia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
