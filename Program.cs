using System;
using System.Collections.Generic;

// # Klasser
// ## Övning 1 - del 1

// Skapa en klass för ditt favoritdjur. Skapa klassmedlemmar (både variabler & metoder) som du tycker är lämpliga. T.ex. kan djuret 
//innehålla 
// de publika variablerna name, race och age samt de publika metoderna Bark() & Fetch(). Skapa sedan ett testobjekt till klassen.

// ## Del 2

// Gör om så att variablerna i din djur-klass är osynliga, private. De skall istället göras om till egenskaper (get & set). 
// Använd egenskaperna i ett testobjekt.

// ## Del 3

// Skapa en konstruktor till din djur-klass som tar emot värden för namn, ålder, ras eller vad du nu skapat för variabler. 
// Använd konstruktorn i ett testobjekt.

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar instanser av två olika konstruktorer i samma klass.
            Dog dog = new Dog(13, "Hej", "Hejhopp");
            Dog doggen = new Dog(1, "Hej");

            //skriver ut de båda konstruktorerna. 
            //fråga: hur får man bort texten "exercises_classes.Dog" efter att konstruktorn körts ?
            Console.WriteLine(dog);
            Console.WriteLine(doggen);
            
            Console.ReadKey();
        }
    }

//test av olika konstrukterer
    class Dog
    {
        private int age;
        private string name;
        private string race;

            public Dog (int Age, string Name, string Race)
            {
                age = 4;
                age = Age;
                name = "Zelda";
                name = Name;
                race = "Schäfer";
                race  = Race;
                System.Console.WriteLine(Age + " " + Race + " " + Name + " ");
            }

            public Dog (int j, string a)
            {
                for (int i = j; j < 11; j++)
                {
                    System.Console.WriteLine(j + ". " + a);
                }
            }


        
}


}
    
