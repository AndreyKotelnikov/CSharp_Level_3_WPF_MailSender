﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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

        public int Create(T item)
        {
            if (item is null)
            {
                throw new NullReferenceException("Пустая ссылка");
            }

            if (item.Id != 0)
            {
                return 0;
            }

            item.Id = _table.Any() ? _table.Max(i => i.Id) + 1 : 1;
            TDb newItemInList = new TDb();
            item.CopyValuePropertiesTo(ref newItemInList);
            _table.InsertOnSubmit(newItemInList);
            _db.SubmitChanges();
            return newItemInList.Id;
        }

        public bool Delete(int id)
        {

            _table.DeleteOnSubmit(_table.FirstOrDefault(i => i.Id == id)
                                  ?? throw new ArgumentNullException(nameof(id),
                                      $"Элемент с Id = {id} не найден в базе данных"));
            _db.SubmitChanges();
            return true;
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


        public T Update(int id, T item)
        {
            if (item is null)
            {
                throw new NullReferenceException("Пустая ссылка");
            }

            if (!_table.Any(i => i.Id == id))
            {
                throw new ArgumentNullException(nameof(id), $"Элемент с Id = {id} не найден в базе данных");
            }

            TDb itemInList = _table.First(i => (i as IEntity).Id == id);
            item.CopyValuePropertiesTo(ref itemInList);
            _db.SubmitChanges();
            T result = new T();
            itemInList.CopyValuePropertiesTo(ref result);
            return result;
        }

        public async Task<int> CreateAsync(T item) => await Task.Run(() => Create(item)).ConfigureAwait(false);

        public async Task<bool> DeleteAsync(int id) => await Task.Run(() => Delete(id));

        public async Task<IEnumerable<T>> GetAllAsync() => await Task.Run(() => GetAll());

        public async Task<T> GetByIdAsync(int id) => await Task.Run(() => GetById(id));

        public async Task<T> UpdateAsync(int id, T item) => await Task.Run(() => Update(id, item));
    }
}
