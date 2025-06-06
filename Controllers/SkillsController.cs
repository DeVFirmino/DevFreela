using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers; 

[ApiController]
[Route("api/users/skills")]

public class SkillsController : ControllerBase
{
    
        [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    //Post API Skills
    [HttpPost]
    public IActionResult Post(CreateSkillInputModel model)
    {
        return Ok();
    }
}