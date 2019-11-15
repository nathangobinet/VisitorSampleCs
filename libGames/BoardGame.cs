class BoardGame : Game, IVisitable {
    public string board {get ;}
    public int nbPieces {get ;}

    public BoardGame(string board, int nbPieces) {
        this.board = board;
        this.nbPieces = nbPieces;
    }
    public void accept(IVisitor visitor) {
        visitor.visit(this);
    }

}