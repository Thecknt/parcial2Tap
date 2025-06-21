
namespace Cristian_Barreto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonajesService service = new PersonajesService();
            int opcion;

            do
            {
                Console.WriteLine("|---------Bienvenido al Comic Store--------|");
                Console.WriteLine("|      Seleccione una opcion del menu      |");
                Console.WriteLine("| 1). Agregar Personaje                    |");
                Console.WriteLine("| 2). Modificar Personaje                  |");
                Console.WriteLine("| 3). Eliminar Personaje                   |");
                Console.WriteLine("| 4). Mostrar Personajes                   |");
                Console.WriteLine("| 5). Calcular Daño Magico                 |");
                Console.WriteLine("| 6). Calcular Defensa                     |");
                Console.WriteLine("| 7). Salir                                |");
                Console.WriteLine("|__________________________________________|");

                opcion = service.OpcionElegida();
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        service.AgregarPersonaje();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        service.ModificarPersonaje();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("|*************************menu de Purga**************************|");
                        string tipoPersonaje;
                        string nombrePersonaje;
                        do
                        {
                            Console.WriteLine("Ingrese el tipo de personaje que desea eliminar: (mago/guerrero)");
                            tipoPersonaje = Console.ReadLine().ToLower();
                            if (tipoPersonaje.ToLower() != "mago" && tipoPersonaje.ToLower() != "guerrero")
                            {
                                Console.WriteLine("El personaje no existe, por favor ingrese un tipo de personaje valido.");
                                Console.WriteLine("Ingrese mago o guerrero");
                                tipoPersonaje = Console.ReadLine().ToLower();
                            }
                        } while (tipoPersonaje == null || tipoPersonaje == "");

                        do
                        {
                            Console.WriteLine("Ingrese el nombre del personaje que desea eliminar:");
                            nombrePersonaje = Console.ReadLine();
                            if (nombrePersonaje == null || nombrePersonaje == "")
                            {
                                Console.WriteLine("El nombre del personaje no puede estar vacío.");
                            }
                            break;
                        } while (nombrePersonaje == null || nombrePersonaje == "");

                        service.EditarOEliminarPersonaje("eliminar", tipoPersonaje, nombrePersonaje, "eliminar");
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Mostrar Personajes");
                        service.mostrarPersonajes();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("****Mostrando Daño Mágico de los Magos****");
                        service.DanioMagico();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("*****Mostrando Defensa de los Guerreros*****");
                        service.defensaGuerrero();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar la aplicacion!\nSaliendo del sistema...");
                        Console.WriteLine("Presione cualquier tecla para salir.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, debe ingresar un numero entre 1 y 7");
                        break;
                }
            } while (opcion != 7);
        }
    }

}
