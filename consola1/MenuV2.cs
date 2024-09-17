using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consola1
{
    public class MenuV2
    {
        public static void Limpiar()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\npresione enter para continuar\r\n");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        static void Main()
        {

            int NumSelect = -1;
            bool validar = false;

            do
            {
                do
                {
                    Console.WriteLine("Bienvenida Profe Judith. \r\n Seleccione una opción: \r\n 1-Ejercicio SortedList \r\n 2-Ejercicio Dictionary \r\n 3-Ejercicio SortedSet \r\n 0-Salir");

                    string ValorAParcear = Console.ReadLine();
                    int numero;
                    validar = int.TryParse(ValorAParcear, out numero);

                    if (validar == true)
                    {
                        NumSelect = numero;
                        Console.Clear();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor ingresado no válido. Por favor, ingrese un número del 0 al 3.");
                        Limpiar();
                    }
                } while (!validar);

                switch (NumSelect)
                {
                    case 1:
                        Console.WriteLine("Ingrese una frase en ingles para traducir al español.\r\n Las palabras que se encuentren en el diccionario serán traducidas");

                        SortedList<string, string> LlavePalabra = new SortedList<string, string>()
                        {
                                { "hello", "hola" },
                                { "Hello", "Hola" },
                                { "cat", "gato" },
                                { "dog", "perro" },
                                { "red", "rojo" },
                                { "apple", "manzana" },
                                { "yellow", "yellow" },
                                { "father", "padre" },
                                { "hi", "Hola" },
                                { "tree", "arbol" },
                                { "have", "tengo" },
                                { "i", "yo" },
                                { "My", "Mi" },
                                { "my", "mi" }
                        };

                        string FraseATraducir = Console.ReadLine();
                        string[] subcadenas = FraseATraducir.Split(new char[] { ' ', ',', '?', '¿', '!', '¡', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        // ▲ el codigo de arriba lo que hace es separar en cadenas individuales los strings separados por espacios, comas, u otros signos.
                        // RemoveEmptyEntries

                        Console.WriteLine("\r\nSe encontraron las siguientes traducciones de palabras");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (string palabra in subcadenas)
                        {
                            if (LlavePalabra.ContainsKey(palabra))
                            {
                                Console.Write(LlavePalabra[palabra] + "\r\n");
                            }
                        }

                        Limpiar();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese una frase en ingles para traducir al español.\r\n Las palabras que se encuentren en el diccionario serán traducidas");

                        Dictionary<string, string> LlavePalabraDiccio = new Dictionary<string, string>()
                        {
                                    { "hello", "hola" },
                                    { "Hello", "Hola" },
                                    { "cat", "gato" },
                                    { "dog", "perro" },
                                    { "red", "rojo" },
                                    { "apple", "manzana" },
                                    { "yellow", "yellow" },
                                    { "father", "padre" },
                                    { "hi", "Hola" },
                                    { "tree", "arbol" },
                                    { "have", "tengo" },
                                    { "i", "yo" },
                                    { "My", "Mi" },
                                    { "my", "mi" }
                        };

                        string FraseATraducirDiccio = Console.ReadLine();
                        string[] subcadenasDiccio = FraseATraducirDiccio.Split(new char[] { ' ', ',', '?', '¿', '!', '¡', '.' }, StringSplitOptions.RemoveEmptyEntries);

                        Console.WriteLine("\r\nSe encontraron las siguientes traducciones de palabras");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (string palabraDiccio in subcadenasDiccio)
                        {
                            if (LlavePalabraDiccio.ContainsKey(palabraDiccio))
                            {
                                Console.Write(LlavePalabraDiccio[palabraDiccio] + "\r\n");
                            }
                        }
                        Limpiar();
                        break;

                    case 3:

                        int x = -1;
                        SortedSet<string> sortedSet = new SortedSet<string>();
                        do
                        {
                            Console.WriteLine("Ingrese palabras o frases que desee almacenar");

                            string StringAGuardar = Console.ReadLine();
                            string[] Subchains = StringAGuardar.Split(new char[] { ' ', ',', '?', '¿', '!', '¡', '.' }, StringSplitOptions.RemoveEmptyEntries);

                            if (string.IsNullOrEmpty(StringAGuardar))
                            {
                                Console.ResetColor();
                                // Mostrar todas las cadenas en el SortedSet
                                Console.WriteLine("Cadenas en la lista:\r\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                foreach (string cadena in sortedSet)
                                {
                                    Console.WriteLine(cadena);
                                }
                                x = 0;
                                Console.ResetColor();
                            }
                            else
                            {
                                foreach (string cadena in Subchains)
                                {
                                    if (!sortedSet.Contains(cadena))
                                    {
                                        sortedSet.Add(cadena);
                                    }
                                    else
                                    {
                                        Console.Write("La palabra ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write($"{cadena} ");
                                        Console.ResetColor();
                                        Console.WriteLine("ya se encuentra añadida a la lista.");
                                    }
                                }
                            }
                            Console.ResetColor();
                        } while (x != 0);

                        Limpiar();
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("El número seleccionado no es válido.");
                        Limpiar();
                        break;
                }

            } while (NumSelect != 0);
        }
    }
}
