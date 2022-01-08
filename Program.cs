using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarEntidad
{
    public class Persona
    {
        private string name;
        private string lastName;
        private string age;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Age { get => age; set => age = value; }

        public Persona(string name, string lastName, string age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }


        static void Main(string[] args)
        {
            Persona persona = new Persona("Ileana","De Los Santos","24");

            if (persona.Name.Length>2 & persona.Name.Length<64)
            {
                Console.WriteLine(persona.Name + "\nEl nombre cumple con los requisitos\n");
            }
            else 
            {
                Console.WriteLine(persona.Name + "\nEl nombre no cumple con los requisitos\n");
            }


            if (persona.LastName.Length > 2 & persona.LastName.Length < 128)
            {
                Console.WriteLine(persona.LastName + "\nEl apellido cumple con los requisitos\n");
            }
            else
            {
                Console.WriteLine(persona.LastName + "\nEl apellido no cumple con los requisitos\n");
            }

            Console.ReadKey();
        }
    }
}
