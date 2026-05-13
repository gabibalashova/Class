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

        public double CalculateProductPerDay()
        {
           if (Age >= 0 && Age < 6)
        {
        return 2;
        }
           else if (Age >= 6 && Age < 12)
        {
        return 1;
        }
          else
       {
        return 0.75;
        }
}

      public override string ToString()
       {
        return $"Chicken {Name} (age {Age}) can produce {CalculateProductPerDay()} eggs per day.";
       }
    }
}
