public class Kifejezes {
    int elsoOperandus;
    string muvelet;
    int masodikOperandus;

    public Kifejezes(string sor)
    {
        string[] mezok = sor.Split(' ');
        this.elsoOperandus = Convert.ToInt32(mezok[0]);
        this.muvelet = mezok[1];
        this.masodikOperandus = Convert.ToInt32(mezok[2]);
    }

    public Kifejezes(int elsoOperandus, string muvelet, int masodikOperandus)
    {
        this.elsoOperandus = elsoOperandus;
        this.muvelet = muvelet;
        this.masodikOperandus = masodikOperandus;
    }

    public int ElsoOperandus { get => elsoOperandus;}
    public string Muvelet { get => muvelet;}
    public int MasodikOperandus { get => masodikOperandus;}
}