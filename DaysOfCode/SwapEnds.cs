namespace DaysOfCode
{
    public class SwapEnds
    {/// <summary>
    /// Given an integer array of at least length 2,
    /// swap the first and last elements.
    /// </summary>
    /// <param name="nums">the initial array</param>
    /// <returns>the modified array</returns>
        public int[] MakeSwappedArray(int[] nums)
        {
            int[] swapped = new int[nums.Length];
            swapped[0] = nums[nums.Length-1];
            swapped[swapped.Length-1] = nums[0];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                swapped[i] = nums[i];
            }
            return swapped;
        }

    }
}
