using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_Ciclos_y_condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre = "juan";
            int? num1 = null;
            var persona = new { nombre = "Felipe", edad = 28 };
            int valor1, valor2;
            var variable = true;
            float salario;
            dynamic dinamico = 25;
            dinamico = " cadena de caracteres";
            dinamico = false;
            Console.WriteLine(num1);

            valor1 = 15;
            valor2 = 20;
            salario = 325.56f;
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"La suma de {valor1} + {valor2} = {valor1+valor2}");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"La multiplicacion de {valor1} * {valor2} = {valor1 * valor2}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La resta de {valor1} - {valor2} = {valor1 - valor2}");
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"La division de {valor1} / {valor2} = {valor1 / valor2}");

            Console.ForegroundColor = ConsoleColor.White;

            float total = 0;
            total = salario * (salario * 013f);
            Console.ForegroundColor = ConsoleColor.Cyan;
            String.Format("0:00",total);

            Console.WriteLine($"El salario de {persona.nombre} es de {salario} el IVA: {(salario * 0.13)} total = {total}");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Nombre " + persona.nombre + " Edad " +persona.edad);
            Console.WriteLine($"Nombre: { persona.nombre}  Edad: {persona.edad}");
            Console.WriteLine("Nombre: {0}  Edad: {1}" , persona.nombre,persona.edad);

            //Arreglos y Matrices

            string[] musicos = new string[] { "Ringo", "George", "Paul", "John" };// tam año de 4 
                                               //0       //1      //2     //3    
            float[] salarios = new float[4];
            salarios[0] = 500;
            salarios[1] = 300;
            salarios[2] = 100;
            salarios[3] = 250;
            Console.WriteLine(musicos.Length);

            /* == comparar
             * && AND
             *  || OR
             *  ! NOT 
             *  > Mayor que
             *  <Menor que
             *  >=Mayor o igual
             *  <=Menor o igual
             *  % resto de division
             *  => expresiones lambda
             */
            //i =3
            //mayor o igual que 0 i>=0 3 hasta 0
            //

            float promedio = 0;

            for (int i = 0; i < musicos.Length; i++)
            {
                promedio += salarios[i];//Acumulador

                Console.WriteLine($"Musico: { musicos[i]} salario: {salarios[i]}");
            }
            Console.WriteLine("El promedio de salarios es de: {0}", (promedio /= musicos.Length));

            Console.Read();
        }
    }
}
