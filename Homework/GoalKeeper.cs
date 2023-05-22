using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class GoalKeeper : FootballPlayer
    {
        public GoalKeeper(string name, int age, int number, int height)
        {
            Name = name;
            Age = age;
            Number = number;
            Height = height;
        }
        public GoalKeeper() { }
    }
}
