using System.Threading.Tasks;
using temperaturaAgora.Model;

namespace temperaturaAgora.repository.Interfaces
{
    public interface ITemperature
    {
          Task<bool> SaveTemperature(Temperature temperature);
    }
}