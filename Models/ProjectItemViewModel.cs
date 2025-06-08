namespace DevFreela.Models;

public class ProjectItemViewModel
{
    public ProjectItemViewModel(int id, string title, int idClient,
        int idFreelancer, string clienttName, string freelancerName, decimal totalCost)
    {
        Id = id;
        Title = title;
        ClientName = clienttName;
        FreelancerName = freelancerName;
        TotalCost = totalCost;
    }

    public string Title { get; set; }

    public int Id { get; private set; }

    public string ClientName { get; private set; }

    public string FreelancerName { get; private set; }

    public decimal TotalCost { get; private set; }
}