public class LengthOfLongestSubstringSol {
    public int LengthOfLongestSubstring(string s) {
        string sub = "";
        int longest = 0;
        int index = 1;
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(sub);
            if (!sub.Contains(s[i]))
            {
                sub = sub + s[i];
                if (sub.Length == 1)
                {
                    index = i;
                }
            }
            else {
                if (longest < sub.Length)
                {
                    longest = sub.Length;
                    Console.WriteLine($"longest: {longest} => string: {sub}");
                }
                sub = "";
                Console.WriteLine($"Start Index = {index} => char: {s[index]} || Curent Index: {i}");
                i = index;
            }
        }

        if (longest < sub.Length)
        {
            longest = sub.Length;
        }

        return longest;
    }

    static void Main(string[] args)
    {
        LengthOfLongestSubstringSol i = new LengthOfLongestSubstringSol();
        var test = i.LengthOfLongestSubstring("dvdf");
        Console.WriteLine(test.ToString());
    }
}

