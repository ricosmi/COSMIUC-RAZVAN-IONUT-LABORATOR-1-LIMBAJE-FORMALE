using System;

namespace AutomatBauturi
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = "q0";
            string selectedDrink = ""; 

            Console.WriteLine("Selectati o bautura: C (Cafea), T (Ceai), A (Cappuccino), H (Ciocolata calda)");
            Console.WriteLine("Apasati OK pentru a confirma selectia.");

            while (true)
            {
                string input = Console.ReadLine().ToUpper();

                switch (state)
                {
                    case "q0":
                        if (input == "C") { state = "q1"; selectedDrink = "Cafea"; }
                        else if (input == "T") { state = "q2"; selectedDrink = "Ceai"; }
                        else if (input == "A") { state = "q3"; selectedDrink = "Cappuccino"; }
                        else if (input == "H") { state = "q4"; selectedDrink = "Ciocolata calda"; }
                        break;
                    case "q1":
                    case "q2":
                    case "q3":
                        if (input == "OK")
                        {
                            Console.WriteLine($"Bautura selectata, {selectedDrink}, a fost pregatita. Va rugam sa luati bautura.");
                            state = "q4"; 
                        }
                        break;
                    case "q4":
                        if (input == "OK")
                        {
                            Console.WriteLine("Selectati o noua bautura sau apasati OK pentru a incheia.");
                            state = "q0"; 
                            selectedDrink = ""; 
                        }
                        break;
                }

                if (state == "q4" && input == "OK") break; 
            }

            Console.WriteLine("Va multumim pentru utilizarea automatului nostru!");
        }
    }
}
