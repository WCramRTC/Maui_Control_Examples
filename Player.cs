using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_Control_Examples
{
    internal class Player
    {

        string _name;
        int _age;

        public Player(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public override string ToString()
        {
            return $"Name: {_name} - Age: {_age}";
        }
    }
}
