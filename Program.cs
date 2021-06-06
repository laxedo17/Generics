using System;

namespace Generics1
{
    class GenericClassDemo<T>
    {
        public T Mostrar(T value)
        {
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Introduccion a programacion con Generics.***");
            GenericClassDemo<int> minhaClaseGenericObInt = new GenericClassDemo<int>();
            Console.WriteLine("O metodo mostrar devolve: {0}", minhaClaseGenericObInt.Mostrar(1));
            GenericClassDemo<string> minhaClaseGenericObString = new GenericClassDemo<string>();
            Console.WriteLine("O metodo mostrar devolve: {0}", minhaClaseGenericObString.Mostrar("Chamamos a un metodo Generic"));
            GenericClassDemo<double> minhaClaseGenericObDouble = new GenericClassDemo<double>();
            Console.WriteLine("O metodo mostrar devolve: {0}", minhaClaseGenericObDouble.Mostrar(12.345));
            Console.ReadKey();
        }
    }
}
