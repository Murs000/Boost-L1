using BoostL3;

while (true)
{
    Console.WriteLine("Choose Option");
    Console.WriteLine("Write number of task:");
    int n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:15 8 4 13 10 11 7 3");
            string input1 = Console.ReadLine();
            var result1 = Lesson3.Task1(input1.Split().Select(int.Parse).ToArray());
            Console.WriteLine(string.Join(" ", result1));
            break;

        case 2:
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:6 13 8 1");
            string input2 = Console.ReadLine();
            var arr2 = input2.Split().Select(int.Parse).ToArray();
            if (Lesson3.Task2(arr2, out int[] subset1, out int[] subset2))
            {
                Console.WriteLine($"Subset 1: {string.Join(" ", subset1)}");
            Console.WriteLine($"Subset 2: {string.Join(" ", subset2)}");
            }
            else
            {
                Console.WriteLine("Partition not possible.");
            }
            break;

        case 3:
            Console.WriteLine("Write word1:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Write word2:");
            string word2 = Console.ReadLine();
            int result3 = Lesson3.Task3(word1, word2);
            Console.WriteLine($"Minimum Edit Distance: {result3}");
            break;

        case 4:
            Console.WriteLine("Write Distances Matrix:");
            Console.WriteLine("ex: 0 10 15 20 | 10 0 35 25 | 15 35 0 30 | 20 25 30 0");
            string input4 = Console.ReadLine();
            var inputs4 = input4.Split('|').Select(o => o.Trim()).ToArray();
            var distances = new int[inputs4.Length, inputs4[0].Split().Length];
            for (int i = 0; i < inputs4.Length; i++)
            {
                var inputss4row = inputs4[i].Split().Select(int.Parse).ToArray();
                for (int j = 0; j < inputss4row.Length; j++)
                {
                    distances[i, j] = inputss4row[j];
                }
            }
            int result4 = Lesson3.Task4(distances);
            Console.WriteLine($"Shortest Route Distance: {result4}");
            break;

        case 5:
            Console.WriteLine("Write string:");
            string s = Console.ReadLine();
            Console.WriteLine("Write dictionary words separated by space:");
            var wordDict = Console.ReadLine().Split().ToList();
            var result5 = Lesson3.Task5(s, wordDict);
            Console.WriteLine("Possible Sentences:");
            foreach (var sentence in result5)
            {
                Console.WriteLine(sentence);
            }
            break;

        default:
            Console.WriteLine($"There is no Task number {n}");
        break;
    }
}