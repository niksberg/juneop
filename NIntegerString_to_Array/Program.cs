class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        int odd = 0, even = 0;
        int[] numArray = inputString.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
        foreach (int n in numArray)
        {
            if (n % 2 == 0)
            {
                even += n;
            }
            else
            {
                odd += n;
            }
        }
        Console.WriteLine($"{odd} {even}");
    }
    Console.ReadLine();
}