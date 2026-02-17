using API;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Faker Databases started...");

        var factory = new DesignTimeDbContextFactory();
        using var context = factory.CreateDbContext(args);

        SeederDbFaker seeder = new SeederDbFaker(context);
        await seeder.SeedDatabaseAsync();

        Console.WriteLine("Done! 1000 employees generated in the database.");
    }
}