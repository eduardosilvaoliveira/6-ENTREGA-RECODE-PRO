using WonderAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WonderAPI.Repositories
{
    public interface ClientesRepository 
    {
        Task<IEnumerable<agencia>> Get();

        Task<Agencia> Get(int Id);

        Task<Agencia> Create(Agencia agencia);

        Task Update(Agencia agencia);

        Task Delete(int Id);
    }
}
