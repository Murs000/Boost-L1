using BoostL1;

while (true){
    Console.WriteLine("Choose Option");
    Console.WriteLine("Write number of task");
    int n = Convert.ToInt32(Console.ReadLine());
    switch(n)
    {
        case 1:
            Console.WriteLine("Write Number of Digits :");
            int digits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Lengh of Combination :");
            int lengh = Convert.ToInt32(Console.ReadLine());
            List<int> combinations = Lesson2.Task1(digits,lengh);
            foreach(int conbin in combinations)
            {
                Console.Write(conbin + " ");
            }Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Write Card Number:");
            Console.WriteLine("ex:4111 1111 1111 1111");
            string cardNumber = Console.ReadLine() ?? "";
            cardNumber = cardNumber.Replace(" ","");
            if (Lesson1.Task2(cardNumber))
            {
                Console.WriteLine("Valid Card Number");
            }
            else
            {
                Console.WriteLine("Not Valid Card Number");
            }
            break;
        case 3: 
            Console.WriteLine("Write Number:");
            Console.WriteLine(Lesson1.Task3(Convert.ToInt32(Console.ReadLine())));
            break;
        case 5:
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:5 6 45 1 7");
            string inputNumbers = Console.ReadLine()  ?? "";
            if(inputNumbers == "")
            {
                Console.WriteLine("Bad Input");
                break;
            }   
            string[] inputs = inputNumbers.Split();
            List<int> numbers = [];
            foreach(string element in inputs)
            {
                numbers.Add(Convert.ToInt32(element));
            }
            Console.WriteLine("max = "+Lesson1.Task5(numbers).max);
            Console.WriteLine("min = "+Lesson1.Task5(numbers).min);
            break;
        default:
            Console.WriteLine($"There is no Task number {n}");
            break;
    }
}