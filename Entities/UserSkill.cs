namespace DevFreela.Entities;

public class UserSkill
{
    public UserSkill(int idUser, int idSkill)
    {
        IdUser = idUser;
        IdSkill = idSkill;
    }

    public int IdUser { get; private set; }

    public User User { get; private set; }
    public int IdSkill { get; private set; }

    public Skill Skill { get; private set; }
}