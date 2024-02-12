using EntityPractice.Entities;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;


using (var db = new ActorDbContext()) 
{
    //Seed
    db.Actors.AddRange(new Actor { Name = "Erik Hedman", Age = 24, AcademyWinner = true }, new Actor { Name = "Ben Hedman", Age = 26, AcademyWinner = true });

    var count = db.SaveChanges();

    //FetchData

    Console.WriteLine($"{count} records added");

    foreach (var Actor in db.Actors)
    {
        Console.WriteLine($"Name - {Actor.Name} \t\t" + $"Age: {Actor.Age}, \t\t" + $"Academy Winner: {Actor.AcademyWinner}");
    }

    Console.ReadLine();
}
