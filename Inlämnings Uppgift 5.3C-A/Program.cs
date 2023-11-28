using System;

namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "Är banan en frukt?";
            frågor[1] = "Vilket lands huvudstad heter Berlin?";
            frågor[2] = "Vad är 1+1?";
            frågor[3] = "Är ananas på pizza gott?";
            svar[0] = "ja";
            svar[1] = "tyskland";
            svar[2] = "2";
            svar[3] = "ja";
            Console.WriteLine("Vilken av dessa frågor vill du svara på?");
            Console.WriteLine($"Fråga 1: {frågor[0]}");
            Console.WriteLine($"Fråga 2: {frågor[1]}");
            Console.WriteLine($"Fråga 3: {frågor[2]}");
            Console.WriteLine($"Fråga 4: {frågor[3]}");
            int val = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(frågor[val]);

            if (Console.ReadLine().ToLower() == svar[val])
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }
            Console.ReadKey();
        }
    }
}