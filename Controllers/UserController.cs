using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/users")]

public class UserController : ControllerBase
{
    
    [HttpPost] //cadastro users
    public IActionResult Post(CreateUserInputModel model)
    {
        return Ok();
    }

    [HttpPost("{id}/skills")]
    public IActionResult PostSkills(UserSkillsInputModel model)
    {
        return NoContent();
    }

    [HttpPost("{id}/profile-picture")]
    
    public IActionResult UploadArchive([FromForm] EmailModelsInput models)
    
    {
        var description = $"File: {models.File.FileName}, Size : {models.File.Length}";
        
        return Ok(description);
        
    }
    }
    
