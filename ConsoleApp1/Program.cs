using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. 
             * Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. 
             * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
             * (пример палиндрома – «А роза упала на лапу Азора»).*/
            
            Console.WriteLine("Введите предложение без знаков препинания:");
            string str = Console.ReadLine();

            //убрать пробелы
            string strWithout = str.Replace(" ", "");

            //Проверить, является ли строка палиндромом
            char[] strReverse = strWithout.ToCharArray();
            Array.Reverse(strReverse);
            string finaltext = new string(strReverse);
            if (strWithout == finaltext)
            {
                Console.Write("Введенное предложение - палиндром");
            }
            if (strWithout != finaltext)
            {
                Console.Write("Введенное предложение - не палиндром");
            }

            Console.ReadKey();
        }
    }
}
