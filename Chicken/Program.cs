namespace Chicken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                Chicken chicken = new Chicken(name, age);

                Console.WriteLine(chicken);

                // 2



                //Console.WriteLine("How many chickens? ");
                //int n = int.Parse(Console.ReadLine());

                //Chicken[] farm = new Chicken[n];

                //for (int i = 0; i < n; i++)
                //{
                //    Console.Write("Enter name: ");
                //    string chickenName = Console.ReadLine();

                //    Console.Write("Enter age: ");
                //    int chickenAge = int.Parse(Console.ReadLine());

                //    farm[i] = new Chicken(chickenName, chickenAge);
                //}

                //foreach (Chicken ch in farm)
                //{
                //    Console.WriteLine(ch);
                //}



                // 3

                //Console.WriteLine("Enter : ");
                //int n = int.Parse(Console.ReadLine());

                //Console.WriteLine("How many days? ");
                //int days = int.Parse(Console.ReadLine());

                //Chicken[] farm = new Chicken[n];

                //double totalEggs = 0;

                //for (int i = 0; i < n; i++)
                //{
                //    string chickenName = Console.ReadLine();
                //    int chickenAge = int.Parse(Console.ReadLine());

                //    farm[i] = new Chicken(chickenName, chickenAge);

                //    totalEggs += farm[i].CalculateProductPerDay() * days;
                //}
                //Console.WriteLine($"Total eggs per days: {totalEggs}");



                // 4

                //Console.WriteLine("Enter n: ");
                //int n = int.Parse(Console.ReadLine());

                //Chicken[] farm = new Chicken[n];

                //double sum = 0;

                //for (int i = 0; i < n; i++)
                //{
                //    string chickenName = Console.ReadLine();
                //    int chickenAge = int.Parse(Console.ReadLine());

                //    farm[i] = new Chicken(chickenName, chickenAge);

                //    sum += farm[i].Age;
                //}

                //double average = sum / n;

                //Console.WriteLine($"{average:F2}");

                // 5

                //int n = int.Parse(Console.ReadLine());

                //Chicken[] farm = new Chicken[n];

                //for (int i = 0; i < n; i++)
                //{
                //    string chickenName = Console.ReadLine();
                //    int chickenAge = int.Parse(Console.ReadLine());

                //    farm[i] = new Chicken(chickenName, chickenAge);
                //}
                //string searchName = Console.ReadLine();

                //bool found = false;

                //foreach (Chicken ch in farm)
                //{
                //    if (ch.Name == searchName)
                //    {
                //        found = true;
                //        break;
                //    }
                //}

                //if (found)
                //{
                //    Console.WriteLine("Chicken found.");
                //}
                //else
                //{
                //    Console.WriteLine("Chicken not found.");
                //}

                // 6
                //string name = Console.ReadLine();
                //int age = int.Parse(Console.ReadLine());

                //Chicken chicken = new Chicken(name, age);

                //int newAge = int.Parse(Console.ReadLine());

                //chicken.Age = newAge;

                //Console.WriteLine(chicken);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}  