using System;

class Problema_1
{
    public enum Stare { S1, S2 }
    public enum Iesire {O1,O2}

    public static Iesire RunSequence(string sequence)
    {
        Stare currentState= Stare.S1;
        foreach(char input in sequence)
        {
            switch(currentState)
            {
                case Stare.S1:
                    if(input =='A')
                    {
                        currentState = Stare.S1;
                    }
                    else
                        if(input =='B')
                    {
                        currentState = Stare.S2;
                    }
                    break;

                case Stare.S2:
                    if(input == 'A')
                    {
                        currentState = Stare.S1;
                    }
                    else
                        if(input == 'B')
                    {
                        currentState = Stare.S2;
                    }
                    break;
            }
        }
        return currentState==Stare.S1 ? Iesire.O1 : Iesire.O2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti secventa de intrari (A sau B):");
        string sequence = Console.ReadLine();
        Iesire iesire = RunSequence(sequence.ToUpper());
        Console.WriteLine($"Iesire finala: {iesire}");
    }
}
