using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
