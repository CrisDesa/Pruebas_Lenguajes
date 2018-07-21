using System;
using System.Collections.Generic;

namespace lista_inicio_rapido
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //WorkingWithStrings();
            var fibonacciNumbers = new List<int> {1, 1};
            for (int i=1; i<20; i=i+1)
            {
                //Console.WriteLine($"{i.ToString()}");
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
           }
           foreach(var item in fibonacciNumbers)
           Console.WriteLine(item);
 
        }
        
        public static void WorkingWithStrings()
        {
            var names = new List<string> { "Cris", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"¡Hola {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Hilda");
            names.Add("Emilia");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hi {name.ToUpper()}!");
            }
            Console.WriteLine($"Mi nombre es {names[0]}");
            Console.WriteLine($"Yo agregué los nombres {names[2]} y {names[3]} a la lista");
            Console.WriteLine($"La lista tiene {names.Count} personas");

            var index = names.IndexOf("Emilia");
            if (index == -1)
        {
           Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        } else
        {
            Console.WriteLine($"The name {names[index]} is at index {index}");
        }
        index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }
        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine($"{name} --> {names.IndexOf(name)}");
        }

        }
    }
}