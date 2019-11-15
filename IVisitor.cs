interface IVisitor {
    void visit(IVisitable o);
    void visit(VideoGame g);
    void visit(OutdoorGame g);
    void visit(BoardGame g);
}