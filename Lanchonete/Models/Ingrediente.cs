using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete.Models
{
    public class Ingrediente
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("preco")]
        public decimal Preco { get; set; }
    }
}
