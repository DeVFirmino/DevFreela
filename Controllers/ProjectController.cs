using DevFreela.Controllers.Models;
using DevFreela.Models;
using DevFreela.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/projects")]

public class ProjectController : ControllerBase
{
        private readonly FreelanceTotalCostConfig _config;
        private readonly IConfigService _configService;

        [HttpGet]
        public IActionResult Get(string search = "")
        {
                return Ok();
        }
        
        // GET api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
                return Ok();
        }

        //POST api/projects
        [HttpPost()]
        public IActionResult Post(CreateProjectInputModel model)
        {
                
                return CreatedAtAction(nameof(GetById), new{id = 1}, model);
        } 
        
        //PUT API/projects/1234
        [HttpPut("{id}")]

        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
                return NoContent();
        }
        //Delete api/projects/1234

        [HttpDelete]

        public IActionResult Delete(int id)
        {
                return NoContent();
        }
        
        // PUT api/projects/start/1234
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
                return NoContent();
        }
        
        //Put api/projects/1234/complete
        [HttpPut("{id}/complete")]
        
        public IActionResult Complete(int id)
        {
                return NoContent();
        }
        
        //Post api/projects/1234/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {
                return Ok();
        }

}