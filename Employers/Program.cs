namespace Employers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employers> employers = new List<Employers>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Employers employer = new Employers();
                employer.Name = input[0];
                employer.Salary = double.Parse(input[1]);
                employer.Position = input[2];
                employer.Department = input[3];
                employer.Email = input[4];
                if (input.Length == 5)
                {
                    if (input[4].Contains('@'))
                    {
                        employer.Email = input[4];
                    }
                    else
                    {
                        employer.Age = int.Parse(input[4]);
                    }
                }
                else if (input.Length == 6)
                {
                    employer.Email = input[4];
                    employer.Age = int.Parse(input[5]);
                }
                employers.Add(employer);
            }

        }
    }
}
