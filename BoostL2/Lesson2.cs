namespace BoostL2
{
    public static class Lesson2
    {
        public static int[] Task1(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if( i%2!=0 && j%2!=0)
                    {
                        if(arr[i]<arr[j])
                        {
                            int c = arr[i];
                            arr[i] = arr[j];
                            arr[j] = c;
                        }
                    }
                }
            }

            return arr;
        }
        //Eyer bult in metodlarla deyil ozumuz yazmaliyiqsa bildirersiz zehmet olmasa
        public static bool Task2(string word)
        {
            var wordReverseArr = word.Reverse().ToArray();
            string wordReverse =  "";
            foreach(var w in wordReverseArr)
            {
                wordReverse += w;
            }
            if(word == wordReverse)
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
            var max = list.Max() - 1;
            var min = list.Min() +1;
            return max - min;
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