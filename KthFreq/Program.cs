public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        //nums: the input array
        //k: the number of top frequent elements to return

        //Step 1: Create a Dictionary "count" to store the frequency of each element.
        // Create Dynamic ArrayList "freq" to store the elements based on their frequency Index.

        Dictionary<int, int> count = new Dictionary<int nums, int k>();

        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }
        //Step 2: Iterate through n in nums array and count freq "count" Dictionary<int, int>

        foreach (int n in nums)
        {
            if (count.ContainsKey(n))
            {
                count[n]++;
            }
            else
            {
                count[n] = 1;
            }
        }

        // Step 3: Transfering Data From Dictionary to Array List.
        foreach (var entry in count)
        {
            freq[entry.Value].Add(entry.Key);  //freq[frequency] = value
        }

        //Step 4: Return the the Kth Top Frequent Elements
        int[] res = new int[k]; //new Array to Return the Kth Top Frequent Elements
        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--)
        {
            foreach (int n in freq[i]) //Accessing the freq arraylist.
            {
                res[index++] = n;

                //res[0] = 1st Top Frequent Element
                //res[1] = 2nd Top Frequent Element

                if (index == k)  //res[2] is satisfied
                {                
                    return res; 
                }
            }
        }
        return res;
    }
}