using BoostL4;

while (true)
{
    Console.WriteLine("Choose Option");
    Console.WriteLine("Write number of task:");
    int n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("Write fraction in a/b format:");
            string fraction = Console.ReadLine();
            string result1 = Lesson4.Task1(fraction);
            Console.WriteLine($"Simplified Fraction: {result1}");
            break;

        case 2:
            Console.WriteLine("Write string to toggle case:");
            string input = Console.ReadLine();
            string result2 = Lesson4.Task2(input);
            Console.WriteLine($"Toggled Case: {result2}");
            break;

        default:
            Console.WriteLine($"There is no Task number {n}");
            break;
    }
}