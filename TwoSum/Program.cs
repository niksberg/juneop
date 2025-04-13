//Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.

//Return the answer with the smaller index first.Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> result = new Dictionary<int, int>(); 
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (result.ContainsKey(diff))
            {
                return new int[] { result[diff], i };
            }
            result[nums[i]] = i;
        }
        return null;
    }
}

// HOW I SOLVED //

// 1. I created a dictionary to store the numbers and their indices.
// 2. I looped through the array and calculated the difference between the target and the current number.
// 3. I checked if the difference is already in the dictionary.
// 5. If not, I added the current number and its index to the dictionary.
// 4. If it is, I returned the Dictionary with diff which would give me the index aswell as the current index.
