using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dejter
{
    string dejtVal;

    //Här är alla dejter och vad som kommer att hända i dem.
    public void Alicia()
    {
        Console.WriteLine("Dejten är en kvinna som heter Alicia Datura, profilen säger att hon vill ha en partner som hon kan lita på som också litar på henne, hennes största hobby är att ta hand om hennes favoritblomma som är en Spikklubba. Hennes favoriträtt är kaktussallad. Hon jobbar bara kvällstid. 174 cm, långt rakt svart hår och smaragdgröna ögon.");
        Console.WriteLine("");
        Console.WriteLine("1) Gå på dejt.\n2) Välj en annan person.");

        dejtVal = Console.ReadLine();

        Console.Clear();
        
        if(dejtVal == "1")
        {
            Console.WriteLine("Du får ett samtal.\nPersonen som ringer säger att någon som du möter under dejten kommer att försöka mörda dig." +
                "\n\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Du träffar Alicia i en park, ni går runt och pratar om blommor.");
            Console.WriteLine("1) Varför är spikklubba din favorit blomma?\n" +
                "2) Jag tycker inte om blommor så mycket.\n" +
                "3) Vad tycker du om country musik?");

            dejtVal = Console.ReadLine();
            Console.Clear();

            switch(dejtVal)
            {
                case "1":
                    Console.WriteLine("... för att... emmmm... den ser vaker ut.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "2":
                    Console.WriteLine("Nhä, jaja alla kan ju inte gilla blommor.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                    Console.WriteLine("Jag vet inte. Jag lyssnar inte så mycket på musik. Men det är säkert bra.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    break;
            }
            
            Console.WriteLine("Ni går till ett glasstånd för att beställa glass.\n" +
                "Du beställer chocklad glass, när du får din glass så tycker du att den ser lite för ljus ut.\n" +
                "1) Strid mot glass gubben.\n2) Byt glass med Alicia.");
            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Player player = new("Du", 10, 1, 3, 10);
                    Enemy GlassGubben = new("Glass Gubben", 10, 1, 3, 10, 4);
                    FIght fIght = new();

                    while (player.IsAlive == true && GlassGubben.IsAlive == true)
                    {
                        fIght.Battle(player, GlassGubben);
                        Console.ReadLine();
                    }
                    Console.Clear();

                    if (player.IsAlive == false)
                    {
                        return;
                    }
                    break;

                case "2":
                    Console.WriteLine("Du bytte glass med Alicia.\n" +
                    "Du dog av förgiftning.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    break;
            }
            Console.WriteLine("Alicia frågar dig en blom fråga.\n" +
                "Vilken blomma är det Sid i ice age äter i första filmen?");
            Console.WriteLine("1) Solros.\n" +
                "2) Pelragon.\n" +
                "3) Spikklubba.\n" +
                "4) Maskros.\n" +
                "5) Lejongap.");
            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("Det var ju synd, det var nästan rätt. Det är samma färg bara två olika blommor.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine("Nej det är inte rätt.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine("Jag vill ge dig rätt för den, men det är tyvärr fel.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("Japp det är helt rätt. Han säger ju: Åh en maskros måste vara säsongens sista.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("Det är helt fel. Det var faktiskt inte ens i närheten.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    break;
            }
            Console.WriteLine("Du och Alicia ser en person längre fram som planterar blommor. Alicia går fram till personen och börjar prata med henne.");
            Console.WriteLine("Vill du strida mot personen?\n" +
                "1) Ja.\n" +
                "2) Absolut.");
            Console.ReadLine();
            Console.Clear();

            Player player1 = new("Du", 10, 1, 3, 10);
            Enemy Blomtjejen = new("Blom Tjejen", 10, 1, 3, 10, 4);
            FIght fIght1 = new();

            while (player1.IsAlive == true && Blomtjejen.IsAlive == true)
            {
                fIght1.Battle(player1, Blomtjejen);
                Console.ReadLine();

            }
            Console.Clear();

            Console.WriteLine("Ni har nu kommit fram till resturangen som ni skulle till.\n" +
                "Vid ingången går Alicia in i en person. Hon ber dig att attackera personen.\n" +
                "1) Attackera personen som gick in i Alicia.\n" +
                "2) Attackera inte personen som gick in i Alicia.");
            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Player player2 = new("Du", 10, 1, 3, 10);
                    Enemy Mikael = new("Mikael", 10, 1, 2, 10, 5);
                    FIght fIght2 = new();

                    while (player2.IsAlive == true && Mikael.IsAlive == true)
                    {
                        fIght1.Battle(player2, Mikael);
                        Console.ReadLine();

                    }
                    Console.Clear();

                    Console.WriteLine("Alicia hade lagt ner en bit spikklubba i din kaktus salad så du dog.");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    return;

                case "2":
                    Console.WriteLine("Vad fan menar du NEJ?! JAG SKA DÖDA DIG!");
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();

                    Player player3 = new("Du", 10, 1, 3, 10);
                    Enemy Alicia = new("Alicia Datura", 10, 1, 3, 10, 2);
                    FIght fIght3 = new();

                    while (player3.IsAlive == true && Alicia.IsAlive == true)
                    {
                        fIght1.Battle(player3, Alicia);
                        Console.ReadLine();

                    }
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    break;
            }
            Console.WriteLine("Tack för att du inte attackerade mig. Jag heter Mikael. Jag skulle möta en person på dejt här men personen kom aldrig.");
            Console.WriteLine("Jag antar att du skulle på dejt med henne. Vill du fortsätta dejten med mig istället?\n" +
                "1) Ja.\n" +
                "2) Nej.");
            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("Du och Mikael gick på dejt istället och hade det välgit trevligt.");
                    return;
                case "2":
                    Console.WriteLine("Nähä... då får väll jag gå hem och programera istället.");
                    return;
            }

        }
        if(dejtVal == "2")
        {
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Välj ett giltigt nummer.");
        }
        /*
        Player player = new("Du", 10, 1, 3, 10);
        Enemy Alicia = new("Alicia", 10, 1, 3, 10, 4);
        FIght fIght = new();
        
        while (player.IsAlive == true && Alicia.IsAlive == true)
        {
            fIght.Battle(player, Alicia);
            Console.ReadLine();
        }
        Console.Clear();
        */
    }

    public void Robert()
    {
        Console.WriteLine("Dejten är en man som heter Robert “Byggare” Bob Spärrskaft Jr, profilen säger att han vill ha en aktiv partner som gillar byggarbete, hans största hobby är att laga saker. Han jobbar dagtid och har nästan ingen fritid så ni måste ha dejten under tiden han jobbar. Det står också att han bott i Bobsville, flyttade till Sunflower Valley och nu bor han i Fixham Harbour. Det står också att han älskar sin tvillingbror Tom “Djurälskare” Bob Spärrskaft. Robert 158 cm, flintis, bläck svarta ögon, går alltid runt med hård hatt och arbetskläder.\r\n");
    }

    public void Svea()
    {
        Console.WriteLine("Dejten är en kvinna som heter Svea Tove Åberg, profilen säger att hon letar efter en lugn partner och att hon hatar våld. Hennes största hobby är att titta på romantiska filmer. Hon är arbetslös. Hon är 166 cm, har kort brunt hår och chokladbruna ögon.");
    }

    public void Noah()
    {
        Console.WriteLine("Dejten är med en man som heter Noah Knutsson, profilen säger att han letar efter en partner som kan skydda honom från allt farligt i världen. Hans största hobby är att samla på vapen. Han jobbar dagtid på ett andra världskrigs museum. Det står också att han är väldigt lättskrämd. Han är 192 cm, kort blont hår med eld orangea ögon. \r\n");
    }

    public void Eloise()
    {
        Console.WriteLine("Dejten är med en kvinna som heter Eloise Vingarv, profilen säger att hon letar efter en partner som gillar att hitta på saker, spelar ingen roll vad det är. Hennes största hobby är bågskytte. Hon jobbar som advokat. Hon är 170 cm, har långt krulligt ljusbrunt hår och havs blåa ögon.\r\n");
    }
}

