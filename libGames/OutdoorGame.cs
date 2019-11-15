class OutdoorGame : Game, IVisitable {
    public string ground {get ;}
    public string toy {get ;}
    public OutdoorGame(string ground) {
        this.ground = ground;
    }
    public OutdoorGame(string ground, string toy) {
        this.ground = ground;
        this.toy = toy;
    }
    public void accept(IVisitor visitor) {
        visitor.visit(this);
    }
}