using System;

class PrintVisitor : IVisitor {
    public void visit(VideoGame g) {
        Console.WriteLine("Console: " + g.console + " - PEGI: " + g.PEGI);
    }
    public void visit(OutdoorGame g) {
        Console.WriteLine("Ground: " + g.ground+ " - toy: " + g.toy);
    }
    public void visit(BoardGame g) {
        Console.WriteLine("Board: " + g.board + " - nbPieces: " + g.nbPieces);
    }
    public void visit(IVisitable o) {
        Console.WriteLine("Not implemented yet");
    }
}