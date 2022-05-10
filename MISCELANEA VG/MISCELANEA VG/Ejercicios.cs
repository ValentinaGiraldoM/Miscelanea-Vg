using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA_VG
{
    internal class Ejercicios
    {
        
        static double numero1, numero2, numero3, numero4;
        public void AreaTriangulo()
        {
            try
            {
                Console.WriteLine("Ingrese el numero de la base:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese e numero de la altura: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area del triangulo es: " + (numero1 * numero2 / 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe Ingresar un Numero para ver el resultado");
            }
        }
        public void  SumaNumeros()
        {
            try { 
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma es: " + (numero1+numero2));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
          
        }
        public void ElevadoCuadrado()
        {
            try
            {
                Console.WriteLine("Ingrese el numero que desea elevar al cuadrado: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + Math.Pow(numero1,2));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }

        }
        public void ConvertidorEuro()
        {
            try
            {
                Console.WriteLine("Ingrese el numero de Euros: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("EL resultado de Dolares es: " + (numero1 * 1.06));
            }
            catch {
                Console.WriteLine("Dato Invalido");
            }
        }
        public void PerimetroCuadrado()
        {
            try
            {
                Console.WriteLine("Ingrese la medida de un lado del cuadro: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El Area es: " + (numero1 * numero1));
                Console.WriteLine("El Perimetro es: " + (numero1 + numero1 + numero1 + numero1));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }
        public void VolumenCilindro()
        {
            try {
                Console.WriteLine("Ingrese el numero de la Altura:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese e numero de la Radio: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area es: " + ((2 * Math.PI) * numero2 * numero1 + (2 * Math.PI) * (numero2 * numero2)));
                Console.WriteLine("El Volumen es: " + ((3.14 * (numero2 * numero2) * numero1)));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }

        }
        public void RadioCircunferencia()
        {
            try
            {
                Console.WriteLine("Ingrese el numero del Diametro:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El radio es: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("La longitud es: " + ((2 * Math.PI) * numero1));
                Console.WriteLine("El area es: " + ((Math.PI * (numero1 * numero1))));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void PromedioNumeros()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero: ");
                numero3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El Promedio es es: " + (numero1 + numero2 + numero3 / 3));
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }


        
        public void NumeroNP()
        {
        try
        {
            Console.WriteLine("Ingrese el numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            if (numero1 <= 0)
            {
                Console.WriteLine("Es un numero Negativo");
            }

            else if (numero1 >= 0)
            {
                Console.WriteLine("Es un numero Positivo");
            }
        }
        catch
        {
            Console.WriteLine("Dato Invalido");
        }
    }

        public void NumeroMayor()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero3 = Convert.ToDouble(Console.ReadLine());


                if (numero1 < numero2)
                {
                    Console.WriteLine(numero1 + " Es menor que " + numero2);
                }

                else if (numero1 > numero2)
                {
                    Console.WriteLine(numero1 + " Es Mayor que " + numero2);
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void NumeroMayMen()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero3 = Convert.ToDouble(Console.ReadLine());


                if (numero1 > numero2)
                {
                    Console.WriteLine("El numero mayor es " + numero1);
                }

                else if (numero2 > numero3)
                {
                    Console.WriteLine("El numero mayor es " + numero2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es " + numero3);
                }
                if (numero1 < numero2)
                {
                    Console.WriteLine("El numero menor es " + numero1);
                }

                else if (numero2 < numero3)
                {
                    Console.WriteLine("El numero menor es " + numero2);
                }
                else
                {
                    Console.WriteLine("El numero menor es " + numero3);
                }

            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void RestaSuma()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero2 = Convert.ToDouble(Console.ReadLine());


                if (numero1 < numero2)
                {
                    Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
                }

                else if (numero1 > numero2)
                {
                    Console.WriteLine("El resultado de la resta es " + (numero1 - numero2));
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }
        

        public void CocienteEntreDosNumeros()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero2 = Convert.ToDouble(Console.ReadLine());


                if (numero1 == 0)
                {
                    Console.WriteLine("No se puede dividir entre Cero");
                }

                else if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre Cero");
                }
                else if (numero1 > 0)
                {
                    Console.WriteLine("El cociente es: " + numero1 / numero2);
                }
            }

            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void MultSum()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero:  ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:  ");
                numero2 = Convert.ToDouble(Console.ReadLine());


                if (numero1 < 0)
                {
                    Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
                }

                else if (numero2 < 0)
                {
                    Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
                }
                else if (numero1 > 0)
                {
                    Console.WriteLine("El resultado de la multiplicacion es " + (numero1 * numero2));
                }
                else if (numero2 > 0)
                {
                    Console.WriteLine("El resultado de la multiplicacion es " + (numero1 * numero2));
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void AñoBisiesto()
        {
            try { 
            Console.WriteLine("Escriba el año: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            bool MultiploDe4 = (numero1 % 4 == 0);
            bool MultiploDe100 = (numero1 % 100 == 0);
            bool MultiploDe400 = (numero1 % 400 == 0);

            bool bisiesto = MultiploDe400 || (MultiploDe4 && !MultiploDe100);
            if (bisiesto)
            {
                Console.WriteLine("Es bisiesto");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
            
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void MultiploTres()
        {
            try
            {
                Console.WriteLine("Multiplos de 3");
                Console.WriteLine("  ");
                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void NumeroImpares()
        {
            try
            {
                Console.WriteLine("Imprimir numeros impares del 1 al 100");
                Console.WriteLine("  ");
                for (int i = 2; i <= 100; i = i + 2)
                {

                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void NumeroPares()
        {
            try
            {
                Console.WriteLine("Imprimir numeros pares del 0 al 100");
                Console.WriteLine("  ");
                for (int i = 2; i <= 100; i = i + 2)
                {
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void Cuadrados()
        {
            try
            {
                Console.WriteLine(" Cuadrados del 1-30");
                Console.WriteLine("  ");

                Console.WriteLine("\n   ");

                for (numero1 = 1; numero1 <= 30; numero1++)
                {
                    Console.WriteLine(Math.Pow(numero1, 2));
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void SumaNumCuadrados()
        {
            try
            {
                int i = 1, cuad = 0, n1 = 1, sum = 0;

                Console.WriteLine("Suma de los cuadrados de los 100 primeros numeros naturales");
                Console.WriteLine("  ");

                for (i = 1; i <= 100; i++)

                {

                    cuad = n1 * i;

                    cuad = cuad * i;

                    sum = sum + cuad;

                    Console.WriteLine("cuadrado de:\t" + i + "\tes\t" + cuad);

                }

                Console.WriteLine("la suma de los cuadrados es:\t" + sum);
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void NumDosDigitos()
        {
            try
            {
                Console.WriteLine("Digite el primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                for (numero3 = numero1 + 1; numero3 < numero2; numero3++)
                {
                    Console.WriteLine("Los numeros comprendidos entre " + numero1 + " y " + numero2 + " son :");
                    Console.WriteLine(numero3);
                }
            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }

        public void SumaDigitos()
        {
            try
            {
                
                string linea;
                Console.WriteLine("Ingrese un valor (0 para finalizar) :");
                do
                {

                    linea = Console.ReadLine();
                    numero2 = int.Parse(linea);
                    if (numero2 != 0)
                    {
                        numero1 = numero1 + numero2;
                        Console.WriteLine("El resultado de la suma es : " + numero1 + "\n");
                    }
                    else
                    {
                        Console.WriteLine("No se ingresan mas valores");
                    }
                }
                while (numero2 != 0);

            }
            catch
            {
                Console.WriteLine("Dato Invalido");
            }
        }
    
    }
    
    
}
