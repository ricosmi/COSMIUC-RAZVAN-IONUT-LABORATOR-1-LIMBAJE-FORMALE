using System;
using System.Collections.Generic;

/* PROBLEMA 1
 * class Program
{
    static void GeneratePalindromes(string current, int position, int targetLength)
    {
        if (current.Length == targetLength)
        {
            Console.WriteLine(current);
            return;
        }

        for (char c = '0'; c <= '2'; c++)
        {
            string newPalindrome = current;
            if (targetLength == 1)
            {
                Console.WriteLine(c);
            }
            else if (position == 0) 
            {
                newPalindrome = c + newPalindrome + c;
                if (newPalindrome.Length <= targetLength)
                {
                    GeneratePalindromes(newPalindrome, position + 1, targetLength);
                }
            }
            else if (current.Length + 2 <= targetLength) // Adăugăm caractere în mod simetric pentru a menține palindromul
            {
                newPalindrome = c + newPalindrome + c;
                GeneratePalindromes(newPalindrome, position + 1, targetLength);
            }
        }
    }
    static void Main()
    {
        for (int length = 1; length <= 5; length++)
        {
            GeneratePalindromes("", 0, length);
        }
    }
}*/

/*PROBLEMA 2
 * class Program
{
    static List<string> GenerateStrings(int iteration)
    {
        List<string> result = new List<string>();

        if (iteration == 1)
        {
            result.Add("a");
            result.Add("b");
        }
        else
        {
           
            var prevIterationStrings = GenerateStrings(iteration - 1);
            foreach (var str in prevIterationStrings)
            {
               
                result.Add("a" + str + "a");
                result.Add("b" + str + "b");
            }

            if (iteration == 3)
            {
                result.Add("aa");
                result.Add("bb");
            }
        }

        return result;
    }
    static void Main()
    {
        var iterations = 3;
        for (int i = 1; i <= iterations; i++)
        {
            Console.WriteLine($"Iteratia {i}:");
            foreach (var str in GenerateStrings(i))
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}*/

class Program
{
    
    static void GenerateStringsGramatica1(int maxLength)
    {
        GenerateA("", 'S', maxLength);
    }

    static void GenerateA(string current, char rule, int maxLength)
    {
        if (current.Length > maxLength) return;
        if (rule == 'S')
        {
            GenerateA(current, 'A', maxLength);
            GenerateA(current, 'B', maxLength);
        }
        else if (rule == 'A')
        {
            if (current.Length + 1 <= maxLength) GenerateA(current + "a", 'A', maxLength);
            GenerateA(current + "a", 'B', maxLength); 
        }
        else if (rule == 'B')
        {
            if (current.Length + 1 <= maxLength)
            {
                Console.WriteLine(current + "b"); 
                GenerateA(current + "b", 'B', maxLength); 
            }
        }
    }

    static void GenerateStringsGramatica2(int maxLength)
    {
        GenerateX("", 'S', maxLength);
    }

    static void GenerateX(string current, char rule, int maxLength)
    {
        if (current.Length >= maxLength) return;
        if (rule == 'S' || rule == 'X')
        {
            GenerateX(current + "0", 'Y', maxLength);
            GenerateX(current + "1", 'Z', maxLength);
        }
        else if (rule == 'Y')
        {
            if (current.Length + 1 <= maxLength)
            {
                Console.WriteLine(current + "2");
                GenerateX(current + "2", 'X', maxLength); 
            }
        }
        else if (rule == 'Z')
        {
            if (current.Length + 1 <= maxLength)
            {
                Console.WriteLine(current + "3");
                Console.WriteLine(current + "4");
                GenerateX(current + "3", 'X', maxLength); 
                GenerateX(current + "4", 'X', maxLength); 
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Gramatica 1:");
        GenerateStringsGramatica1(3); 

        Console.WriteLine("\nGramatica 2:");
        GenerateStringsGramatica2(3); 
    }
}

