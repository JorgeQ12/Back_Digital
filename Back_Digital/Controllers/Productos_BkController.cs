using Back_Digital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productos_BkController : ControllerBase
    {
        private readonly ContextConecction _context;
        public Productos_BkController(ContextConecction context)
        {
            _context = context;
        }
        // GET: api/<Productos_Bk>
        [HttpGet("ListaProductos")] //Lista de Productos
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Productos_BkModels>? listaProductos = await _context.Productos_Bk.ToListAsync();
                return Ok(listaProductos);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // POST api/<Productos_Bk>
        [HttpPost("AgregarProducto")] //Agregar Productos
        public async Task<IActionResult> Post(Productos_BkModels productos_Bk)
        {
            try
            {
                _context.Add(productos_Bk);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<Productos_Bk>/5
        [HttpPut("ActualizarProducto/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Productos_BkModels productos_Bk)
        {
            try
            {
                if (id != productos_Bk.Producto_Id)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(productos_Bk);
                    await _context.SaveChangesAsync();
                    return Ok("Se ha Actualizado correctamente");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<Productos_Bk>/5
        [HttpDelete("EliminarProducto/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _context.Productos_Bk.FindAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Productos_Bk.Remove(cliente);
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
