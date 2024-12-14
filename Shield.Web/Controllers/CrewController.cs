using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shield.Web.Data.Contexts;

namespace Shield.Web.Controllers;

[ApiController]
[Route("api/crew")]
public class CrewController : ControllerBase
{
    private readonly DataContext _context;

    public CrewController(DataContext context)
    {
        _context = context;
    }

    [HttpGet("{crewId}/calls")]
    public async Task<IActionResult> GetCrewCalls([FromRoute] int crewId)
    {
        if (!_context.CrewCalls.Any(c => c.CrewId == crewId))
        {
            return NotFound();
        }

        return Ok(await _context.CrewCalls.Where(c => c.CrewId == crewId).ToListAsync());
    }
}
