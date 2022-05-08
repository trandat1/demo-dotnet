using Microsoft.EntityFrameworkCore;

public class MyDbContext: DbContext
{
    protected readonly IConfiguration Configuration;
    public MyDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string connectionString = Configuration.GetConnectionString("DemoConnectionString");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<Student> Students {get;set;}
    public DbSet<Product> Products {get;set;}
}