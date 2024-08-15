namespace BoostL3
{
    public static class Lesson3
    {
        public static int[] Task1(int[] arr)
{
    if (arr.Length <= 1)
        return arr;

    int mid = arr.Length / 2;
    int[] left = arr.Take(mid).ToArray();
    int[] right = arr.Skip(mid).ToArray();

    return Merge(Task1(left), Task1(right));
}

private static int[] Merge(int[] left, int[] right)
{
    int[] result = new int[left.Length + right.Length];
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            result[k++] = left[i++];
        else
            result[k++] = right[j++];
    }

    while (i < left.Length)
        result[k++] = left[i++];

    while (j < right.Length)
        result[k++] = right[j++];

    return result;
}
        public static bool Task2(int[] arr, out int[] subset1, out int[] subset2)
{
    int totalSum = arr.Sum();
    subset1 = new int[0];
    subset2 = new int[0];

    if (totalSum % 2 != 0)
        return false;

    int halfSum = totalSum / 2;
    bool[] dp = new bool[halfSum + 1];
    dp[0] = true;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = halfSum; j >= arr[i]; j--)
        {
            dp[j] |= dp[j - arr[i]];
        }
    }

    if (!dp[halfSum])
        return false;

    List<int> s1 = new List<int>();
    List<int> s2 = new List<int>(arr);

    int remainingSum = halfSum;
    for (int i = arr.Length - 1; i >= 0 && remainingSum > 0; i--)
    {
        if (remainingSum >= arr[i] && dp[remainingSum - arr[i]])
        {
            s1.Add(arr[i]);
            s2.Remove(arr[i]);
            remainingSum -= arr[i];
        }
    }

    subset1 = s1.ToArray();
    subset2 = s2.ToArray();
    return true;
}
        public static int Task3(string word1, string word2)
{
    int m = word1.Length;
    int n = word2.Length;
    int[,] dp = new int[m + 1, n + 1];

    for (int i = 0; i <= m; i++)
        dp[i, 0] = i;

    for (int j = 0; j <= n; j++)
        dp[0, j] = j;

    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (word1[i - 1] == word2[j - 1])
                dp[i, j] = dp[i - 1, j - 1];
            else
                dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i, j - 1], dp[i - 1, j])) + 1;
        }
    }

    return dp[m, n];
}
        public static int Task4(int[,] distances)
{
    int n = distances.GetLength(0);
    int VISITED_ALL = (1 << n) - 1;
    int[,] dp = new int[n, 1 << n];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < (1 << n); j++)
            dp[i, j] = -1;

    return TSP(0, 1, distances, dp, VISITED_ALL);
}

private static int TSP(int pos, int mask, int[,] dist, int[,] dp, int VISITED_ALL)
{
    if (mask == VISITED_ALL)
        return dist[pos, 0];

    if (dp[pos, mask] != -1)
        return dp[pos, mask];

    int ans = int.MaxValue;

    for (int city = 0; city < dist.GetLength(0); city++)
    {
        if ((mask & (1 << city)) == 0)
        {
            int newAns = dist[pos, city] + TSP(city, mask | (1 << city), dist, dp, VISITED_ALL);
            ans = Math.Min(ans, newAns);
        }
    }

    return dp[pos, mask] = ans;
}
        public static IList<string> Task5(string s, IList<string> wordDict)
{
    Dictionary<string, IList<string>> memo = new Dictionary<string, IList<string>>();
    return WordBreak(s, new HashSet<string>(wordDict), memo);
}

private static IList<string> WordBreak(string s, HashSet<string> wordDict, Dictionary<string, IList<string>> memo)
{
    if (memo.ContainsKey(s))
        return memo[s];

    IList<string> result = new List<string>();

    if (wordDict.Contains(s))
        result.Add(s);

    for (int i = 1; i < s.Length; i++)
    {
        string word = s.Substring(i);
        if (wordDict.Contains(word))
        {
            IList<string> subList = WordBreak(s.Substring(0, i), wordDict, memo);
            foreach (string sub in subList)
            {
                result.Add(sub + " " + word);
            }
        }
    }

    memo[s] = result;
    return result;
}
    }
}