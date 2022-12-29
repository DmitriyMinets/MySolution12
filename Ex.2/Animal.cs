using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class Animal
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public string Voice { get; set; }

        public Animal(int size, string name, string voice)
        {
            Size = size;
            Name = name;
            Voice = voice;
        }

        public void ShowVoice()
        {
            Console.WriteLine($"{Name} издаёт звук типа {Voice}");
        }
    }
}
