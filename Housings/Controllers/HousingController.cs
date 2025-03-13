using Housings.Application.Housings;
using Microsoft.AspNetCore.Mvc;

namespace Housings.API.Controllers;

[ApiController]
[Route("api/housings")]
public class HousingController(IHousingsService housingsService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var housings = await housingsService.GetAllHousings();
        return Ok(housings);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) 
    {
        var housings = await housingsService.GetById(id);
        if (housings == null)
            return NotFound();

        return Ok(housings);
    }
}
