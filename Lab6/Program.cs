using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести с клавиатуры предложение. 
                 Предложение представляет собой слова, разделенные пробелом.
                 Знаки препинания не используются. 
                 Найти самое длинное слово в строке.*/
            Console.WriteLine("Введите предложение без знаков препинания:");
            string startString = Console.ReadLine();
            string stringArrayMaxLength = string.Empty;
            string[] stringArray = startString.Split();
            Console.WriteLine("\nCамое длинное слово:");
            for (int i = 0; i < stringArray.Length; i++)
                if (stringArray[i].Length > stringArrayMaxLength.Length)
                    stringArrayMaxLength = stringArray[i];

            Console.WriteLine(stringArrayMaxLength);
            Console.ReadKey();
        }
    }
}
