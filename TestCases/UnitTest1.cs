using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidarEntidad;

namespace TestCases
{
   
    [TestClass]
    public class UnitTest1
    {
           
        [TestMethod]
        public void ValidandoEntidad1()
        {
            Persona persona = new Persona("Ileana", "De Los Santos", "24");

            const int nameMaxLength = 64;
            bool valid = false;

            if (persona.Name.Length < nameMaxLength)
            {
                Assert.IsTrue(valid);
            }

        }

        [TestMethod]
        public void ValidandoEntidad2()
        {
            Persona persona = new Persona("Ileana", "IleanaIleanaIleanaIleanaIleanaIleanaIleanaIleanaIleanaIleanaIleanaIleanaIleana", "24");
            const int lastnameMaxLength = 128;
            bool valid = false;

            if (persona.LastName.Length < lastnameMaxLength)
            {
                Assert.IsTrue(valid);
            }
            if (persona.LastName.Length > lastnameMaxLength)
            {
                Assert.IsFalse(valid);
            }

        }


    }
}
