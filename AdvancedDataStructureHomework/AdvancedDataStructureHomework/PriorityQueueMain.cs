namespace AdvancedDataStructureHomework
{
    using System;

    public class PriorityQueueMain
    {
        public static void Main()
        {
            // check priority queue 1
            Console.WriteLine("Priority queue 1 - first way:");
            Console.WriteLine("===============================");
            PriorityQueue<Person, Person> people = new PriorityQueue<Person, Person>();
            people.Enqueue(new Person("George", 21), new Person("George", 21));
            people.Enqueue(new Person("Little Lucho", 2), new Person("Little Lucho", 2));
            people.Enqueue(new Person("Doncho", 23), new Person("Doncho", 23));
            people.Enqueue(new Person("Niki", 22), new Person("Niki", 22));
            Console.WriteLine(people.Dequeue().Value);
            people.Enqueue(new Person("Nakov", 28), new Person("Nakov", 28));
            people.Enqueue(new Person("Ina", 24), new Person("Ina", 24));
            people.Enqueue(new Person("Asya", 22), new Person("Asya", 22));
            while (people.Count > 0)
            {
                Console.WriteLine(people.Dequeue().Value);
            }

            Console.WriteLine();

            Console.WriteLine("Priority queue 2 - second way:");
            Console.WriteLine("===============================");
            PriorityQueue<Person, int> people2 = new PriorityQueue<Person, int>();
            people2.Enqueue(new Person("George", 21), 0);
            people2.Enqueue(new Person("Little Lucho", 2), 0);
            people2.Enqueue(new Person("Doncho", 23), 0);
            people2.Enqueue(new Person("Niki", 22), 0);
            Console.WriteLine(people2.Dequeue().Key);
            people2.Enqueue(new Person("Nakov", 28), 0);
            people2.Enqueue(new Person("Ina", 24), 0);
            people2.Enqueue(new Person("Asya", 22), 0);
            while (people2.Count > 0)
            {
                Console.WriteLine(people2.Dequeue().Key);
            }
        }
    }
}