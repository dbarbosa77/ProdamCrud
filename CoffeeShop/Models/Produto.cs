using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Produto
    {
        [Key]
        public int Id_produto { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
    }
}
