using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using temperaturaAgora.Data;
using temperaturaAgora.Model;

namespace temperaturaAgora.repository.Service
{
    public class TemperatureService : IRepositoryTemperature
    {
        private readonly MongoDbContext<Temperature> context;
        public TemperatureService(IMongoDatabase database) => 
           context = new MongoDbContext<Temperature>(database,"temperature");
        
        public void DeleteByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Temperature>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Temperature> GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Temperature> InsertAsync(Temperature temperature)
        {
            throw new System.NotImplementedException();
        }

        public Task<Temperature> UpdateAsync(Temperature temperature)
        {
            throw new System.NotImplementedException();
        }
    }
}