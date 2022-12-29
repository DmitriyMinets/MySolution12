using System;
using System.Collections;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "стол", "мебель", "коробка", "спички", "пол" };

            IEnumerable GetEnumerator(string[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length > 5)
                        yield return array[i];
                }
            }

            var word = GetEnumerator(array);
            foreach(string s in word)
            {
                Console.WriteLine(s);
            }
        }

    }

}