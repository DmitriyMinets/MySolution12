using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class UserList
    {
        private List<Animal> _animals;

        public UserList(List<Animal> animals)
        {
            _animals = new List<Animal>();
            _animals = animals;
        }

        public void Add(Animal animal)
        {
            _animals.Add(animal);
            Sort();
            Show();
        }

        private void Sort()
        {
            for(int i = 0; i < _animals.Count; i++)
            {
                for(int j = _animals.Count - 1; j > i; j--)
                {
                    var temp= _animals[i];
                    if (_animals[i].Size > _animals[j].Size)
                    {
                        temp = _animals[i];
                        _animals[i] = _animals[j];
                        _animals[j] = temp;
                    }
                }
            }
        } //Сортируем по размеру животного
        private void Show()
        {
            foreach(var item in _animals)
            {
                Console.WriteLine($"Имя животного - {item.Name}. Размер животного {item.Size}. ");
            }
        }
    }
}
