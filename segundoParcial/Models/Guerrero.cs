class Guerrero : Personaje
{

    protected int fuerza;

    protected double resistencia;
    
    public Guerrero(string nombre, int nivel, int fuerza, double resistencia) : base(nombre, nivel)
    {
        this.fuerza = fuerza;
        this.resistencia = resistencia;
    }

    public int Fuerza
    {
        get { return fuerza; }
        set { fuerza = value; }
    }

    public double Resistencia
    {
        get { return resistencia; }
        set { resistencia = value; }
    }

    public override void Mostrar()
    {
        Console.WriteLine($"Guerrero: {Nombre}\nNivel: {Nivel}\nFuerza: {Fuerza}\nResistencia: {Resistencia}");
    }

    public double CalcularDefensa()
    {
        return Resistencia * Fuerza / Nivel;
    }
}