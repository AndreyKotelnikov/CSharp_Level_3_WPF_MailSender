using ORM.Test.Data;

namespace ORM.Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ORM.Test.Data.CodeFirst>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ORM.Test.Data.CodeFirst context)
        {
            if (!context.Songs.Any())
            {
                Song[] songs = new Song[100];
                for (int i = 0; i < 100; i++)
                {
                    songs[i] = new Song
                    {
                        Name = $"Песня {i + 1}",
                        Artist = new Artist { Name = $"Артист {i + 1}" }
                    };
                }
                context.Songs.AddRange(songs);
                context.SaveChanges();
            }
        }
    }
}
