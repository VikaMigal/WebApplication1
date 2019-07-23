using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using Norm;
using WebApplication1.Contracts;


namespace WebApplication1.Repository
{
    public class RepositoryBase: IRepositoryBase
    {
//        private IMongo _provider;
//        private Norm.IMongoDatabase _db { get { return this._provider.Database; } }

        private IMongo _provider;
        private IMongoDatabase _db { get { return this._provider.Database; } }

//        
//        private readonly IConfiguration _configuration;
        public RepositoryBase()
        {

            _provider = Mongo.Create("mongodb://localhost:27017/Accountowner");
//            var client = new MongoClient("mongodb://localhost:27017");
//            _provider = client.GetDatabase("Accountowner")
                
        }


        public void Delete<T>(System.Linq.Expressions.Expression<Func<T, bool>> expression) where T : class, new()
        {
            var items = All<T>().Where(expression);
            foreach (T item in items)
            {
                Delete(item);
            }
        }
        public void Delete<T>(T item) where T : class, new()
        {
            // Remove the object.
            _db.GetCollection<T>().Delete(item);
        }
        public void DeleteAll<T>() where T : class, new()
        {
            _db.DropCollection(typeof(T).Name);
        }
        public T Single<T>(System.Linq.Expressions.Expression<Func<T, bool>> expression) where T : class, new()
        {
            return All<T>().Where(expression).SingleOrDefault();
        }
        public IQueryable<T> All<T>() where T : class, new()
        {

            return _db.GetCollection<T>().Find().AsQueryable();
        }
        
        public void Add<T>(T item) where T : class, new()
        {
            _db.GetCollection<T>().Save(item);
        }
        public void Add<T>(IEnumerable<T> items) where T : class, new()
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }
        public void Dispose()
        {
            _provider.Dispose();
        }
    }
}