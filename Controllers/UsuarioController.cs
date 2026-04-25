using CrudDapper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;   

        public UsuarioController(IUsuarioService usuarioService) { 
            
            _usuarioService = usuarioService;
        }  

        [HttpGet]
        public async Task<IActionResult> BuscarUsuarios()
        {
            var response = await _usuarioService.BuscarUsuarios();
            return Ok(response);
        }

        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> BuscarUsuarioPorId(int idUsuario)
        {
            var response = await _usuarioService.BuscarUsuarioPorId(idUsuario);
            return Ok(response);    
        }
    }
}
