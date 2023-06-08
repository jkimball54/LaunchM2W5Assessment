using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment
{
    public class DataSeeder
    {
        public static void SeedConcertsAndPerformers(ConcertContext context)
        {
            if(!context.Concerts.Any() && !context.Performers.Any())
            {
                var concert1 = new Concert() { Id = 1, Name = "Concert 1", ShowDate = DateTime.Now.ToUniversalTime()};
                var concert2 = new Concert() { Id = 2, Name = "Concert 2", ShowDate = DateTime.Now.ToUniversalTime()};
                var performer1 = new Performer() { Id = 1, Name = "Performer 1", Age = 25};
                var performer2 = new Performer() { Id = 2, Name = "Performer 2", Age = 26};
                concert1.Performers = new List<Performer>() { performer1, performer2 };
                concert2.Performers = new List<Performer>() { performer2 };
                performer1.Concerts = new List<Concert>() { concert1 };
                performer2.Concerts = new List<Concert>() { concert1, concert2 };
                context.Concerts.AddRange(new List<Concert>() { concert1, concert2 });
                context.Performers.AddRange(new List<Performer>() { performer1, performer2});
                context.SaveChanges();

            }
        }
    }
}
