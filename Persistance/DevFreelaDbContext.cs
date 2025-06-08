using DevFreela.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Persistance;

public class DevFreelaDbContext : DbContext
{
    public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options)
        : base(options)
    {
    }

    //Specify DbSets.
    public DbSet<Project> Projects { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Skill> Skills { get; set; }

    public DbSet<UserSkill> UserSkills { get; set; }

    public DbSet<ProjectComment> ProjectComments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Skill>(e => { e.HasKey(s => s.Id); });

        builder.Entity<UserSkill>(e =>
        {
            e.HasKey(us => us.IdUser);
            e.HasOne(u => u.Skill).WithMany(u => u.UserSkills)
                .HasForeignKey(s => s.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);
        });

        base.OnModelCreating(builder);
    }
}