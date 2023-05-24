internal class Program
{
    private static void Main(string[] args)
    {
        List<Kifejezes> kifejezesek = File.ReadAllLines("kifejezesek.txt").Select(x => new Kifejezes(x)).ToList();

        Console.WriteLine($"2. feladat: Kifejezések száma: {kifejezesek.Count}");

        Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {kifejezesek.Count(x => x.Muvelet == "mod")}");

        if (kifejezesek.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0))
        {
            Console.WriteLine("4. feladat: Van ilyen kifejezés");
        }
        else
        {
            Console.WriteLine("4. feladat: Van ilyen kifejezés");
        }
    }
}