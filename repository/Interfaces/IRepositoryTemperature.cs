using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using temperaturaAgora.Model;

namespace temperaturaAgora.repository
{
    public interface IRepositoryTemperature
    {
         Task<IEnumerable<Temperature>> GetAllAsync();
         Task<Temperature> GetByIdAsync(string id);
         Task<Temperature> InsertAsync(Temperature temperature);
         Task<Temperature> UpdateAsync(Temperature temperature);
         void DeleteByIdAsync(string id);
    }
}