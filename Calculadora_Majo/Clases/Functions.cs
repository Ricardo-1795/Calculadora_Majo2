using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Majo.Clases
{
    public class Functions
    {
        public void setPersonData()
        {
            Persona person = new Persona();
            Operaciones operacion = new Operaciones();

            Console.WriteLine("Ingresa tus datos: ");
            Console.WriteLine("Dame tu nombre: ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Dame tu apellido: ");
            person.Lastname = Console.ReadLine();
            Console.WriteLine("Dame tu edad");
            person.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu carrera: ");
            person.Carrera = Console.ReadLine();
            Console.Clear();


            if (person.Edad > 18)
            {
                Console.WriteLine("Que deseas hacer");
                Console.WriteLine("Opción 1 Sumar: ");
                Console.WriteLine("Opción 2 Restar");
                Console.WriteLine("Opción 3 Multiplicar");
                Console.WriteLine("Opción 4 Peso a dolar");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        operacion.Suma();
                        break;
                    case 2:
                        operacion.Resta();
                        break;
                    case 3:
                        operacion.Multi();
                        break;
                    case 4:
                        operacion.PesoToDollar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                person.printData();
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
                person.printData();
            }

        }


    }
}
