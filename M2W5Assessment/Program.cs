// See https://aka.ms/new-console-template for more information
using M2W5Assessment;

Console.WriteLine("Hello, World!");
using(var context = new ConcertContext())
{
    DataSeeder.SeedConcertsAndPerformers(context);
}