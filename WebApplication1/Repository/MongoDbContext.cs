using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Norm.Collections;
using StructureMap;
using WebApplication1.Contracts;
using WebApplication1.Models;


namespace WebApplication1.Repository
{
    public class MongoDbContext: DbContext
    {

//        private RepositoryBase _repositoryBase = null;
//        
////        private IMongo _provider;
////        private IMongoDatabase _db { get { return this._provider.Database; } }
////        
////        protected RepositoryContext RepositoryContext { get; set; }
//        
//        public DbContext(IConfiguration config)
//        {
//            _repositoryBase = new RepositoryBase(config);
////            this.RepositoryContext = repositoryContext;
////            _provider = Mongo.Create(config.GetConnectionString("Accountowner"));
//        }
//        public IConfigurationRoot Configuration { get; }
//        private IMongoDatabase _database = null;
//
        public MongoDbContext()
        {
            ObjectFactory.Initialize(x => { x.For<IRepositoryBase>().Use<RepositoryBase>(); });
        }

//        public IRepositoryBase Current
//        {
//            get
//            {
//                return new RepositoryBase(null);
////            return _database;
//              return ObjectFactory.GetInstance<IRepositoryBase>();
//            }
//        }
    }
}