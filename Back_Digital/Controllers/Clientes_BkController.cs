using Back_Digital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back_Digital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clientes_BkController : ControllerBase
    {
        private readonly ContextConecction _context;
        public Clientes_BkController (ContextConecction context)
        {
            _context = context;
        }
        // GET: api/<Clientes_Bk>
        [HttpGet("ListaClientes")] //LISTA DE CLIENTES TOTALES
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Clientes_BkModels>? listaClientes = await _context.Clientes_Bk.ToListAsync();
                return Ok(listaClientes);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // GET api/<Clientes_Bk>/5
        [HttpGet("Cliente/{id}")] //Busqueda por ID
        public async Task<IActionResult> Get(int id)
        {
            var clienteId = await _context.Clientes_Bk.FindAsync(id);
            if(clienteId == null)
            {
                return NotFound();
            }
            return Ok(clienteId);
        }

        // POST api/<Clientes_Bk>
        [HttpPost("insertarCliente")]  //Ingresar Cliente
        public async Task<IActionResult> Post(Clientes_BkModels clientes_Bk)
        {
            try
            {
                _context.Add(clientes_Bk);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<Clientes_Bk>/5
        [HttpPut("ClienteActualizar/{id}")] //Actualizar datos del cliente
        public async Task<IActionResult> Put(int id, [FromBody] Clientes_BkModels clientes_Bk)
        {
            try
            {
                if(id != clientes_Bk.Clientes_Id)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(clientes_Bk);
                    await _context.SaveChangesAsync();
                    return Ok("Se ha ingresado correctamente" );
                }

            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<Clientes_Bk>/5
        [HttpDelete("eliminarCliente/{id}")] //Eliminar Cliente
        public async Task<IActionResult> Delete(int id)
        { 
            try
            {
                var cliente = await _context.Clientes_Bk.FindAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Clientes_Bk.Remove(cliente);
                    await _context.SaveChangesAsync();
                    return Ok("Se ha eliminado el cliente");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
