using StructureMap;
using WebApplication1.Contracts;
using WebApplication1.Repository;

namespace WebApplication1
{
    internal class Setup
    {
        private readonly MongoDbContext _mongoDbContext;
        
        public Setup(MongoDbContext  mongoDbContext) {
            _mongoDbContext = mongoDbContext;
        }
        /// <summary>
        /// Initializes StructureMap (dependency injector) to setup our database provider.
        /// </summary>
        public void Initialize()
        {
            // Initialize our concrete database provider type.
            ObjectFactory.Initialize(x => { x.For<IRepositoryBase>().Use<RepositoryBase>(); });
        }
       
    }
}