// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> Elves = new List<int>();
int elf = 0;

foreach (string line in File.ReadLines(@"J:\aoc\aoc22\01\elves.txt"))
{
    if (!string.IsNullOrEmpty(line))
    {
        elf += int.Parse(line);
    }
    else
    {
        Elves.Add(elf);
        elf = 0;
    }
}
Elves.Sort();
Elves.Reverse();
Console.WriteLine(Elves.Max());

Console.WriteLine($"Most cals carried by elf: {Elves[0]}");

int top3 = 0;
for (int i = 0; i < 3; i++)
{
    top3 += Elves[i];
}
Console.WriteLine($"Top 3 calorie elves: {top3}");
