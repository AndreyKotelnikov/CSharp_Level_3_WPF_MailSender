using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public void Create(T item)
        {
            if (item is null) { throw new NullReferenceException("Пустая ссылка"); }
            if (item.Id != 0)
            {
                return;
            }
            item.Id = _itemsList.Count == 0 ? 1 : _itemsList.Max(i => i.Id) + 1;
            T newItemInList = new T();
            item.CloneTo(ref newItemInList);
            _itemsList.Add(newItemInList);
        }

        public void Delete(T item)
        {
            if (item is null) { throw new NullReferenceException("Пустая ссылка");}

            _itemsList.Remove(_itemsList.FirstOrDefault(i => i.Id == item.Id));
        }

        public IEnumerable<T> GetAll() => _itemsList;
        

        public T GetById(int id)
        {
            if (id <= 0) { throw new ArgumentOutOfRangeException(nameof(id), id, "id должен быть больше нуля");}

            return _itemsList.FirstOrDefault(i => i.Id == id);
        }

        public void Update(T item)
        {
            if (item is null) { throw new NullReferenceException("Пустая ссылка"); }

            if (!_itemsList.Select(r => r.Id).Contains(item.Id))
            {
                return;
            }
            T itemInList = _itemsList.FirstOrDefault(i => i.Id == item.Id);
            item.CloneTo(ref itemInList);
        }
    }
}
