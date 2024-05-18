using AätiKoK;

class Program
{
    private static void Main(string[] args)
    {
        Dejter dejter = new();
        string playerChoose = "0";
        bool dejt1 = true, dejt2 = true, dejt3 = true, dejt4 = true, dejt5 = true; 

        while (playerChoose != "6")
        {
            //Skriver ut menyn.
            Console.WriteLine("Välkomen till EoR Dejting.");
            Console.WriteLine("Välj en av de här personerna att gå på dejt med (Genom att skriva in rätt nummer som står vid deras namn). ");
            
            if(dejt1 == true)
                Console.WriteLine("1) Alicia Datura.");

            if (dejt2 == true)
                Console.WriteLine("2) Robert “Byggare” Bob Spärrskaft Jr.");

            if (dejt3 == true)
                Console.WriteLine("3) Svea Tove Åberg.");

            if (dejt4 == true)
                Console.WriteLine("4) Noah Knutsson.");

            if (dejt5 == true)
                Console.WriteLine("5) Eloise Vingarv.");
            
            Console.WriteLine("6) Avsluta.");

            if (dejt1 == false && dejt2 == false && dejt3 == false && dejt4 == false && dejt5 == false) //Går till en slut scene om du gått igenom alla dejter
            {
                End end = new();
                end.EndScene();
                playerChoose = "6";
            }
            else
            {
                playerChoose = Console.ReadLine();
            }

            Console.Clear();

            switch (playerChoose) // skriver ut dejt profilen på personen du valde. 
            {
                case "1":
                    if (dejt1 == true)
                    {
                        Console.WriteLine("Dejten är en kvinna som heter Alicia Datura, profilen säger att hon vill ha en partner som hon kan lita på som också litar på henne, hennes största hobby är att ta hand om hennes favoritblomma som är en Spikklubba. Hennes favoriträtt är kaktussallad. Hon jobbar bara kvällstid. 174 cm, långt rakt svart hår och smaragdgröna ögon.");
                        Console.WriteLine("");
                        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person."); // väljer om du vill gå på dejt med den här personen.

                        playerChoose = Console.ReadLine();

                        Console.Clear();

                        if (playerChoose == "1")
                        {
                            dejt1 = false;
                            dejter.Alicia();
                        }
                    }
                    break;

                case "2":
                    if (dejt2 == true)
                    {
                        Console.WriteLine("Dejten är en man som heter Robert “Byggare” Bob Spärrskaft Jr, profilen säger att han vill ha en aktiv partner som gillar byggarbete, hans största hobby är att laga saker. Han jobbar dagtid och har nästan ingen fritid så ni måste ha dejten under tiden han jobbar. Det står också att han bott i Bobsville, flyttade till Sunflower Valley och nu bor han i Fixham Harbour. Det står också att han älskar sin tvillingbror Tom “Djurälskare” Bob Spärrskaft. Robert 158 cm, flintis, bläck svarta ögon, går alltid runt med hård hatt och arbetskläder.\r\n");
                        Console.WriteLine("");
                        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person.");

                        playerChoose = Console.ReadLine();

                        Console.Clear();

                        if (playerChoose == "1")
                        {
                            dejt2 = false;
                            dejter.Robert();
                        }
                    }
                    break;

                case "3":
                    if (dejt3 == true)
                    {
                        Console.WriteLine("Dejten är en kvinna som heter Svea Tove Åberg, profilen säger att hon letar efter en lugn partner och att hon hatar våld. Hennes största hobby är att titta på romantiska filmer. Hon är arbetslös. Hon är 166 cm, har kort brunt hår och chokladbruna ögon.");
                        Console.WriteLine("");
                        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person.");

                        playerChoose = Console.ReadLine();

                        Console.Clear();

                        if (playerChoose == "1")
                        {
                            dejt3 = false;
                            dejter.Svea();
                        }
                    }
                    break;

                case "4":
                    if (dejt4 == true)
                    {
                        Console.WriteLine("Dejten är med en man som heter Noah Knutsson, profilen säger att han letar efter en partner som kan skydda honom från allt farligt i världen. Hans största hobby är att samla på vapen. Han jobbar dagtid på ett andra världskrigs museum. Det står också att han är väldigt lättskrämd. Han är 192 cm, kort blont hår med eld orangea ögon. \r\n");
                        Console.WriteLine("");
                        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person.");

                        playerChoose = Console.ReadLine();

                        Console.Clear();

                        if (playerChoose == "1")
                        {
                            dejt4 = false;
                            dejter.Noah();
                        }
                    }
                    break;

                case "5":
                    if (dejt5 == true)
                    {
                        Console.WriteLine("Dejten är med en kvinna som heter Eloise Vingarv, profilen säger att hon letar efter en partner som gillar att hitta på saker, spelar ingen roll vad det är. Hennes största hobby är bågskytte. Hon jobbar som advokat. Hon är 170 cm, har långt krulligt ljusbrunt hår och havs blåa ögon.\r\n");
                        Console.WriteLine("");
                        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person.");

                        playerChoose = Console.ReadLine();

                        Console.Clear();

                        if (playerChoose == "1")
                        {
                            dejt5 = false;
                            dejter.Eloise();
                        }
                    }
                    break;

                case "6":
                    Console.WriteLine("Programmet avslutas."); // stänger av programet/spelet.
                    return;

                default:
                    Console.WriteLine("Välj ett giltigt nummer."); // skrivs ut när du skriver in något som inte står.
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
            
    }
}