using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Dejter
{
    string dejtVal;
    string stridVal;

    //Här är alla dejter och vad som kommer att hända i dem.
    public void Alicia()
    {        
            Console.WriteLine("Du får ett samtal.\nPersonen som ringer säger att någon som du möter under dejten kommer att försöka mörda dig." +
                "\n\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
            Console.ReadLine();
            Console.Clear();

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
            {
                Console.WriteLine("Du träffar Alicia i en park, ni går runt och pratar om blommor.");
                Console.WriteLine("1) Varför är spikklubba din favorit blomma?\n" +
                    "2) Jag tycker inte om blommor så mycket.\n" +
                    "3) Vad tycker du om country musik?");

                dejtVal = Console.ReadLine();
                Console.Clear();

            switch (dejtVal)
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
                    Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
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
                            Console.WriteLine("Vad gör du?\n" +
                                "1) Block\n" +
                                "Allt annat) Attackera");
                            stridVal = Console.ReadLine();

                            if(stridVal == "1")
                            {
                                fIght.Block(player, GlassGubben);
                            }
                            else
                            {
                                fIght.Battle(player, GlassGubben);
                            }
                        }
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
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
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4" && dejtVal != "5")
            {
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
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
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
                Console.WriteLine("Vad gör du?\n" +
                    "1) Block\n" +
                    "Allt annat) Attackera");
                stridVal = Console.ReadLine();

                if (stridVal == "1")
                {
                    fIght1.Block(player1, Blomtjejen);
                }
                else
                {
                    fIght1.Battle(player1, Blomtjejen);
                }
            }
            Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
            Console.ReadLine();
            Console.Clear();

            if (player1.IsAlive == false)
            {
                return;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
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
                            Console.WriteLine("Vad gör du?\n" +
                                "1) Block\n" +
                                "Allt annat) Attackera");
                            stridVal = Console.ReadLine();

                            if (stridVal == "1")
                            {
                                fIght2.Block(player2, Mikael);
                            }
                            else
                            {
                                fIght2.Battle(player2, Mikael);
                            }
                        }
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();

                        if (player2.IsAlive == false)
                        {
                            return;
                        }

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
                            Console.WriteLine("Vad gör du?\n" +
                                "1) Block\n" +
                                "Allt annat) Attackera");
                            stridVal = Console.ReadLine();

                            if (stridVal == "1")
                            {
                                fIght3.Block(player3, Alicia);
                            }
                            else
                            {
                                fIght3.Battle(player3, Alicia);
                            }
                        }
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();

                        if (player3.IsAlive == false)
                        {
                            return;
                        }
                        break;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
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
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT AVSLUTA DEJT.");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    case "2":
                        Console.WriteLine("Nähä... då får väll jag gå hem och programera istället.");
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }

    public void Robert()
    {

    }

    public void Svea()
    {

    }

    public void Noah()
    {

    }

    public void Eloise()
    {

    }
}

