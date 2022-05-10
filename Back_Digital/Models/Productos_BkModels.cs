using System.ComponentModel.DataAnnotations;

namespace Back_Digital.Models
{
    public class Productos_BkModels
    {
        [Key]
        public int Producto_Id { get; set; }
        [Required]
        public string? Producto_Nombre { get; set; }
        [Required]
        public int Producto_Cantidad { get; set; }
        [Required]
        public int Producto_Precio { get; set; }
    }
}
