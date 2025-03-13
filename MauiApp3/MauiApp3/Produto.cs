using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public List<Produto> Lista 
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Cheetos", Preco = 6.50, Categoria = "Salgadinho"});
                lista.Add(new Produto() { Nome = "Maria-Mole", Preco = 7, Categoria = "Docinho"});
                lista.Add(new Produto() { Nome = "Caixa de goodgood", Preco = 19.99, Categoria = "Docinho"});
                lista.Add(new Produto() { Nome = "Barra de chocolate", Preco = 15, Categoria = "Docinho" });
                lista.Add(new Produto() { Nome = "Baconzitos", Preco = 5, Categoria = "Salgadinho"});
                lista.Add(new Produto() { Nome = "Paçoca", Preco = 0.80, Categoria = "Docinho" });
                lista.Add(new Produto() { Nome = "Teste", Preco = 0.50, Categoria = "Salgadinho"});
                lista.Add(new Produto() { Nome = "aaaaa", Preco = 20, Categoria = "Salgadinho"});

                return lista;
            } 
        }
    }
}
