using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Additions;
using MailSender.Lib.Data.BasedEntities;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.InMemory
{
    public  abstract class DataServiceInMemory<T> : IDataService<T> where  T:Entity, new()
    {
        protected  readonly List<T> _itemsList = new List<T>();
        
        public int Create(T item)
        {
            if (item is null) { throw new NullReferenceException("Пустая ссылка"); }
            if (item.Id != 0)
            {
                return 0;
            }
            item.Id = _itemsList.Count == 0 ? 1 : _itemsList.Max(i => i.Id) + 1;
            T newItemInList = new T();
            item.CopyValuePropertiesTo(ref newItemInList);
            _itemsList.Add(newItemInList);
            return newItemInList.Id;
        }

        public async Task<int> CreateAsync(T item) => await Task.Run(() => Create(item));


        public bool Delete(int id)
        {
            T itemInList = _itemsList.FirstOrDefault(i => i.Id == id);

            if (itemInList == null)
            {
                return false;
            }

            _itemsList.Remove(itemInList);
            return true;
        }

        public async Task<bool> DeleteAsync(int id) => await Task.Run(() => Delete(id));
        

        public IEnumerable<T> GetAll() => _itemsList;

        public async Task<IEnumerable<T>> GetAllAsync() => await Task.Run(() => GetAll());
        

        public T GetById(int id)
        {
            if (id <= 0) { throw new ArgumentOutOfRangeException(nameof(id), id, "id должен быть больше нуля");}

            return _itemsList.FirstOrDefault(i => i.Id == id);
        }

        public async Task<T> GetByIdAsync(int id) => await Task.Run(() => GetById(id));
        

        public T Update(int id, T item)
        {
            if (item is null) { throw new NullReferenceException("Пустая ссылка"); }

            if (_itemsList.All(i => i.Id != id))
            {
                return null;
            }
            T itemInList = _itemsList.First(i => i.Id == id);
            item.CopyValuePropertiesTo(ref itemInList);
            T result = new T();
            itemInList.CopyValuePropertiesTo(ref result);
            return result;
        }

        public async Task<T> UpdateAsync(int id, T item) => await Task.Run(() => Update(id, item));
        
    }
}
