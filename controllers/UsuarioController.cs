/*using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAPI.models;
using TodoAPI.db;

[ApiController]
[Route("api/[controller]/[Action]")]
public class UsuarioController : ControllerBase
{

    private readonly AppDbContext _context;

    public UsuarioController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Usuario
    [HttpGet("{email}/.{password}")]
    public async Task<ActionResult<bool>> GetAutorizacion(string email, string password)
    {

        try
        {
            return await _context.usuarios.FindAsync(w => w.Email.Equals(email) && w.Password.Equals(password));

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost]
    public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
    {
        try
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}*/