class Mago : Personaje
{
    protected int poderMagico;
    public Mago(string nombre, int nivel, int poderMagico) : base(nombre, nivel)
    {
        this.poderMagico = poderMagico;
    }

    public int PoderMagico
    {
        get { return poderMagico; }
        set { poderMagico = value; }
    }

    public float CalcularDanioMagico()
    {
        return PoderMagico * Nivel * 0.8f;
    }

    public override void Mostrar()
    {
        Console.WriteLine($"Mago: {Nombre}\nNivel: {Nivel}\nPoder Mágico: *{PoderMagico}");
    }

}