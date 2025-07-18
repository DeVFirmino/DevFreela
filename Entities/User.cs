namespace DevFreela.Entities;

public class User : BaseEntity
{
    public User(string fullName, string email, DateTime birthdate)
    {
        FullName = fullName;
        Email = email;
        Birthdate = birthdate;
        Active = true;

        Skills = [];
        OwnedProjects = [];
        FreelanceProjects = [];
        Comments = [];
    }

    public string FullName { get; private set; }

    public string Email { get; private set; }

    public DateTime Birthdate { get; private set; }

    public bool Active { get; private set; }

    public List<UserSkill> Skills { get; private set; }

    public List<Project> OwnedProjects { get; private set; }

    public List<Project> FreelanceProjects { get; private set; }

    public List<ProjectComment> Comments { get; private set; }
}