using System;
using LambdaConsole.Generics;

namespace LambdaConsole
{
    class Program
    {
        //Define delegate types
        private delegate void SayWhat();
        private delegate void Say(string what);
        private delegate string What();

        static void Main(string[] args)
        {
            //Declare delegate object variable
            SayWhat sayWhat;

            //Assign to the delegate variable
            sayWhat = new SayWhat(SaySomething);
            sayWhat = SaySomething;

            //Assign to the delegate variable by a lambda expression, a lambda expression is always an anonymous method assigned to a variable
            sayWhat = delegate { 
                Console.WriteLine("Say what!!!"); 
            };
            sayWhat = () => { Console.WriteLine("Say what!!!"); };
            sayWhat = () => Console.WriteLine("Say what!!!");

            //Execute the delegate object variable (call assigned methods)
            sayWhat();

            Say say;
            say = delegate(string s) {
                Console.WriteLine(s.ToUpper());
            };
            say = (string s) => { Console.WriteLine(s.ToUpper()); };
            say = (s) => { Console.WriteLine(s.ToUpper()); };
            say = (s) => Console.WriteLine(s.ToUpper());
            say = s => Console.WriteLine(s.ToUpper());
            say("what??");

            What what;
            what = delegate { return "..ehh say!"; };
            what = () => "..ehh say!";
            Console.WriteLine(what());


            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }

        private static void SaySomething()
        {
            Console.WriteLine("Say something..");
        }

        #region GenericList

        private static void GenericListSample()
        {
            var people = new List<Person>();
            people.Add(new Person(1, "Jannie", "Janniesen"));
            people.Add(new Person(2, "Jaap", "Jaapsen"));
            people.Add(new Person(3, "Merel", "Merelsen"));

            var filteredPeople = people.Where(p => p.Surname.StartsWith("J"));

            for (int i = 0; i < filteredPeople.Length; i++)
            {
                Console.WriteLine(filteredPeople[i].Surname);
            }

            //Opdracht
            // 1. implementeer de code voor onderstaande foreach loop
            //      foreach(var p in people_j) Console.WriteLine(p.Surname);
            // 2. voeg de methode First() aan de classe List toe
            //      de parameter moet een lambda expressie als argument mee kunnen krijgen
            //      implementeer de code om in de collectie van T de eerste gevonden T terug te geven die aan de lambda expressie voldoet
            // 3. Voeg de methode Any() aan de classe List toe 
            //      de parameter moet een lambda expressie als argument mee kunnen krijgen
            //      implementeer de code waarbij true terug gegeven wordt wanneer de lambda expressie op T waar is in de collectie van de T

        } 

        #endregion
    }
}
