using System.Runtime.Intrinsics.Arm;
using BoostL2;

while(true){
    Console.WriteLine("Choose Option");
    Console.WriteLine("Write number of task:");
    int n = Convert.ToInt32(Console.ReadLine());
    switch(n)
    {
        case 1:
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:7 4 2 9 12 1 2");
            string input1 = Console.ReadLine();
            var result1 = Lesson2.Task1(input1.Split().Select(int.Parse).ToArray());
            foreach(var resuslt in result1)
            {
                Console.Write(resuslt+" ");
            }
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Write word:");
            Console.WriteLine(Lesson2.Task2(Console.ReadLine()));
            break;
        case 3: 
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:1 45 23 42 67 98 2");
            string input3 = Console.ReadLine();
            var result3 = Lesson2.Task3(input3.Split().Select(int.Parse).ToList());
            Console.WriteLine(result3);
            break;
        case 4:
            Console.WriteLine("Write Numbers:");
            Console.WriteLine("ex:1 2 3 4 | 5 6 7 8 | 9 10 11 12 | 13 14 15 16");
            string input4 = Console.ReadLine();
            var inputs4 = input4.Split('|').Select(o=> o.Trim()).ToArray();
            var inputsss4 = new int[inputs4.Length,inputs4[0].Split().Length];
            for(int i=0; i<inputs4.Length; i++)
            {
                var inputss4row = inputs4[i].Split().Select(int.Parse).ToArray();
                for(int j=0;j<inputss4row.Length;j++)
                {
                    inputsss4[i,j] = inputss4row[j];
                }
            }
            var result = Lesson2.Task4(inputsss4);
            for(int i=0;i<result.GetLength(0);i++)
            {
                for(int j=0;j<result.GetLength(1);j++)
                {
                    Console.Write(result[i,j]+" ");
                }Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine($"There is no Task number {n}");
            break;
    }
}