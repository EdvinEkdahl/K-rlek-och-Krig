class Program
{
    private static void Main(string[] args)
    {
        Dejter dejter = new();
        string playerChoose = "0";
        while (playerChoose != "6")
        {
            //Skriver ut menyn.
            Console.WriteLine("Välkomen till EoR Dejting.");
            Console.WriteLine("Välj en av de här personerna att gå på dejt med (Genom att skriva in rätt nummer som står vid deras namn). " +
                "\n1) Alicia Datura." +
                "\n2) Robert “Byggare” Bob Spärrskaft Jr." +
                "\n3) Svea Tove Åberg." +
                "\n4) Noah Knutsson." +
                "\n5) Eloise Vingarv." +
                "\n6) Avsluta.");
            playerChoose = Console.ReadLine();

            Console.Clear();

            switch (playerChoose)
            {
                case "1":
                    dejter.Alicia();
                    break;

                case "2":
                    dejter.Robert();
                    break;

                case "3":
                    dejter.Svea();
                    break;

                case "4":
                    dejter.Noah();
                    break;

                case "5":
                    dejter.Eloise();
                    break;

                case "6":
                    Console.WriteLine("Programmet avslutas.");
                    return;

                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    break;
            }
        }
            
    }
}