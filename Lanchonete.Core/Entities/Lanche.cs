using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete.Core.Entities
{
    public class Lanche
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }

        public static List<Lanche> Get()
        {
            List<Lanche> lanches = new List<Lanche>()
            {
                new Lanche()
                {
                    Id = 1,
                    Titulo = "X-Bacon",
                    Preco = 6.50m,
                    Ingredientes = new List<Ingrediente>()
                    {
                        Ingrediente.Get("Bacon"),
                        Ingrediente.Get("Hambúrguer de Carne"),
                        Ingrediente.Get("Queijo")
                    }
                },
                new Lanche()
                {
                    Id = 2,
                    Titulo = "X-Burger",
                    Preco = 4.5m,
                    Ingredientes = new List<Ingrediente>()
                    {
                        Ingrediente.Get("Hambúrguer de Carne"),
                        Ingrediente.Get("Queijo")
                    }
                },
                new Lanche()
                {
                    Id = 3,
                    Titulo = "X-Egg",
                    Preco = 5.3m,
                    Ingredientes = new List<Ingrediente>()
                    {
                        Ingrediente.Get("Ovo"),
                        Ingrediente.Get("Hambúrguer de Carne"),
                        Ingrediente.Get("Queijo")
                    }
                },
                new Lanche()
                {
                    Id = 4,
                    Titulo = "X-Egg Bacon",
                    Preco = 7.3m,
                    Ingredientes = new List<Ingrediente>()
                    {
                        Ingrediente.Get("Ovo"),
                        Ingrediente.Get("Bacon"),
                        Ingrediente.Get("Hambúrguer de Carne"),
                        Ingrediente.Get("Queijo")
                    }
                }
            };

            return lanches;
        }

        public static Lanche Get(string titulo)
        {
            return Lanche.Get().Find(p => p.Titulo == titulo);
        }

        public static Lanche Get(int id)
        {
            return Lanche.Get().Find(p => p.Id == id);
        }
    }
}
