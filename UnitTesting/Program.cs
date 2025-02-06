using UnitTesting.library;
internal class Program
{
    private static void Main(string[] args)
    {
    }

    public static void BerekenWeerstand()
    { 
        while (true)
        {
            Kleur ring1, ring2, ring3;
            ring1 = VraagRingKleur(1);
            ring2 = VraagRingKleur(2);
            ring3 = VraagRingKleur(3);

            double waarde = Weerstand.BerekenWeerstand(ring1, ring2, ring3);

            Console.WriteLine($"De waarde van deze weerstand bedraagt {waarde} ohm");
        }
    }
    
    /// <summary>
    /// Vraag de gebruiker om een kleurnaam in te geven voor een bepaalde ring
    /// </summary>
    /// <param name="nummer">het nummer van de ring</param>
    /// <returns></returns>
    public static Kleur VraagRingKleur(int nummer)
    {
        while (true)
        {
            try
            {
                Console.WriteLine($"Geef ring {nummer}");
                string ring = Console.ReadLine();
                Kleur resultaat = (Kleur)Enum.Parse(typeof(Kleur), ring);
                return resultaat;
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, deze kleur ken ik niet.");
            }
        }
    }
}