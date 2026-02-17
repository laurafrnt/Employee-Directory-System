using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using API;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        string startDirectory = Directory.GetCurrentDirectory();
        DirectoryInfo directory = new DirectoryInfo(startDirectory);

        while (directory != null && !Directory.Exists(Path.Combine(directory.FullName, "API")))
        {
            directory = directory.Parent;
        }

        if (directory == null)
        {
            throw new Exception("Impossible de localiser le dossier racine du projet (API).");
        }

        string dbPath = Path.Combine(directory.FullName, "API", "annuaire.db");

        Console.WriteLine($"[DEBUG] Final Database path: {dbPath}");

        optionsBuilder.UseSqlite($"Data Source={dbPath}");

        return new AppDbContext(optionsBuilder.Options);
    }
}