public class TwoSumSol {
    public int[] TwoSum(int[] nums, int target) {
        var resultDict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (resultDict.TryGetValue(target - nums[i], out int index))
            {
                return new [] { index, i };
            }
            resultDict[nums[i]] = i;
        }


        return new int[]{};
    }

    static void Main(string[] args)
    {
        TwoSumSol i = new TwoSumSol();
        
        int target = 9;
        int[] nums = {2, 7, 11, 15};

        var test = i.TwoSum(nums, target);
        Console.WriteLine($"{test[0]}, {test[1]}");
    }
}
