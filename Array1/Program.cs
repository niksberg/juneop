Console.WriteLine("Hello, World!");
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i * 10;
}
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("Enter a number to search:");
int searchNumber = int.Parse(Console.ReadLine());
bool found = false;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine($"Number {searchNumber} found in the array.");
}
else
{
    Console.WriteLine($"Number {searchNumber} not found in the array.");
}