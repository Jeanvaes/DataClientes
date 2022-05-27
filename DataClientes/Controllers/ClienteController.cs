using DataClientes.Datos.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataClientes.Datos.Modelo;


namespace DataClientes.Controllers
{

    [Route("[controller]/[action]")]
    public class ClienteController : ControllerBase
    {
        private readonly RepositorioClientes _context;

        public ClienteController(RepositorioClientes context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarCliente()
        {
            return Ok(await _context.Cliente.ToListAsync());
        }



        [HttpPost]
        public async Task<IActionResult> AgregarCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarCliente(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarCliente(Cliente cliente)
        {
            _context.Remove(cliente);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
