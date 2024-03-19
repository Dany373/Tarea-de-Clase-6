
using System;
class Program
{
    // 1. SUMA DE ELEMENTOS PARES DE UN ARREGLO

    public static int sumaElementosPares(int[] arreglo)
    {
        int suma = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] % 2 == 0)
            {

                suma += arreglo[i];
            }
        }
        return suma;
    }

    public static void sumapares(String[] args)
    {
        int[] numeros;
        numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sumaPares = sumaElementosPares(numeros);
        Console.WriteLine("La suma es:" + sumaPares);

    }



    // 2. INVERTIR EL ORDEN DE UN ARREGLO

    public static void invertirArreglo(string[] args)
    {
        int[] numeros2 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] numerosInvertidos = new int[numeros2.Length];

        for (int i = numeros2.Length - 1; i >= 0; i--)
        {
            numerosInvertidos[numeros2.Length - 1 - i] = numeros2[i];
        }
        foreach (int numero in numerosInvertidos)
        {
            Console.WriteLine(numero);
        }
    }


    // 3.  ENCONTRAR EL VALOR MAXIMO EN UN ARREGLO

    public static void maxval(string[] args)
    {
        // Declarar un arreglo de números enteros.
        int[] numeros3 = { 1, 2, 7, 4, 5 };

        // Encontrar el valor máximo en el arreglo.
        int maximo = EncontrarValorMaximo(numeros3);

        // Imprimir el valor máximo.
        Console.WriteLine("El valor máximo es: " + maximo);
    }


    public static int EncontrarValorMaximo(int[] arreglo)
    {
        // Inicializar una variable maximo con el valor del primer elemento del arreglo.
        int maximo = arreglo[0];

        // Recorrer el arreglo utilizando un bucle for desde el segundo elemento hasta el final.
        for (int i = 1; i < arreglo.Length; i++)
        {
            // Si el valor actual del elemento es mayor que maximo, actualiza maximo con el valor actual.
            if (arreglo[i] > maximo)
            {
                maximo = arreglo[i];
            }
        }

        // Devolver el valor de maximo.
        return maximo;
    }





    //4. BUSCAR UN ELEMENTO EN UN ARREGLO

    public static void elemento(string[] args)
    {
        int[] numeros4 = { 1, 2, 3, 4, 5 };

        int posicion = BuscarElemento(numeros4, 4);

        Console.WriteLine("La posición del elemento es: " + posicion);
    }


    public static int BuscarElemento(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
            {
                return i;
            }
        }

        // Si no se encuentra el valor en el arreglo, devolver -1.
        return -1;
    }


    //5. ORDENAR UN ARREGLO DE FORMA ASCENDENTE 

    public static void ordenarArreglo(string[] args)
    {
        int[] numeros5 = { 5, 3, 1, 4, 2 };
        Array.Sort(numeros5);
        foreach (int numero in numeros5)
        {
            Console.WriteLine(numero);
        }
    }





    //UTILIZACION DE METODOS DE ARRAY 
   
    // Ejercicio 1 Ordenar nombres alfabeticamente

   public  static void alfabeticamente(string[] args)
    {
        string[] nombres = new string[] { "Juan", "Pedro", "Dany" };
        Array.Sort(nombres);

        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }

    // Ejercicio 2 Encontrar valor maximo y minimo con Array.Max y Min
    public static void MaxMin(string[] args)
    {
        Console.WriteLine("Escriba la cantidad de números que desea ingresar: ");
        int cantidad = int.Parse(Console.ReadLine());
        int[] numerosEnteros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingrese el número " + (i + 1) + ":");
            numerosEnteros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("_______________________________________________________________");
        int maximo = numerosEnteros.Max();
        Console.WriteLine("El valor máximo es: " + maximo);
        int minimo = numerosEnteros.Min();
        Console.WriteLine("El valor minimo es: " + minimo);
        Console.WriteLine("_______________________________________________________________");
    }



    // Ejercicio 3 Encontrar pais 


    // Declarar un arreglo de nombres de países
    static string[] paises = { "Guatemala", "Argentina", "Brasil", "Chile", "Perú", "Uruguay" };

    // Función para buscar un país en el arreglo
    public static void Paises(string[] args)
    {
        // Solicitar al usuario ingresar un país
        Console.WriteLine("Ingrese el nombre de un país:");
        string paisBuscado = Console.ReadLine();

        // Convertir la entrada del usuario a minúsculas
        paisBuscado = paisBuscado.ToLower();

        // Bandera para indicar si se encontró el país
        bool encontrado = false;

        // Recorrer el arreglo de países utilizando un bucle foreach
        foreach (string pais in paises)
        {
            // Convertir el nombre del país actual a minúsculas
            string paisEnMinusculas = pais.ToLower();

            // Comparar el país actual con el país buscado
            if (paisEnMinusculas.Equals(paisBuscado))
            {
                encontrado = true;
                break; // Salir del bucle si se encuentra el país
            }
        }

        // Mostrar el resultado de la búsqueda
        if (encontrado)
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("El país fue encontrado.");
            Console.WriteLine("_______________________________________________________________");
        }
        else
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("El país no fue encontrado.");
            Console.WriteLine("_______________________________________________________________");
        }
    }

    static void llamar(string[] args)
    {
        // Llamar a la funcion para buscar países
        Paises(args);
    }


    // Ejercicio 4 Invertir orden de los elementos con Array.reverse()

    public static void invertirOrden(string[] args)
    {
        int[] numeros5 = { 1, 2, 3, 4, 5,6, 7, 8 };
        Array.Reverse(numeros5);
        foreach (int numero in numeros5)
        {
            Console.WriteLine(numero);
        }
    }
    // Ejercicio 5 Calificacion sobresaliente con Array.Exists()
    public static void notas()
    {
        int[] calificaciones = { 50, 20, 80, 92, 60 };
        bool sobresaliente = Array.Exists(calificaciones, calif => calif >= 90);

        if (sobresaliente == true)
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Si hay calificaciones sobresalientes ");
            Console.WriteLine("_______________________________________________________________");
        }
        else {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("No hay calificaciones sobresalientes");
            Console.WriteLine("_______________________________________________________________");
        }
    }
 


    // Menu

    static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menú de funciones:");
                Console.WriteLine("1. Suma de elementos pares de un arreglo");
                Console.WriteLine("2. Invertir el orden de un arreglo");
                Console.WriteLine("3. Encontrar el valor máximo en un arreglo");
                Console.WriteLine("4. Buscar un elemento en un arreglo");
                Console.WriteLine("5. Ordenar un arreglo de forma ascendente");
                Console.WriteLine("6. Ordenar nombres alfabeticamente");
                Console.WriteLine("7. Encontrar valor maximo y minimo con Array.Max y Min");
                Console.WriteLine("8. Encontrar pais ");
                Console.WriteLine("9. Invertir orden de los elementos con Array.reverse");
                Console.WriteLine("10. Calificacion sobresaliente con Array.Exists");
                Console.WriteLine("0. Salir del programa");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;

                }
                switch (opcion)
                {
                    case 1:
                        int[] numeros;
                        numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int sumaPares = sumaElementosPares(numeros);
                        Console.WriteLine("La suma es:" + sumaPares);
                        break;
                    case 2:
                        invertirArreglo(args);
                        break;
                    case 3:
                        maxval(args);
                        break;
                    case 4:
                        elemento(args);
                        break;
                    case 5:
                        ordenarArreglo(args);
                        break;
                    case 6:
                        alfabeticamente(args);
                        break;             
                    case 7:
                        MaxMin(args);
                        break;
                    case 8:
                        Paises(args);
                     break;
                    case 9:
                        invertirOrden(args);
                        break;
                    case 10:
                        notas();
                        break;
                    case 0:
                        salir = true;
                        break;
                        default:
                        Console.WriteLine("Opcion no valida");
                        break;  



                }
            }
        }
    }




