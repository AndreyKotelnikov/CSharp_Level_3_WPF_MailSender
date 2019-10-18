using System.Collections.Generic;
using MailSender.Lib.Data.BasedEntities;

namespace MailSender.Lib.Services.Interfaces
{
    public interface IDataService<T> where T:Entity
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Create(T item);

        void Update(T item);

        void Delete(T item);
    }
}