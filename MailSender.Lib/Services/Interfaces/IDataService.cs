using System.Collections.Generic;
using System.Threading.Tasks;
using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.Services.Interfaces
{
    public interface IDataService<T> where T:Entity
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        int Create(T item);

        Task<int> CreateAsync(T item);

        T Update(int id, T item);

        Task<T> UpdateAsync(int id, T item);

        bool Delete(int id);

        Task<bool> DeleteAsync(int id);
    }
}