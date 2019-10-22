using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using MailSender.Lib.Additions;
using MailSender.Lib.Data.BasedEntities;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Services.Linq2SQL
{
    public abstract class DataServiceLinq2SQL<T, TDb> : IDataService<T>
        where T : Entity, new()
        where TDb : class, IEntity, new()
    {
    protected readonly DataContext _db;

    protected readonly Table<TDb> _table;

    //public System.IO.TextWriter Log { get; set; }

        protected DataServiceLinq2SQL(DataContext db)
    {
        _db = db ?? throw new NullReferenceException($"Пустая ссылка {nameof(db)}");

        PropertyInfo property = db.GetType().GetProperty(typeof(TDb).Name) 
                                ?? throw new NullReferenceException(
                                    $"Таблица {typeof(TDb).Name} отсутствует в объекте {nameof(db)}");

        _table = property.GetValue(db) as Table<TDb>;
    }

    public T GetById(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id), id, "id должен быть больше нуля");
        }
        
        if (!_table.Any(i => i.Id == id))
        {
            throw new ArgumentNullException(nameof(id), $"Элемент с Id = {id} не найден в базе данных");
        }

        //_db.Log = Console.Out;
        var item = new T();
        TDb itemDb = _table.FirstOrDefault(i => (i as IEntity).Id == id);

        itemDb.CopyValuePropertiesTo(ref item);
        return item;
    }

    public void Create(T item)
    {
        if (item is null)
        {
            throw new NullReferenceException("Пустая ссылка");
        }

        if (item.Id != 0)
        {
            return;
        }

        item.Id = _table.Any() ? _table.Max(i => i.Id) + 1 : 1;
        TDb newItemInList = new TDb();
        item.CopyValuePropertiesTo(ref newItemInList);
        _table.InsertOnSubmit(newItemInList);
        _db.SubmitChanges();
    }

    public void Delete(T item)
    {
        if (item is null)
        {
            throw new NullReferenceException("Пустая ссылка");
        }

        _table.DeleteOnSubmit(_table.FirstOrDefault(i => i.Id == item.Id)
                              ?? throw new ArgumentNullException(nameof(item),
                                  $"Элемент с Id = {item.Id} не найден в базе данных"));
        _db.SubmitChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return _table.ToArray().Select(r =>
        {
            T item = new T();
            r.CopyValuePropertiesTo(ref item);
            return item;
        });
    }


    public void Update(T item)
    {
        if (item is null)
        {
            throw new NullReferenceException("Пустая ссылка");
        }

        if (!_table.Any(i => i.Id == item.Id))
        {
            throw new ArgumentNullException(nameof(item), $"Элемент с Id = {item.Id} не найден в базе данных");
        }

        TDb itemInList = _table.First(i => (i as IEntity).Id == item.Id);
        item.CopyValuePropertiesTo(ref itemInList);
        _db.SubmitChanges();

    }

    }
}
