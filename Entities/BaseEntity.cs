namespace DevFreela.Entities;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        CreatedAt = DateTime.Now;
        IsDeleted = false;
    }

    public DateTime CreatedAt { get; set; }

    public int Id { get; private set; }

    public DateTime CreateAt { get; private set; }

    public bool IsDeleted { get; private set; }

    public void SetAsDeleted()
    {
        IsDeleted = true;
    }
}