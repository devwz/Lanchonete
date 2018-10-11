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
        IMongoDatabase data;

        public DataContext(IConfiguration configuration)
        {
            this.configuration = configuration;

            try
            {
                MongoClient client = new MongoClient(configuration.GetConnectionString("DefaultConnection"));
                data = client.GetDatabase("Lanchonete");
            }
            catch (Exception e)
            {
                throw new Exception("Servidor não encontrado.", e);
            }
        }

        internal List<T> Get<T>(string collection)
        {
            FilterDefinition<T> filter = FilterDefinition<T>.Empty;
            return data.GetCollection<T>(collection).Find(filter).ToList();
        }

        internal T Get<T>(string collection, string titulo)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Titulo", titulo);
            return data.GetCollection<T>(collection).Find(filter).FirstOrDefault();
        }
    }
}
