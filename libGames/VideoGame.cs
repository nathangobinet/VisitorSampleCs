class VideoGame : Game, IVisitable {
    public string console { get ;}
    public int PEGI { get ;}

    public VideoGame(string console, int PEGI) {
        this.console = console;
        this.PEGI = PEGI;
    }
     public void accept(IVisitor visitor) {
        visitor.visit(this);
    }
}