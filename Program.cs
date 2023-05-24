internal class Program
{
    static string[] szurtMuveletek = {"mod", "/", "div", "-", "*", "+"};

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

        Console.WriteLine("5. feladat: Sztatisztika");
        kifejezesek.Where(x => szurtMuveletek.Contains(x.Muvelet)).GroupBy(x => x.Muvelet).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()} db"));

        Console.Write("7. feladat: Kérek egy kifejezést: ");
        string be = Console.ReadLine();
        do
        {
            Console.WriteLine($"{be} = {Megold(new Kifejezes(be))}");
            Console.Write("7. feladat: Kérek egy kifejezést: ");
            be = Console.ReadLine();
        } while (be != "vége");

        File.WriteAllLines("eredmenyek.txt", kifejezesek.Select(x => $"{x.ElsoOperandus} {x.Muvelet} {x.MasodikOperandus} = {Megold(x)}"));
    }

    public static string Megold(Kifejezes kifejezes)
    {
        try
        {
            switch (kifejezes.Muvelet)
            {
                case "mod":
                    return Convert.ToString(kifejezes.ElsoOperandus % kifejezes.MasodikOperandus);
                case "/":
                    return Convert.ToString(Convert.ToDouble(kifejezes.ElsoOperandus) / kifejezes.MasodikOperandus);
                case "div":
                    return Convert.ToString(kifejezes.ElsoOperandus / kifejezes.MasodikOperandus);
                case "-":
                    return Convert.ToString(kifejezes.ElsoOperandus - kifejezes.MasodikOperandus);
                case "*":
                    return Convert.ToString(kifejezes.ElsoOperandus * kifejezes.MasodikOperandus);
                case "+":
                    return Convert.ToString(kifejezes.ElsoOperandus + kifejezes.MasodikOperandus);
                default:
                    return "Hibás operátor";
            }
        }
        catch
        {
            return "Egyéb hiba";
        }
    }
}