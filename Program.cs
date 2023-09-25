using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Örnek giriş formatı: Algoritma,3");
        Console.Write("Giriş: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');

        if (parts.Length == 2 && int.TryParse(parts[1], out int index))
        {
            string str = parts[0];
            if (index >= 0 && index < str.Length)
            {
                string modifiedStr = RemoveCharAtIndex(str, index);
                Console.WriteLine("Çıktı: " + modifiedStr);
            }
            else
            {
                Console.WriteLine("Geçersiz indeks: " + index);
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş formatı. Örnek format: Algoritma,3");
        }
    }

    static string RemoveCharAtIndex(string str, int index)
    {
        if (index < 0 || index >= str.Length)
            return str;

        return str.Remove(index, 1);
    }
}

