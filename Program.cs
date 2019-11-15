using System;
using System.Collections.Generic;

namespace GameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nos visiteurs
            PrintVisitor printVisitor = new PrintVisitor();
            
            //Nos jeux
            OutdoorGame chatPerche =  new OutdoorGame("Récré");
            VideoGame marioKart = new VideoGame("Nitendo", 3);
            BoardGame chess = new BoardGame("chest board", 32);

            //Notre liste d'objet visitable
            List<IVisitable> visitableClasses = new List<IVisitable>{chatPerche, marioKart, chess};

            //On visite chacun des objets
            visitableClasses.ForEach(visitableClass => {
                visitableClass.accept(printVisitor);
            });
            
        }
    }
}
