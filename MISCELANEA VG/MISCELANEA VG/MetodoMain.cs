using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA_VG
{
    public class MetodoMain
    {
        public static void Main()
        {
            


            menus.MenuPrincipal();
            String Opciones = null;
            Opciones = Console.ReadLine().ToString();

            switch (Opciones)
            {
                case "1":
                    menus.MenuOperadores();

                    String s1 = null;
                    s1 = Console.ReadLine().ToString();


                    Ejercicios operadores = new Ejercicios();
                    switch (s1)
                    {
                        case "1":
                            operadores.AreaTriangulo();
                            menus.Volver();
                            break;

                        case "2":
                            operadores.SumaNumeros();
                            menus.Volver();
                            break;

                        case "3":
                            operadores.ElevadoCuadrado();
                            menus.Volver();
                            break;

                        case "4":
                            operadores.ConvertidorEuro();
                            menus.Volver();
                            break;

                        case "5":
                            operadores.PerimetroCuadrado();
                            menus.Volver();
                            break;

                        case "6":
                            operadores.VolumenCilindro();
                            menus.Volver();
                            break;

                        case "7":
                            operadores.RadioCircunferencia();
                            menus.Volver();
                            break;

                        case "8":
                            operadores.PromedioNumeros();
                            menus.Volver();
                            break;
                        default:
                            Console.WriteLine("Dato Invalido");
                            break;
                    }
                    break;


                case "2":

                    menus.MenuCondicionales();
                    String s2 = null;
                    s2 = Console.ReadLine().ToString();


                    Ejercicios condicionales = new Ejercicios();
                    switch (s2)
                    {
                        case "1":
                            condicionales.NumeroNP();
                            menus.Volver();
                            break;

                        case "2":
                            condicionales.NumeroMayor();
                            menus.Volver();
                            break;

                        case "3":
                            condicionales.NumeroMayMen();
                            menus.Volver();
                            break;

                        case "4":
                            condicionales.RestaSuma();
                            menus.Volver();
                            break;

                        case "5":
                            condicionales.CocienteEntreDosNumeros();
                            menus.Volver();
                            break;

                        case "6":
                            condicionales.MultSum();
                            menus.Volver();
                            break;

                        case "7":
                            condicionales.AñoBisiesto();
                            menus.Volver();
                            break;
                        default:
                            Console.WriteLine();
                            menus.Volver();
                            break;
                    }
                    break;

                case "3":
                    menus.MenuCiclos();

                    String s3 = null;
                    s3 = Console.ReadLine().ToString();

                    Ejercicios ciclos = new Ejercicios();

                    switch (s3)
                    {
                        case "1":
                            ciclos.MultiploTres();
                            menus.Volver();
                            break;

                        case "2":
                            ciclos.NumeroImpares();
                            menus.Volver();
                            break;

                        case "3":
                            ciclos.NumeroPares();
                            menus.Volver();
                            break;

                        case "4":
                            ciclos.Cuadrados();
                            menus.Volver();
                            break;

                        case "5":
                            ciclos.SumaNumCuadrados();
                            menus.Volver();
                            break;

                        case "6":
                            ciclos.NumDosDigitos();
                            menus.Volver();
                            break;

                        case "7":
                            ciclos.SumaDigitos();
                            menus.Volver();
                            break;
                        default:
                            Console.WriteLine("Dato Invalido");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Dato Invalido");
                    break;
            }

         }
           
     }
} 
    

