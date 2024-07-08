namespace Boost_L1
{
    public static class Lesson1
    {
        public static List<int> Task1(int n, int m )
        {
            List<string> digits = [];
            List<int> combinations = [];
            for(int i =1;i<n+1;i++)
            {
                digits.Add(i.ToString());
            }
            for(int i =(int)Math.Pow(10,m - 1);i < (int)Math.Pow(10,m);i++)
            {
                string a = i.ToString();
                foreach(string digit in digits)
                {
                    a = a.Replace(digit,"");
                }
                if(a == "")
                    combinations.Add(i);
            }
            return combinations;
        }
        public static bool Task2(string s)
        {
            if(s.Length != 16)
                return false;
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(i % 2 == 0)
                {
                    int digit = Convert.ToInt32(s[i]) * 2;
                    if(digit > 9)
                        digit -= 9;
                    sum += digit;
                }
                else
                {
                    sum += Convert.ToInt32(s[i]);
                }
            }
            if(sum % 10 == 0)
                return true;
            return false;
        }
        public static int Task3(int n,int f = 1)
        {
            f *= n;
            if((n-1) != 0)
            {
                n--;
                return Task3(n,f);
            }   
            return f;
        }
        public static (int max, int min) Task5(List<int> n)
        {
            int max = 0;
            int min = 0;

            n = n.Order().ToList();

            for(int i= n.Count -1 ;i > 0;i--)
            {
                max += n[i]; 
            }

            for(int i=0;i<n.Count - 1;i++)
            {
                min += n[i]; 
            }

            return (max ,min);
        }
    }
}