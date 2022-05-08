using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter
    {
        public void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}

/*
Para no incumplir SRP, elimino la clase AllInOnePrinter, ya que tiene mas de una responsabilidad, por lo
tanto creo las clases PrintConsola y PrintFile, siendo la superclase IPrinter.
*/