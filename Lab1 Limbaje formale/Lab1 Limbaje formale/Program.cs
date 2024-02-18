using System;
using System.Linq;

class Program
{
    static string[] Concat(string[] s1, string[] s2)
    {
        return s1.Concat(s2).ToArray();
    }

    static string[] Repeat(string[] s, int n)
    {
        return Enumerable.Repeat(s, n).SelectMany(x => x).ToArray();
    }

    static string[] Reverse(string[] s)
    {
        return s.Reverse().ToArray();
    }

    static string[] Extract(string[] s, int i, int j)
    {
        return s.Skip(i).Take(j - i + 1).ToArray();
    }

    static string[] Replace(string[] s, string startSub, string[] newSub)
    {
        List<string> result = new List<string>();
        int startIndex = Array.IndexOf(s, startSub);

        if (startIndex == -1)
        {
            return s; 
        }
        for (int i = 0; i < startIndex; i++)
        {
            result.Add(s[i]);
        }
        result.AddRange(newSub);
        return result.ToArray();
    }

    static void Main(string[] args)
    {
       
        string[] Sigma1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] Sigma2 = { "a", "b", "c", "d", "e", "f", "g", "i", "j", "k" };
        string[] Sigma3 = { "x1", "y1", "x2", "y2", "x3", "y3", "x4", "y4", "x5", "y5" };
        
        Console.WriteLine($"Concatenated(Sigma1, Sigma2): {String.Join(" ", Concat(Sigma1, Sigma2))}");
        Console.WriteLine($"Concatenated(Sigma3, Sigma1): {String.Join(" ", Concat(Sigma3, Sigma1))}");

        Console.WriteLine($"Repeated Sigma3: {String.Join(" ", Repeat(Sigma3, 3))}");

        Console.WriteLine($"Reversed: {String.Join(" ", Reverse(Sigma3))}");

        Console.WriteLine($"Extracted: {String.Join(" ", Extract(Sigma3, 1, 3))}");

        Console.WriteLine($"Replaced: {String.Join(" ", Replace(Sigma3, "y3", Sigma1))}");
    }
}

/*  PROBLEMA 1 
     * static string Concatenate(char[] array1, char[] array2)
    {
        StringBuilder result = new StringBuilder();
        foreach (char element in array1)
        {
            result.Append(element);
        }
        foreach (char element in array2)
        {
            result.Append(element);
        }
        return result.ToString();
    }

    static char[] Invers(char[] s)
    {
        char[] reverse = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            reverse[i] = s[s.Length - 1 - i];
        }
        return reverse;
    }

    static char[] Substituie(char[] s, char a, char b)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            result[i] = s[i] == a ? b : s[i];
        }
        return result;
    }

    static int Lungime(char[] s)
    {
        return s.Length;
    }

    static void Main(string[] args)
    {
        char[] A = { 'a', 'b', 'c', 'a', 'b', 'x', 'c' };
        char[] B = { '*', '&', '$', '*', '%' };
        char[] C = { '1', '2', '3', '4', '5' };


        //CONCATENARE
        Console.WriteLine("CONCATENARE");
        Console.WriteLine(Concatenate(A, B));
        Console.WriteLine(Concatenate(A, C));
        Console.WriteLine(Concatenate(B, C));

        //INVERSARE
        Console.WriteLine("\nINVERSARE");
        Console.WriteLine($"Inversul lui A: {String.Join("", Invers(A))}");
        Console.WriteLine($"Inversul lui B: {String.Join("", Invers(B))}");
        Console.WriteLine($"Inversul lui C: {String.Join("", Invers(C))}");

        //SUBSTITUTIE
        Console.WriteLine("\nSUBSTITUTIE");
        Console.WriteLine($"Substitutie A(a,$):  {String.Join("", Substituie(A, 'a', '$'))}");
        Console.WriteLine($"Substitutie B(*,3):  {String.Join("", Substituie(B, '*', '3'))}");


        //DETERMINARE LUNGIME
        Console.WriteLine("\nLUNGIME");
        Console.WriteLine($"Lungimea lui A: {Lungime(A)}");
        Console.WriteLine($"Lungimea lui B: {Lungime(B)}");
        Console.WriteLine($"Lungimea lui C: {Lungime(C)}");*/