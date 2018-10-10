using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class DataContext
    {
        IConfiguration configuration;

        public DataContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<T> Get<T>()
        {
            MongoClient client = new MongoClient(configuration.GetConnectionString("DefaultConnection"));

            IMongoDatabase data = client.GetDatabase("Lanchonete");

            return null;
        }
    }
}
