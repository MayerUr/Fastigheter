using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fastigheter.Models
{
    public class Bostad
    {
        //TM #01  Man börjar med att skapa sina klasser i mappen Models. Klasserna ska sedan scaffoldas m.h.a. Entity Framework.
        //TM #01a Innan man skaffoldar klassen ska man köra build. En build och en scaffolding per klass.

        //TM #01b Efter att alla klasser har scaffoldats (genom Controllers/Add/Controller och val av Entity Framework) ska man först köra kommandot Enable-Migrations i Package Manager Console.

        //TM #01c Alla klasser/entiteter/tabeller ska ha en (oftast automatiskt genererad) primärnyckel, som kan heta 'Id' eller <klassnamn>Id för att bli igenkänd av EF. Jag väljer Id överallt.
        public int Id { get; set; }

        public int FastighetId { get; set; }
        public int Nummer { get; set; }
    }
}