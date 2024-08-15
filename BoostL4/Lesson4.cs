namespace BoostL4
{
    public static class Lesson4
    {
        public static string Task1(string fraction)
        {
            string[] parts = fraction.Split('/');
            int numerator = int.Parse(parts[0]);
            int denominator = int.Parse(parts[1]);

            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            return $"{numerator}/{denominator}";
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static string Task2(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsUpper(c))
                    result[i] = char.ToLower(c);
                else if (char.IsLower(c))
                    result[i] = char.ToUpper(c);
                else
                    result[i] = c; // Leave other characters unchanged
            }
            return new string(result);
        }
    }
}