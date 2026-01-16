using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace movie_mvc.Data;

public class MovieDbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
{
    public MovieDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=Movie_DB;Integrated Security=true;TrustServerCertificate=true"
        );

        return new MovieDbContext(optionsBuilder.Options);
    }
}
