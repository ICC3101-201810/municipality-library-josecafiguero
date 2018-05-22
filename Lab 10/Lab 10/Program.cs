using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ClassLibrary1;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Address address = null;
            ClassLibrary1.Person person = null;
            ClassLibrary1.Person papi = null;
            ClassLibrary1.Person mami = null;

            Console.WriteLine("desea ingresar persona, propiedad o automovil");
            var tipodeingreso = Console.ReadLine();
            if (tipodeingreso == "persona")
            {
                Console.WriteLine("ingrese nombres");
                string name = Console.ReadLine();
                Console.WriteLine("ingrese apellidos");
                string name2 = Console.ReadLine();
                Console.WriteLine("ingrese fecha de nacimiento mm/dd/aaaa");
                System.DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("ingrese rut");
                string rut = Console.ReadLine();
                person = new Person(name, name2, date, address, rut, papi, mami);
                Console.Clear();
                Console.WriteLine("persona ingresada correctamente");


            }
                
                
        
          
            

        }
    }
}
