using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA_VG
{
    internal class menus
    {
        public static void MenuPrincipal()
        {

            Console.WriteLine("Bienvenidos al menu");
            Console.WriteLine("  ");
            Console.WriteLine("Tiene  las siguientes opciones\n" +
                              "\n1. Operadores" +
                              "\n2. Condicionales" +
                              "\n3. Ciclos" +
                              "\n4. Arreglos" +
                              "\n5. Salir");
            Console.WriteLine("  ");

            Console.WriteLine("Seleccione la opcion que desee: ");
        }
        public static void MenuOperadores()
        {
            Console.WriteLine("Opcion Operadores,");
            Console.WriteLine("\n1. Area de un triangulo.");
            Console.WriteLine("\n2. Suma de dos numeros.");
            Console.WriteLine("\n3. Un numero elvado al cuadrado.");
            Console.WriteLine("\n4. Conversor de euros a dólares. ");
            Console.WriteLine("\n5. Area y perimetro de un cuadrado. ");
            Console.WriteLine("\n6. Area y volumen de un cilindro. ");
            Console.WriteLine("\n7. Radio, Longitud y Area de una circunferencia. ");
            Console.WriteLine("\n8. Promedio de 3 numeros ");
            Console.WriteLine("  ");


            Console.WriteLine("Seleccione la opcion que desee: ");
        }
        public static void MenuCondicionales()
        {
            Console.WriteLine("Opcion Condicionales");
            Console.WriteLine("\n1. Numero positivo o negativo.");
            Console.WriteLine("\n2. Saber que numero es mayor.");
            Console.WriteLine("\n3. Numero mayor y menor de 3 numeros.");
            Console.WriteLine("\n4. Resta o suma.");
            Console.WriteLine("\n5. Cociente entre 2 numeros");
            Console.WriteLine("\n6. Multiplicacion o suma.");
            Console.WriteLine("\n7. Año bisiesto o no.");
            Console.WriteLine("  ");

            Console.WriteLine("Seleccione la opcion que desee: ");
        }
        public static void MenuCiclos()
        {
            Console.WriteLine("Opcion Ciclos");
            Console.WriteLine("\n1. Multiplos de 3");
            Console.WriteLine("\n2. Numeros impares del 0-100");
            Console.WriteLine("\n3. Numeros pares del 1-100");
            Console.WriteLine("\n4. Cuadrados del 1-30");
            Console.WriteLine("\n5. Suma de los 100 primeros numeros cuadrados");
            Console.WriteLine("\n6. Numeros Comprendidos de 2 digitos");
            Console.WriteLine("\n7. Suma de digitos");
            Console.WriteLine("  ");

            Console.WriteLine("Seleccione la opcion que desee: ");
        }
        public static void Volver()
        {
                String RespuestaContinuar = null;
                do
                {
                    // COMANDO para regresar al MENU
                    Console.WriteLine("\n¿Desea continuar usando el programa y volver al menu? SI/NO)");
                    RespuestaContinuar = Console.ReadLine();
                    if ((RespuestaContinuar == "SI") || (RespuestaContinuar == "si"))
                    {
                        Console.Clear();
                        MetodoMain.Main();
                    }

                    else if ((RespuestaContinuar == "NO") || (RespuestaContinuar == "no"))
                    {
                        Console.Clear();
                        Console.WriteLine("Salió del programa.");
                        Environment.Exit(1);
                    }
                } while ((RespuestaContinuar != "SI") && (RespuestaContinuar != "NO"));
        }

    }
}
