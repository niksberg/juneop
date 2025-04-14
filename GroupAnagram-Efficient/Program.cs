public class Solution
{
    //List of {String List} would be the best Data Structure to store the grouped anagrams
    public List<List<string>> GroupAnagrams(string[] strs) // strs contains the given ungrouped anagram list
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs) // Loop through each string in the input array
        {
            int[] count = new int[26]; // Array to count occurrences of each character (assuming lowercase a-z)
            foreach (char c in s) // Loop through each character in the string
            {
                count[c - 'a']++; // Increment the count for all aplhabets from a-z by 65 ASCI Value of 'a'
            }
            string key = string.Join(",", count); // Create a unique key based on the character counts
            if (!res.ContainsKey(key)) // Check if the key already exists in the dictionary
            {
                res[key] = new List<string>(); // If not, create a new list for this key
            }
            res[key].Add(s); // Add the original {string,s} to the list for this key
        }
        return res.Values.ToList<List<string>>(); // Return the grouped anagrams as a list of lists
    }
}

public static void Main()
{
    Solution s = new Solution();
    string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
    List<List<string>> result = s.GroupAnagrams(input);
    foreach (var group in result)
    {
        Console.WriteLine(string.Join(", ", group));
    }
}