using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LECTURE ======================================================");
        Address test1Address = new Address("The Hexagon", "North Pole", "Jupiter");
        Lecture test1 = new Lecture("Autoassimilation and You", "Love Lectures? Hate Lectures? Indifferent Either Way? You don't get a choice, all citizens of Earth will attend mandatory 35 hour lecture sessions explaining Earth's new adoption into the intergalactic federation, or face total planet destruction", "3-30-2026", "1:00 PM", test1Address, "Lecture", "Intergalactic Federation Chief Assimilation Officer Vorrun Phaarkul", 800000000);
        Console.WriteLine("\n\n\n" +test1.GetFullDetails());
        Console.WriteLine("\n" + test1.GetStandardDetails());
        Console.WriteLine("\n" + test1.GetShortDescription());

        Console.WriteLine("RECEPTION ======================================================");
        Address receptionAddress = new Address("The Hexagon", "North Pole", "Jupiter");
        Reception reception = new Reception("Intergalactic Sovereignty Celebration", "Celebrate the Earth's victorius defiance to the extraterrestrial Intergalactic Federation's autoassimilation program. This reception is to honor the fearless world leaders who bravely told the leaders of the Intergalactic Federation that the Earth would remain a Sovereign entity, and would not allow any foreign entities to claim it as their territory.\nThere's No Possible Way This Could Have Any Negative Effects!", "3-31-2026", "13:00 PM", receptionAddress, "Reception", "example@gmail.com");
        Console.WriteLine("\n\n\n" +reception.GetFullDetails());
        Console.WriteLine("\n" + reception.GetStandardDetails());
        Console.WriteLine("\n" + reception.GetShortDescription());

        Console.WriteLine("OUTDOORS ======================================================");
        Address outdoorAddress = new Address("", "", "Earth");
        Outdoor outdoor = new Outdoor("History Ends Today", "\nwell that backfired\n\nTurns out the Intergalactic Federation was not bluffing. In response to the Earth's defiance, they will be ending all biological processes in our little corner of the universe, and then selling the remnants of our planet for parts. Come out and enjoy what little time we have left as a species, children and families welcome! The sun will be shining, not a cloud in the sky... until Federation weapons fire, and it won't matter whether you're outdoors or not. Think of it like front row seats to a spectacular fireworks show!", "4-1-2026", "00:00 PM", outdoorAddress, "Outdoors", "Planet Destroying Weaponry");
        Console.WriteLine("\n\n\n" + outdoor.GetFullDetails());
        Console.WriteLine("\n" + outdoor.GetStandardDetails());
        Console.WriteLine("\n" + outdoor.GetShortDescription());

    }
}