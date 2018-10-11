using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete.Models
{
    public class Lanche
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("preco")]
        public decimal Preco { get; set; }

        [BsonElement("ingredientes")]
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
