using System.ComponentModel.DataAnnotations;

namespace Back_Digital.Models
{
    public class Ventas_Productos_BkModels
    {
        [Key]
        public int VentasP_Id { get; set; }
        [Required]
        public string? VentasP_Comprador { get; set; }
        [Required]
        public string? VentasP_Nombre { get; set; }
        [Required]
        public int VentasP_Cantidad { get; set; }   
        [Required]
        public DateTime? VentasP_Fecha { get; set; }
        [Required]
        public int VentasP_PrecioF { get; set; }    
    }
}
