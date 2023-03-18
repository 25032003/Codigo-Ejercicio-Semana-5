namespace Funciones
{
    class Funciones
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Funciones en C#\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Menú de opciones
            Console.WriteLine("Ingrese la opción que desea realizar\n");
            Console.WriteLine("1. Calcular el área de un círculo\n" +
                "2. Calcular el perímetro de un rectángulo\n" +
                "3. Calcular el promedio de una lista de enteros\n" +
                "4. Determinar par o impar\n" +
                "5. Convertir a mayúsculas\n" +
                "6. Calcular la distancia entre dos puntos en el plano cartesiano\n" +
                "7. Calcular la suma de los primeros n números naturales\n" +
                "8. Calcular el factorial de un número\n" +
                "0. Salir\n");
            int opcion = int.Parse(Console.ReadLine());

            // Switch que incluye las operaciones y llama a las funciones
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese el radio del círculo");
                    double radio = Double.Parse(Console.ReadLine());
                    double area = AreaCirculo(radio);
                    Console.WriteLine("\nEl área del círculo es: " + Math.Round(area, 2));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese el lado B (base)");
                    double B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el lado H (altura)");
                    double H = double.Parse(Console.ReadLine());
                    double perimetro = PerimetroRectangulo(B, H);
                    Console.WriteLine("\nEl perímetro del rectángulo es: " + Math.Round(perimetro, 2));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese los números enteros de la lista (utilice fin para terminar)\n");
                    List<int> lista = new List<int>();
                    string valor;
                    while ((valor = Console.ReadLine()) != "fin")
                    {
                        int num;
                        if (int.TryParse(valor, out num))
                        {
                            lista.Add(num);
                        }
                        else
                        {
                            Console.WriteLine("El número ingresado no es un entero");
                        }
                    }
                    double promedio = ListaEnteros(lista.Average());
                    Console.WriteLine("\nEl promedio de la lista es: " + Math.Round(promedio, 2));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Ingrese el numero");
                    string numero = Console.ReadLine();
                    int numEntero;
                    if (int.TryParse(numero, out numEntero))
                    {
                        if (VerSiEsPar(numEntero))
                        {
                            Console.WriteLine("El número es par: " + numEntero);
                        }
                        else
                        {
                            Console.WriteLine("El número es impar: " + numEntero);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es un entero");
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Ingrese su cadena de texto");
                    string cadena = Console.ReadLine();
                    string cadenaMayuscula = ConvertirMayusculas(cadena);
                    Console.WriteLine("Su cadena convertida a mayúsculas es:\n\n" +
                        cadenaMayuscula);
                    break;
                case 6:
                    Console.Clear();
                    int xA;
                    int yA;
                    int xB;
                    int yB;
                    Console.WriteLine("Ingrese el punto X1");
                    xA = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el punto X2");
                    xB = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el punto Y1");
                    yA = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el punto Y2");
                    yB = int.Parse(Console.ReadLine());
                    double distancia = CalcularDistanciaEntrePuntos(xA, yA, xB, yB);
                    Console.WriteLine("La distancia entre los puntos " + (xA, yA) + " y " + (xB, yB) + " es: " + Math.Round(distancia, 2));
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Ingrese el número natural que desea calcular");
                    int n = int.Parse(Console.ReadLine());
                    int suma = CalcularSumaN(n);
                    Console.WriteLine("La suma de los primeros " + n + " números naturales es: " + suma);
                    break;
                case 8:
                    Console.Clear();
                    Console.Write("Introduce un número entero positivo: ");
                    int numFactorial = int.Parse(Console.ReadLine());
                    int factorial = CalcularFactorial(numFactorial);
                    Console.WriteLine("El factorial de " + numFactorial + " es: " + factorial);
                    break;
                case 0:
                    Console.WriteLine("Cerraste el programa, hasta la vista baby");
                    Environment.Exit(0);
                    break;
            }
        }

        // Funciones 
        public static double AreaCirculo(double radio)
        {
            double area = Math.PI * (radio * radio);
            return area;
        }
        public static double PerimetroRectangulo(double B, double H)
        {
            double perimetro = 2 * (B + H);
            return perimetro;
        }
        public static double ListaEnteros(double promedio)
        {
            return promedio;
        }
        public static bool VerSiEsPar(int numero)
        {
            return numero % 2 == 0;
        }
        public static string ConvertirMayusculas(string texto)
        {
            return texto.ToUpper();
        }
        public static double CalcularDistanciaEntrePuntos(int x1, int y1, int x2, int y2)
        {
            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distancia;
        }
        public static int CalcularSumaN(int n)
        {
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            return suma;
        }
        public static int CalcularFactorial(int numeroFactorial)
        {
            int factorial = 1;

            for (int i = 1; i <= numeroFactorial; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}