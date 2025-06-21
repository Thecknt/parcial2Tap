public abstract class Personaje
{
    protected string nombre;
    protected int nivel;

    public Personaje(string nombre, int nivel)
    {
        this.nombre = nombre;
        this.nivel = nivel;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public abstract void Mostrar();
}