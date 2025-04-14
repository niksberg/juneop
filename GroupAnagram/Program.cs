//GROUPING ANAGRAM PROBLEM - Medium Level

public class Solution_withSortion
{
    //{List of {String List}} would be the best Data Structure to store the grouped anagrams
    public List<List<string>> GroupAnagrams1(string[] strs) //strs contains the given ungrouped anagram list
    {
        var res1 = new Dictionary<string, List<string>>(); //Dictionary to store the sorted word as key and the list of anagrams containing same words as value
        foreach (var s in strs)
        {
            char[] charArray = s.ToCharArray(); //Converting String to Array to Sorting
            Array.Sort(charArray);
            string key = new string(charArray); //Sorted Word is Considered as Unique Key.
            if (!res.Contains(key))
            {
                res[key] = new List<string>(); //Sorted_Word -> List of Words in {strs} Contains the same letters
            }
            res[key].Add(s); //Add Original Word in the List
        }
        return res.Value.ToList<List<string>>(); //Return the List in a LIST through GroupAnagram
    }
}

public static void Main()
{
    string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
    Solution_withSortion solution = new Solution_withSortion();
    List<List<string>> result = solution.GroupAnagrams1(input);
    foreach (var group in result)
    {
        Console.WriteLine(string.Join(", ", group));
    }
}
