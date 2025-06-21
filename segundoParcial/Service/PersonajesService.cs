public class PersonajesService
{
    List<Personaje> personajes = new List<Personaje>();

    public PersonajesService()
    {
        Mago mago1 = new Mago("Gandalf", 10, 150);
        personajes.Add(mago1);
        Mago mago2 = new Mago("Merlin", 12, 200);
        personajes.Add(mago2);

        Guerrero guerrero1 = new Guerrero("Conan", 15, 300, 50.5);
        personajes.Add(guerrero1);
        Guerrero guerrero2 = new Guerrero("Aquiles", 18, 350, 60.0);
        personajes.Add(guerrero2);
    }

    public int OpcionElegida()
    {
        Boolean result = false;
        int opcionElegida = 0;
        do
        {
            result = int.TryParse(Console.ReadLine(), out opcionElegida);
            if (result == false)
            {
                Console.WriteLine("Verifique los datos ingresados.\nDebe ser una opcion valida del menu mostrado en pantalla.");
                Console.WriteLine("Reintente nuevamente");

            }

        } while (!result);

        return opcionElegida;
    }

    public void AgregarPersonaje()
    {
        int opcionAgregar;
        string nombre;
        int nivelGuerrero;
        int fuerzaGuerrero;
        double resistenciaGuerrero;
        do
        {
            Console.WriteLine("|******************************************|");
            Console.WriteLine("| Agregar Personaje - Seleccione una opcion|");
            Console.WriteLine("|1) Agregar Mago                           |");
            Console.WriteLine("|2) Agregar Guerrero                       |");
            Console.WriteLine("|3) Salir                                  |");
            Console.WriteLine("|__________________________________________|");

            opcionAgregar = OpcionElegida();

            switch (opcionAgregar)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Ingrese el nombre del Mago:");
                        nombre = Console.ReadLine();
                    } while (nombre == "");

                    Console.WriteLine("Ingrese el nivel del personaje:");
                    int nivel = validarNumeroInt();

                    if (nivel <= 0)
                    {
                        Console.WriteLine("El nivel del Mago no puede ser menor a 0.");
                        nivel = validarNumeroInt();
                    }

                    Console.WriteLine("Ingrese el poder mágico del Mago:");
                    int poderMagico = validarNumeroInt();

                    if (poderMagico <= 0)
                    {
                        Console.WriteLine("El poder mágico del Mago no puede ser menor a 0.");
                        poderMagico = validarNumeroInt();
                    }

                    Mago nuevoMago = new Mago(nombre, nivel, poderMagico);
                    personajes.Add(nuevoMago);

                    Console.WriteLine($"El Mago {nombre}, ha sido agregado exitosamente.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("Ingrese el nombre del Guerrero:");
                        nombre = Console.ReadLine();
                    } while (nombre == "");

                    Console.WriteLine("Ingrese el nivel del Guerrero:");
                    nivelGuerrero = validarNumeroInt();
                    if (nivelGuerrero <= 0)
                    {
                        Console.WriteLine("El nivel del Guerrero no puede ser menor a 0.");
                        nivelGuerrero = validarNumeroInt();
                    }

                    Console.WriteLine("Ingrese la fuerza del Guerrero:");
                    fuerzaGuerrero = validarNumeroInt();
                    if (fuerzaGuerrero <= 0)
                    {
                        Console.WriteLine("La fuerza del Guerrero no puede ser menor a 0.");
                        fuerzaGuerrero = validarNumeroInt();
                    }

                    Console.WriteLine("Ingrese la resistencia del Guerrero:");
                    resistenciaGuerrero = validarNumeroDouble();

                    if (resistenciaGuerrero <= 0)
                    {
                        Console.WriteLine("La resistencia del Guerrero no puede ser menor a 0.");
                        resistenciaGuerrero = validarNumeroDouble();
                    }

                    Guerrero nuevoGuerrero = new Guerrero(nombre, nivelGuerrero, fuerzaGuerrero, resistenciaGuerrero);
                    personajes.Add(nuevoGuerrero);

                    Console.WriteLine($"El Guerrero {nombre} ha sido agregado exitosamente.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Saliendo de la adición de personajes.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (opcionAgregar != 3);

    }



    public void ModificarPersonaje()
    {
        int opcionModificar;
        do
        {
            Console.WriteLine("|*********************************************|");
            Console.WriteLine("| Modificar Personaje - Seleccione una opcion |");
            Console.WriteLine("| 1) Modificar Mago                           |");
            Console.WriteLine("| 2) Modificar Guerrero                       |");
            Console.WriteLine("| 3) Salir                                    |");
            Console.WriteLine("|_____________________________________________|");

            opcionModificar = OpcionElegida();

            switch (opcionModificar)
            {
                case 1:
                    Console.Clear();
                    int opcionMago;
                    do
                    {
                        Console.WriteLine("|*****************************************|");
                        Console.WriteLine("|  Ingrese la opcion que desea modificar  |");
                        Console.WriteLine("| 1) Modificar Nombre                     |");
                        Console.WriteLine("| 2) Modificar Nivel                      |");
                        Console.WriteLine("| 3) Modificar Poder Mágico               |");
                        Console.WriteLine("| 4) Salir                                |");
                        Console.WriteLine("|_________________________________________|");
                        opcionMago = OpcionElegida();
                        switch (opcionMago)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Modificar Nombre del Mago");
                                string nombre = buscarNombre();
                                EditarOEliminarPersonaje("editar", "mago", nombre, "modificarNombre");

                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Modificar Nivel del Mago");
                                int nivelMago;
                                string nombreMago = buscarNombre();
                                EditarOEliminarPersonaje("editar", "mago", nombreMago, "modificarNivel");

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Modificar Poder Mágico del Mago");
                                string nombreMagoPoder = buscarNombre();
                                EditarOEliminarPersonaje("editar", "mago", nombreMagoPoder, "modificarPoderMagico");

                                break;
                            case 4:
                                Console.WriteLine("Saliendo de la modificación del Mago.");
                                Console.WriteLine("Presione cualquier tecla para continuar.");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente nuevamente.");
                                Console.WriteLine("Presione cualquier tecla para continuar.");
                                Console.ReadKey();
                                break;
                        }
                    } while (opcionMago != 4);
                    break;
                case 2:
                    Console.Clear();
                    int opcionGuerrero;
                    do
                    {
                        Console.WriteLine("|*****************************************|");
                        Console.WriteLine("|  Ingrese la opcion que desea modificar  |");
                        Console.WriteLine("| 1) Modificar Nombre                     |");
                        Console.WriteLine("| 2) Modificar Nivel                      |");
                        Console.WriteLine("| 3) Modificar Fuerza                     |");
                        Console.WriteLine("| 4) Modificar Resistencia                |");
                        Console.WriteLine("| 5) Salir                                |");
                        Console.WriteLine("|_________________________________________|");
                        opcionGuerrero = OpcionElegida();

                        switch (opcionGuerrero)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Modificar Nombre del Guerrero");
                                string nombre = buscarNombre();
                                EditarOEliminarPersonaje("editar", "guerrero", nombre, "modificarNombre");
                                break;
                            case 2:
                                Console.Clear();
                                string nombreGuerrero = buscarNombre();
                                EditarOEliminarPersonaje("editar", "guerrero", nombreGuerrero, "modificarNivel");

                                break;
                            case 3:
                                Console.Clear();
                                string nombreGuerrero1 = buscarNombre();
                                EditarOEliminarPersonaje("editar", "guerrero", nombreGuerrero1, "modificarFuerza");

                                break;
                            case 4:
                                Console.Clear();
                                string nombreGuerrero2 = buscarNombre();
                                EditarOEliminarPersonaje("editar", "guerrero", nombreGuerrero2, "modificarResistencia");
                                // Lógica para modificar la resistencia del Guerrero
                                break;
                            case 5:
                                Console.WriteLine("Saliendo de la modificación del Guerrero.");
                                Console.WriteLine("Presione cualquier tecla para continuar.");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente nuevamente.");
                                Console.WriteLine("Presione cualquier tecla para continuar.");
                                Console.ReadKey();
                                break;
                        }
                    } while (opcionGuerrero != 5);
                    break;
                case 3:
                    Console.WriteLine("Saliendo de la modificación de personajes.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        } while (opcionModificar != 3);

    }

    public void mostrarPersonajes()
    {
        foreach (Personaje personaje in personajes)
        {
            personaje.Mostrar();
            Console.WriteLine("-----------------------------------");
        }
        Console.WriteLine("Presione cualquier tecla para continuar.");
        Console.ReadKey();
        Console.Clear();
    }

    public string buscarNombre()
    {
        string buscarNombre;
        do
        {
            Console.WriteLine("Ingrese el nombre del personaje a buscar:");
            buscarNombre = Console.ReadLine();
            if (buscarNombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                break;
            }
        } while (buscarNombre == "");
        return buscarNombre;
    }

    public int validarNumeroInt()
    {
        int numero;
        bool isValid = false;
        do
        {
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out numero);
            if (!isValid)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        } while (!isValid);
        return numero;
    }

    public double validarNumeroDouble()
    {
        double numero;
        bool isValid = false;
        do
        {
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out numero);
            if (!isValid)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
            }
        } while (!isValid);
        return numero;
    }

    public void EditarOEliminarPersonaje(string accion, string tipoDePersonaje, string nombrePersonaje, string tipoModificacion)
    {
        switch (accion)
        {
            case "editar":
                switch (tipoDePersonaje)
                {
                    case "mago":
                        switch (tipoModificacion)
                        {
                            case "modificarNombre":
                                string nombre;
                                foreach (Personaje m in personajes)
                                {
                                    nombre = nombrePersonaje.ToLower();
                                    if (nombre.Equals(m.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Mago encontrado:");
                                        m.Mostrar();
                                        Console.WriteLine("Ingrese el nuevo nombre del Mago:");
                                        string nuevoNombre = Console.ReadLine();
                                        if (nuevoNombre != "")
                                        {
                                            m.Nombre = nuevoNombre;
                                            Console.WriteLine($"El nombre del Mago ha sido modificado a {nuevoNombre}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El nombre no puede estar vacío.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            case "modificarNivel":
                                string nombreMago;
                                int nivelMago;
                                foreach (Personaje m in personajes)
                                {
                                    nombreMago = nombrePersonaje.ToLower();
                                    if (nombreMago.Equals(m.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Mago encontrado:");
                                        m.Mostrar();
                                        Console.WriteLine("Ingrese el nuevo nivel del Mago:");
                                        nivelMago = validarNumeroInt();

                                        if (nivelMago > 0)
                                        {
                                            m.Nivel = nivelMago;
                                            Console.WriteLine($"El nivel del Mago {nombreMago} ha sido modificado a {nivelMago}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El nivel no puede ser menor o igual a 0.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            case "modificarPoderMagico":
                                string nombreMagoPoder = nombrePersonaje;
                                Console.WriteLine($"Ingrese el poder Magico de {nombreMagoPoder}");
                                int poderMagicoMago = validarNumeroInt();
                                
                                foreach (Personaje m in personajes)
                                {
                                    nombreMagoPoder = nombrePersonaje.ToLower();
                                    if (nombreMagoPoder.Equals(m.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Mago encontrado!");
                                        if (poderMagicoMago > 0)
                                        {
                                            ((Mago)m).PoderMagico = poderMagicoMago;
                                            Console.WriteLine($"El poder mágico del Mago {nombreMagoPoder} ha sido modificado a {poderMagicoMago}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El poder mágico no puede ser menor o igual a 0.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                        }
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("Tipo de modificación no válido.");
                                break;
                        }
                        break;

                    case "guerrero":
                        switch (tipoModificacion)
                        {
                            case "modificarNombre":
                                Console.Clear();
                                string nombre;
                                foreach (Personaje g in personajes)
                                {
                                    nombre = nombrePersonaje.ToLower();
                                    if (nombre.Equals(g.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Guerrero encontrado!");
                                        g.Mostrar();
                                        Console.WriteLine("Ingrese el nuevo nombre del Guerrero:");
                                        string nuevoNombre = Console.ReadLine();
                                        if (nuevoNombre != "")
                                        {
                                            g.Nombre = nuevoNombre;
                                            Console.WriteLine($"El nombre del Guerrero ha sido modificado a {nuevoNombre}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El nombre no puede estar vacío.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            case "modificarNivel":
                                Console.Clear();
                                int nivelGuerrero = validarNumeroInt();
                                string nombreGuerrero;
                                foreach (Personaje g in personajes)
                                {
                                    nombreGuerrero = nombrePersonaje.ToLower();
                                    if (nombreGuerrero.Equals(g.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Guerrero encontrado:");
                                        g.Mostrar();
                                        Console.WriteLine("Ingrese el nuevo nivel del Guerrero:");
                                        nivelGuerrero = validarNumeroInt();

                                        if (nivelGuerrero > 0)
                                        {
                                            g.Nivel = nivelGuerrero;
                                            Console.WriteLine($"El nivel del Guerrero {nombreGuerrero} ha sido modificado a {nivelGuerrero}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El nivel no puede ser menor o igual a 0.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            case "modificarFuerza":
                                Console.Clear();
                                int fuerzaGuerrero = validarNumeroInt();
                                string nombreGuerrero1;
                                foreach (Guerrero g in personajes)
                                {
                                    nombreGuerrero1 = nombrePersonaje.ToLower();
                                    if (nombreGuerrero1.Equals(g.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Guerrero encontrado:");
                                        g.Mostrar();
                                        Console.WriteLine("Ingrese el nuevo nivel del Guerrero:");
                                        fuerzaGuerrero = validarNumeroInt();

                                        if (fuerzaGuerrero > 0)
                                        {
                                            g.Fuerza = fuerzaGuerrero;
                                            Console.WriteLine($"El nivel del Guerrero {nombreGuerrero1} ha sido modificado a {fuerzaGuerrero}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("El nivel no puede ser menor o igual a 0.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            case "modificarResistencia":
                                Console.Clear();
                                double resistenciaGuerrero = validarNumeroDouble();
                                string nombreGuerrero2;
                                foreach (Guerrero g in personajes)
                                {
                                    nombreGuerrero2 = nombrePersonaje.ToLower();
                                    if (nombreGuerrero2.Equals(g.Nombre.ToLower()))
                                    {
                                        Console.WriteLine("Guerrero encontrado:");
                                        g.Mostrar();
                                        if (resistenciaGuerrero > 0)
                                        {
                                            g.Resistencia = resistenciaGuerrero;
                                            Console.WriteLine($"La resistencia del Guerrero {nombreGuerrero2} ha sido modificada a {resistenciaGuerrero}.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("La resistencia no puede ser menor o igual a 0.");
                                            Console.WriteLine("Presione cualquier tecla para continuar.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("Tipo de modificación no válido.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Eleccion incorrecta. Por favor, elija mago o guerrero");
                        break;
                }
                break;

            case "eliminar":
                
                switch (tipoDePersonaje)
                {
                    case "mago":

                        string nombreMago;
                        int nivelMago;
                        int indexMago = -1;
                        foreach (Personaje m in personajes)
                        {
                            nombreMago = nombrePersonaje.ToLower();
                            if (nombreMago.Equals(m.Nombre.ToLower()))
                            {
                                Console.WriteLine("Mago encontrado:");
                                m.Mostrar();
                                indexMago = personajes.IndexOf(m);
                            }
                        }
                        if (indexMago == -1)
                        {
                            Console.WriteLine($"No se encontró un Mago con el nombre {nombrePersonaje}.");
                            Console.WriteLine("Presione cualquier tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            personajes.RemoveAt(indexMago);
                            Console.WriteLine($"El Mago {nombrePersonaje} ha sido eliminado exitosamente.");
                            Console.WriteLine("Presione cualquier tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case "guerrero":
                        string nombreGuerrero;
                        int indexGuerrero = -1;
                        foreach (Personaje g in personajes)
                        {
                            nombreGuerrero = nombrePersonaje.ToLower();
                            if (nombreGuerrero.Equals(g.Nombre.ToLower()))
                            {
                                Console.WriteLine("Guerrero encontrado!");
                                g.Mostrar();
                                indexGuerrero = personajes.IndexOf(g);
                            }
                        }

                        if (indexGuerrero == -1)
                        {
                            Console.WriteLine($"No se encontró un Guerrero con el nombre {nombrePersonaje}.");
                            Console.WriteLine("Presione cualquier tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            personajes.RemoveAt(indexGuerrero);
                            Console.WriteLine($"El Guerrero {nombrePersonaje} ha sido eliminado exitosamente.");
                            Console.WriteLine("Presione cualquier tecla para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    default:
                        break;
                }
                break;

            default:
                Console.WriteLine("Acción incorrecta. Por favor, elija editar o eliminar");
                break;
        }
    }

    public float DanioMagico()
    {

        float danio = 0;
        string nombreMago;
        foreach (Personaje m in personajes)
        {
            if (m is Mago mago)
            {
                danio = mago.CalcularDanioMagico();
                nombreMago = m.Nombre;
                Console.WriteLine($">>>> El daño magico de *{nombreMago}* es de {danio} puntos");
            }
        }
        return danio;
    }

    public double defensaGuerrero()
    {
        double defensa = 0;
        string nombreGuerrero;
        foreach (Personaje g in personajes)
        {
            if (g is Guerrero guerrero)
            {
                defensa = guerrero.CalcularDefensa();
                nombreGuerrero = guerrero.Nombre;
                Console.WriteLine($">>>> La defensa del Guerrero {nombreGuerrero} es de |_<>_| {defensa:F2}");
            }
        }
        return defensa;
    }

}   

