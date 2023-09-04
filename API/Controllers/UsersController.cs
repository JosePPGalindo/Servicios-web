using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")] // api/users
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {   
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AppUser>> GetUsers(){
        
    }
}