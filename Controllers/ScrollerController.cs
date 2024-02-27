using Microsoft.AspNetCore.Mvc;
using GuideAPI.Data;
using Microsoft.EntityFrameworkCore;
 
namespace GuideAPI.Controllers;
 
[ApiController]
[Route("[controller]")]
public class ScrollerController : ControllerBase
{
    private readonly MinecraftContext _Context;
    public ScrollerController(MinecraftContext minecraftContext)
    {
        _Context = minecraftContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var scrol = await _Context.Scroller.ToListAsync();
        return Ok(scrol);
    }
}