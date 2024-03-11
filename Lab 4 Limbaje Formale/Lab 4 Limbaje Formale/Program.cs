using System;

class Problema_1
{
    public static char RunSequence(string sequence)
    {
        char currentState = 'A'; 
        foreach (char symbol in sequence)
        {
            switch (currentState)
            {
                case 'A':
                    if (symbol == '0')
                    {
                        currentState = 'B'; 
                    }
                    else
                    {
                        currentState = 'A'; 
                    }
                    break;
                case 'B':
                    if (symbol == '0')
                    {
                        currentState = 'A'; 
                    }
                    else
                    {
                        currentState = 'B'; 
                    }
                    break;
            }

        }

        return currentState;
    }

    static void Main(string[] args)
    {
        string secventa = Console.ReadLine();
        char state=RunSequence(secventa);
        Console.WriteLine("Stare finala: "+state);
    }
}
