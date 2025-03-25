using System;

namespace Actividad01
{
    class Program
    {
        static void Main(string[] args)
        {
            gym gimnasio1 = new gym();
            gimnasio1.nombregym = "Lo de manolo";
            gimnasio1.cantmaquinas = 20;
            gimnasio1.cantpersonal = 10;
            gimnasio1.clasemassolicitada = "Pilates";
            gimnasio1.musculoquetrabaja = "Full body";

            perros perro1 = new perros();
            perro1.nombre = "Kira";
            perro1.raza = "Labrador";
            perro1.edad = 3;
            perro1.peso = 20;
        }


        public class gym
        {
            public string nombregym;
            public int cantmaquinas;
            public int cantpersonal;
            public string clasemassolicitada;
            public string musculoquetrabaja;

            public void abierto()
            {
                Console.WriteLine($"Gimnasio {nombregym} ABIERTO");
            }

            public void cerrado()
            {
                Console.WriteLine($"Gimnasio {nombregym} CERRADO");
            }
        }

        public class perros
        {
            public string nombre;
            public string raza;
            public int edad;
            public float peso;

            public void comiendo()
            {
                Console.WriteLine($"{nombre} esta comiendo");
            }
            public void ladrar()
            {
                Console.WriteLine($"{nombre} esta ladrando");
            }
            public void durmiendo()
            {
                Console.WriteLine($"{nombre} esta durmiendo");
            }
            //$"{nombre1} de raza {raza} esta maullando"
        }
    }
}
