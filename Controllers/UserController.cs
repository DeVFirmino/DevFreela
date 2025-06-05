using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/users")]

public class UserController : ControllerBase
{
    
    [HttpPost] //cadastro users
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPost("{id}/profile-picture")]
    
    public IActionResult UploadArchive([FromForm] EmailModelsInput models)
    
    {
        var description = $"File: {models.File.FileName}, Size : {models.File.Length}";
        
        return Ok(description);
        
    }
    }
    
