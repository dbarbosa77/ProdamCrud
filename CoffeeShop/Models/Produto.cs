using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
