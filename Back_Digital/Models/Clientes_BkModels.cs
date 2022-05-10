using System.ComponentModel.DataAnnotations;

namespace Back_Digital.Models
{
    public class Clientes_BkModels
    {
        [Key]
        public int Clientes_Id { get; set; }
        [Required]
        public string? Clientes_Nombre { get; set; }
        [Required]
        public string? Clientes_Identificacion { get; set; }
        [Required]
        public int Clientes_Edad { get; set; }
    }
}
