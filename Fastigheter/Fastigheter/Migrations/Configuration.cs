namespace Fastigheter.Migrations
{
    using Fastigheter.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Fastigheter.Models.FastigheterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //TM #03 N�r man k�r Enable-Migrations i Package Manager Console skapas mappen Migrations och d�rinne f�rsta migrationen Configuration.cs med EF-funktionen Seed i

        protected override void Seed(Fastigheter.Models.FastigheterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //TM #04 H�r i funktionen Seed kan man - om man vill - ladda sina tabeller med initiella v�rden, m.h.a. EF-funktionen AddOrUpdate.

            context.Fastighets.AddOrUpdate(
                //TM #05 H�r v�ljer vi att attributet Fastighet.Gatuadress ska bli unikt inom alla klassens vyer.
                unik => unik.Gatuadress,

                new Fastighet { Gatuadress = "F�bodv�gen 9", Land = "SE", Postnummer = 14233, Postort = "Skog�s" },
                new Fastighet { Gatuadress = "Tartsay ltp. 48.", Land = "HU", Postnummer = 7100, Postort = "Skog�s" }
                );

            context.Bostads.AddOrUpdate(
                //TM #06 H�r v�ljer vi att det inte ska finnas n�got unikt attribut inom vyer av denna klass.

                new Bostad { FastighetId = 1, Nummer = 1 },
                new Bostad { FastighetId = 1, Nummer = 2 },
                new Bostad { FastighetId = 2, Nummer = 3 },
                new Bostad { FastighetId = 2, Nummer = 4 }
                );

            //TM #07a Efter att seedingsraderna har lagts in f�r alla relevanta klasser/tabeller, ska man spara sin kod och d�refter k�ra kommandona Add-Migration 'valfritt migrationsnamn' och Update-Database i Package Manager Console.
            //TM #07b Har man inga seedingsrader s� r�cker det med Update-Database.
            
            //TM #08a Nu har vi en rudiment�r CRUD-funktionalitet f�r alla v�ra klasser/tabeller (dock: inga tillh�rande menyer) s� det �r dags att synkronisera det lokala repositoryt med github.
            //TM #08b Detta sker genom Changes/Commit All and Sync i Team Explorer vyn av Visual Studio.
        }
    }
}
