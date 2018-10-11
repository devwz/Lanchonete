using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Core.Entities
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }

        public static List<Ingrediente> Get()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>()
            {
                new Ingrediente() { Id = 1, Titulo = "Alface" },
                new Ingrediente() { Id = 2, Titulo = "Bacon" },
                new Ingrediente() { Id = 3, Titulo = "Hambúrguer de Carne" },
                new Ingrediente() { Id = 4, Titulo = "Ovo" },
                new Ingrediente() { Id = 5, Titulo = "Queijo" }
            };

            return ingredientes;
        }

        public static Ingrediente Get(string titulo)
        {
            return Ingrediente.Get().Find(p => p.Titulo == titulo);
        }

        public static Ingrediente Get(int id)
        {
            return Ingrediente.Get().Find(p => p.Id == id);
        }
    }
}
