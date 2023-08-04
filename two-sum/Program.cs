TwoSum(new int[4] { 2, 7, 11, 15 }, 9);

int[] TwoSum(int[] nums, int target)
{
    var result = new int[2];
    var nums1 = nums;
    var first = 0;
    var second = 0;
    foreach (var num in nums)
    {
        first++;
        foreach (var num1 in nums1)
        {
            second++;
            WriteValues(result, nums1, target, first, second, num, num1);
            if (num + num1 == target)
            {
                result[0] = first;
                result[1] = second;
            }
        }
    }
    return result;
}

void WriteValues(int[] result, int[] nums1, int target, int first, int second, int num, int num1)
{
    var resultView = printArray(result);
    var nums1View = printArray(nums1);
    Console.WriteLine("result:", resultView);
    Console.WriteLine("nums1", nums1View);
    Console.WriteLine(target);
    Console.WriteLine(first);
    Console.WriteLine(second);
    Console.WriteLine(num);
    Console.WriteLine(num1);
}

void printArray(int[] array)
{
    var result = string.Empty;
    array.ToList().ForEach(i => Console.W(i.ToString()));
}