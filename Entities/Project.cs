using DevFreela.Enums;

namespace DevFreela.Entities;

public class Project : BaseEntity
{
    protected Project()
    {
    }

    public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)

    {
        Title = title;
        Description = description;
        IdClient = idClient;
        IdFreelancer = idFreelancer;
        TotalCost = totalCost;

        Status = ProjectStatusEnumerable.Created;
        Comments = [];
    }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public int IdClient { get; private set; }

    public User Client { get; private set; }

    public int IdFreelancer { get; private set; }

    public User Freelancer { get; private set; }

    public decimal TotalCost { get; private set; }

    public DateTime? StartedAt { get; private set; }

    public DateTime? CompletedAt { get; private set; }

    public ProjectStatusEnumerable Status { get; private set; }

    public List<ProjectComment> Comments { get; private set; }

    public void Cancel()
    {
        if (Status == ProjectStatusEnumerable.InProgress || Status == ProjectStatusEnumerable.Suspended)
            Status = ProjectStatusEnumerable.Cancelled;
    }

    public void Start()
    {
        if (Status == ProjectStatusEnumerable.Created)
        {
            Status = ProjectStatusEnumerable.InProgress;
            StartedAt = DateTime.Now;
        }
    }


    public void Complete()
    {
        if (Status == ProjectStatusEnumerable.PaymentPending || Status == ProjectStatusEnumerable.InProgress)
        {
            Status = ProjectStatusEnumerable.Completed;
            CompletedAt = DateTime.Now;
        }
    }

    public void SetPaymentPending()
    {
        if (Status == ProjectStatusEnumerable.InProgress) Status = ProjectStatusEnumerable.PaymentPending;
    }

    public void Update(string title, string description, decimal totalCost)
    {
        Title = title;
        Description = description;
        TotalCost = totalCost;
    }
}