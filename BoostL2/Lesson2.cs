namespace BoostL2
{
    public static class Lesson2
    {
        public static int[] Task1(int[] arr)
        {
            var evens = new List<int>();
            for(int i=0;i<arr.Length;i++)
            {
                //proqram 0 dan sayir ona gore ! var
                if(!(i%2==0))
                {
                    evens.Add(arr[i]);
                }
            }
            evens.Sort();
            return evens.ToArray();
        }
        //Eyer bult in metodlarla deyil ozumuz yazmaliyiqsa bildirersiz zehmet olmasa
        public static bool Task2(string word)
        {
            if(word == word.Reverse().ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Task3(List<int> list)
        {
            return (list.Max() - 1) - (list.Min() +1);
        }
        public static int[,] Task4(int[,] arr)
        {
            int[,] newArr = new int[arr.GetLength(0),arr.GetLength(1)];
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    newArr[j,i] = arr[i,j];
                }
            }
            int[,] resultArr = new int[arr.GetLength(0),arr.GetLength(1)];

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j+=2)
                {
                    resultArr[i,j] = newArr[i,j+1];
                    resultArr[i,j+1] = newArr[i,j];
                }
            }
            return resultArr;
        }
    }
}