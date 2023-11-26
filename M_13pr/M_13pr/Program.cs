using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_13pr
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 4, 8, 2, 10, 7, 5, 9, 3 };

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");

            FindAndPrintSecondMax(numbers);

            RemoveOddElements(numbers);

            Console.WriteLine("Измененная коллекция после удаления нечетных элементов:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void FindAndPrintSecondMax(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("Коллекция содержит меньше двух элементов.");
                return;
            }

            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = number;
                }
                else if (number > secondMax && number < firstMax)
                {
                    secondMax = number;
                }
            }

            int secondMaxIndex = numbers.IndexOf(secondMax);

            Console.WriteLine($"Позиция второго максимального элемента: {secondMaxIndex}, Значение: {secondMax}");
        }

        static void RemoveOddElements(List<int> numbers)
        {
            numbers.RemoveAll(x => x % 2 != 0);
        }
    }
}
