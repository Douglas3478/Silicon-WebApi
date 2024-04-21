using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    public DbSet<SubscribersEntity> Subscribers { get; set; }
    public DbSet<CoursesEntity> Courses { get; set; }
}
