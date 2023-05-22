using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class FootballPlayer:Person
    {
        public int Number { get; set; }
        public int Height { get; set; }

        public FootballPlayer(string name, int age,int number, int height)
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
        }
        public FootballPlayer() { }
    }
}
