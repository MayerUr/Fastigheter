using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fastigheter.Models
{
    public class Fastighet
    {
        //TM #02  Man börjar med att skapa sina klasser i mappen Models. Klasserna ska sedan scaffoldas m.h.a. Entity Framework.
        //TM #02a Innan man skaffoldar klassen ska man köra build. En build och en scaffolding per klass.

        //TM #02b Efter att alla klasser har scaffoldats (genom Controllers/Add/Controller och val av Entity Framework) ska man först köra kommandot Enable-Migrations i Package Manager Console.

        //TM #02c Alla klasser/entiteter/tabeller ska ha en (oftast automatiskt genererad) primärnyckel, som kan heta 'Id' eller <klassnamn>Id för att bli igenkänd av EF. Jag väljer Id överallt.
        public int Id { get; set; }

        public string Land { get; set; }
        public string Gatuadress { get; set; }
        public int Postnummer { get; set; }
        public string Postort { get; set; }
    }
}