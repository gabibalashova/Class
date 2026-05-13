using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
    class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                age = value;
            }
        }

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string CalculateProductPerDay()
{
    if (this.age < 0 || this.age > 15)
    {
        throw new ArgumentException("Age should be between 0 and 15.");
    }

    return $"Chicken {this.name}(age {this.age}) can produce 1 eggs per day.";
}

public string ToString()
{
    return $"Chicken {Name} (age {Age}) can produce {CalculateProductPerDay()} eggs per day.";
}
    }
}
