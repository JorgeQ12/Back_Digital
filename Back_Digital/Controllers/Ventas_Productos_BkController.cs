using Back_Digital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ventas_Productos_BkController : ControllerBase
    {
        private readonly ContextConecction _context;
        public Ventas_Productos_BkController(ContextConecction context)
        {
            _context = context;
        }
        // GET: api/<Ventas_Productos_Bk>
        [HttpGet("ListaVentasProductos")] //Lista de Productos
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Ventas_Productos_BkModels>? listaVentas = await _context.Ventas_Productos_Bk.ToListAsync();
                return Ok(listaVentas);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }


        // POST api/<Ventas_Productos_Bk>
        [HttpPost("AgregarVenta")]
        public async Task<IActionResult> Post(Ventas_Productos_BkModels ventas_Productos_Bk)
        {
            try
            {
                _context.Add(ventas_Productos_Bk);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<Ventas_Productos_Bk>/5
        [HttpPut("ActualizarVenta/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Ventas_Productos_BkModels ventas_Productos_Bk)
        {
            try
            {
                if (id != ventas_Productos_Bk.VentasP_Id)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(ventas_Productos_Bk);
                    await _context.SaveChangesAsync();
                    return Ok("Se ha Actualizado correctamente");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<Ventas_Productos_Bk>/5
        [HttpDelete("EliminarVenta/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _context.Ventas_Productos_Bk.FindAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Ventas_Productos_Bk.Remove(cliente);
                    await _context.SaveChangesAsync();
                    return Ok("Se ha eliminado el producto");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
