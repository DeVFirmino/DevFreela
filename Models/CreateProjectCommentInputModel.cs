namespace DevFreela.Controllers.Models;

public class CreateProjectCommentInputModel
{
    public string Content { get; set; }
    
    public int IdProject { get; set; }

    public int IdUser { get; set; }
}