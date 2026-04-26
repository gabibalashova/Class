using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employers
{
    class Employers
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                    return;
                }
                name = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Salary cannot be less than or equal to 0");
                    return;
                }
                salary = value;
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Position cannot be null or empty");
                    return;
                }
                position = value;
            }
        }
        public string Department
        {
            get { return department; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Department cannot be null or empty");
                    return;
                }
                department = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Email cannot be null or empty");
                    return;
                }
                email = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age must be greater than 0.");
                    return;
                }
                age = value;
            }
        }
        public Employers()
        {
        }
        public Employers(string name, double salary, string position, string department, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
    }
}
