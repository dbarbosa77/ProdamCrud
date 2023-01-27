using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
