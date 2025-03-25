using System;

namespace Actividad01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class gym
    {
        public int cantmaquinas;
        public string nombrermaquina;
        public string musculoquetrabaja;

        public void descanso()
        {
            Console.WriteLine("En descanso");
        }

        public void enactividad()
        {
            Console.WriteLine("En actividad");
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
            Console.WriteLine("El perro esta comiendo");
        }
        public void ladrar()
        {
            Console.WriteLine("El perro esta ladrando");
        }
        public void durmiendo()
        {
            Console.WriteLine("El perro esta durmiendo");
        }
    }
}
