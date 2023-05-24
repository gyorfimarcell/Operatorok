internal class Program
{
    private static void Main(string[] args)
    {
        List<Kifejezes> kifejezesek = File.ReadAllLines("kifejezesek.txt").Select(x => new Kifejezes(x)).ToList();

        Console.WriteLine($"2. feladat: Kifejezések száma: {kifejezesek.Count}");
    }
}