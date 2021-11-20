using System;
using System.Linq;

namespace MaxUniqCharacters
{
    internal class Program
    {
        /// <summary>
        /// Создайте программу, которая принимает последовательность символов (строку)
        /// в качестве аргументов из командной строки
        /// и выводит на консоль максимальное количество неравных последовательных символов в строке.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine(DistinctUserInput(null));
            Console.ReadKey();
        }

        static string DistinctUserInput(string uniqChars)
        {
            // Читаем ввод пользователя
            uniqChars = Console.ReadLine();
            // Используем Linq для вычисления уникальных значений
            var distinctChasrs = uniqChars.Distinct().Count();
            // Возвращает кол-во уникальных значений
            return distinctChasrs.ToString();
        }
    }
}