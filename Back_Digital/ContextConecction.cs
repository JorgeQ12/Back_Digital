using Back_Digital.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_Digital
{
    public class ContextConecction: DbContext
    {
        public  DbSet<Clientes_BkModels>? Clientes_Bk { get; set; }
        public  DbSet<Productos_BkModels>? Productos_Bk { get; set; }
        public  DbSet<Ventas_Productos_BkModels>? Ventas_Productos_Bk { get; set; }

        public ContextConecction(DbContextOptions<ContextConecction> options) : base(options)
        {

        }
    }
}
