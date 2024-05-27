using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Dejter
{
    string dejtVal;
    FIght fIght = new();

    //Här är alla dejter och vad som kommer att hända i dem.
    public void Alicia() // startar när du startar dejtem med Alicia
    {        
        Console.WriteLine("Du får ett samtal.\nPersonen som ringer säger att någon som du möter under dejten kommer att försöka mörda dig.");
        Continue();

        dejtVal = "";
        while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3") // stänger av while loopen när man skriver in 1, 2 eller 3.
        {
            Console.WriteLine("Du träffar Alicia i en park, ni går runt och pratar om blommor.");
            Console.WriteLine("1) Varför är spikklubba din favorit blomma?\n" +
                "2) Jag tycker inte om blommor så mycket.\n" +
                "3) Vad tycker du om country musik?");
            
            dejtVal = Console.ReadLine(); // läser av vad spelaren har valt för något.
            Console.Clear(); // rensar all text som har ståt tidigare så att man inte tappar bort sig lika enkelt

            switch (dejtVal)
            {
                case "1": // startar om spelaren skriver in 1
                    Console.WriteLine("... för att... emmmm... den ser vaker ut.");
                    Continue();
                    break;

                case "2": // startar om spelaren skriver in 2
                    Console.WriteLine("Nhä, jaja alla kan ju inte gilla blommor.");
                    Continue();
                    break;

                case "3": // startar om spelaren skriver in 3
                    Console.WriteLine("Jag vet inte. Jag lyssnar inte så mycket på musik. Men det är säkert bra.");
                    Continue();
                    break;

                default: // startar om spelaren skriver in något som inte är nummren som är skrivna
                    Console.WriteLine("Välj ett giltigt nummer.");
                    Continue();
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
                    case "1": // startar en fight encounter
                        Player player = new("Du", 10, 1, 3, 10);
                        Enemy GlassGubben = new("Glass Gubben", 10, 1, 3, 10, 4);
                        if (fIght.Fight(player, GlassGubben) == false)
                        {
                            return;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Du bytte glass med Alicia.\n" +
                        "Du dog av förgiftning.");
                        Continue();
                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
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
                        Continue();
                        break;
                    case "2":
                        Console.WriteLine("Nej det är inte rätt.");
                        Continue();
                        break;
                    case "3":
                        Console.WriteLine("Jag vill ge dig rätt för den, men det är tyvärr fel.");
                        Continue();
                        break;
                    case "4":
                        Console.WriteLine("Japp det är helt rätt. Han säger ju: Åh en maskros måste vara säsongens sista.");
                        Continue();
                        break;
                    case "5":
                        Console.WriteLine("Det är helt fel. Det var faktiskt inte ens i närheten.");
                        Continue();
                        break;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
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
            if (fIght.Fight(player1, Blomtjejen) == false)
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
                        if (fIght.Fight(player2, Mikael) == false)
                        {
                            return;
                        }

                        Console.WriteLine("Alicia hade lagt ner en bit spikklubba i din kaktus salad så du dog.");
                        Continue();
                        return;

                    case "2":
                        Console.WriteLine("Vad fan menar du NEJ?! JAG SKA DÖDA DIG!");
                        Continue();

                        Player player3 = new("Du", 10, 1, 3, 10);
                        Enemy Alicia = new("Alicia Datura", 10, 1, 3, 10, 2);
                        if (fIght.Fight(player3, Alicia) == false)
                        {
                            return;
                        }
                        break;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
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
                        Continue();
                        return;
                    case "2":
                        Console.WriteLine("Nähä... då får väll jag gå hem och programera istället.");
                        Continue();
                        return;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }
        }
    }

    public void Robert() // startar när du startar dejten med Robert
    {
        dejtVal = "";
        while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
        {
            Console.WriteLine("Du träffar Robert på hans jobb. Du frågar Robert :");
            Console.WriteLine("1) Varför håller ni på att rensa bort skogen?\n" +
                "2) Varför kommer det sig att du har flyttat så många gånger?.\n" +
                "3) Vad tycker du om programmering?");

            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("Snälla kalla mig Byggare Bob istället det gör alla andra. Vi håller på att bygga ett parkeringshus.");
                    Continue();
                    break;

                case "2":
                    Console.WriteLine("Snälla kalla mig Byggare Bob istället det gör alla andra. Jag har aldrig rikitgt hittat ett ställe som passar mig, tills att jag flyttade hit.Det här stället är väldigt fint.");
                    Continue();
                    break;

                case "3":
                    Console.WriteLine("Jag kan inte svara på den frågan. Jag har aldrig hållt på med det. Men snälla kalla mig Byggare Bob istället det gör alla andra.");
                    Continue();
                    break;

                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    Continue();
                    break;
            }


            Console.WriteLine("Du och Byggare Bob går runt och plockar upp alla pinnar som faller ner från träden som de håller på att såga ner." +
                "\nMen helt plötsligt så hör du ett stort brak och när du kollar upp ser du att det kommer en stor trä stock rullande mot dig.");
            Continue();
            Player player = new("Du", 10, 1, 3, 10);
            Enemy TräStock = new("Trä Stock", 5, 10, 10, 5, 6);
            if (fIght.Fight(player, TräStock) == false)
            {
                return;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4" && dejtVal != "5")
            {
                Console.WriteLine("Byggare Bob springer fram till dig och frågar om du är okej.");
                Console.WriteLine("1) Jag mår bra.\n" +
                    "2) Jag har varit bättre.\n" +
                    "3) Det där var väldigt intressant.\n" +
                    "4) Den där hade kunnat döda mig!\n" +
                    "5) Jag ser ut att vara intackt.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Det Var ju tur.");
                        Continue();
                        break;
                    case "2":
                        Console.WriteLine("Det för står jag.");
                        Continue();
                        break;
                    case "3":
                        Console.WriteLine("Ja det var en upplevelse och du ser ut att må bra ut.");
                        Continue();
                        break;
                    case "4":
                        Console.WriteLine("Jag vet men den gjorde inte det ellerhur.");
                        Continue();
                        break;
                    case "5":
                        Console.WriteLine("Det var ju tur. Jag vill ju inte att min första arbetsplats olycka är när jag är på dejt.");
                        Continue();
                        break;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            Console.WriteLine("Du och Byggare Bob fortsätter med att plocka upp grenar i några timmar till. Efter ett tag så börjar en massa personer samlas runt bygget." +
                "Till slut så står det 10 personer där, det är miljöaktivister allihopa. De börjar demonstrera för att de gillar inte att ni hugger ner träden.");
            Console.WriteLine("Du inser att det finns bara en väg ut ur det här. Du behöver strida mot alla.");
            Continue();

            

            for (int i = 1; i < 10; i++) 
            {
                Player player1 = new("Du", 10, 1, 3, 10);
                Enemy Miljöaktivist = new("Miljöaktivist", 10, 1, 3, 10, 4);
                if (fIght.Fight(player1, Miljöaktivist) == false)
                {
                    return;
                }
                Console.WriteLine(i + "/10 besegrade.");
                Continue();
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Nu när du har besegrat alla miljöaktivister så kommer deras ledare fram. Deras ledare är Tom “Djurälskare” Bob Spärrskaft.\n" +
            "Vill du strida mot honom?\n" +
            "1) Ja.\n" +
            "2) Nej.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Player player11 = new("Du", 10, 1, 3, 10);
                        Enemy Tom = new("Tom “Djurälskare” Bob Spärrskaft", 10, 3, 5, 10, 1);
                        if (fIght.Fight(player11, Tom) == false)
                        {
                            return;
                        }
                        return;

                    case "2":
                        Console.WriteLine("Byggare Bob går fram till sin tvilling bror Tom och ber honom att sluta med det här." +
                            "Tom går med på det och båda två går iväg mot solnedgången och lämnar dig.");
                        Continue();

                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }
        }
    }

public void Svea() // startar när du startar dejten med Svea
    {
        Console.WriteLine("Du ringer till en fin resturang och bokar ett bord åt dig och Svea.");
        Continue();

        dejtVal = "";
        while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
        {
            Console.WriteLine("Du träffar Svea på resturangen. Ni sätter er vid erat bord och pratar medans ni väntar på en servitör.");
            Console.WriteLine("1) Varför gillar du romantiska filmer så mycket?\n" +
                "2) Jag tycker inte om romantiska filmer. Dem är ganska dåliga.\n" +
                "3) Vad tycker du om Metal Gear Solid spelen?");

            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("För att jag älskar kärlek och lite drama också.");
                    Continue();
                    break;

                case "2":
                    Console.WriteLine("VA!?!? TYCKER DU INTE OM ROMANTISKA FILMER!! DEN HÄR DEJTEN ÄR ÖVER.");
                    Continue();
                    return;

                case "3":
                    Console.WriteLine("Nae fy fy. Det är alldeles för mycket våld i dem spelen.");
                    Continue();
                    break;

                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    Continue();
                    break;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4")
            {
                Console.WriteLine("En manlig servitris kommer fram och tar eran beställning. Du tycker att han kollar lite för länge på Svea.\n" +
                    "När servitisen har gått måste du komma på en ursäkt för att lämna bordet.\n" +
                    "1) “Jag måste gå på toa.”\n" +
                    "2) “Jag måste bara gå och slå ner våran servitris för att han kollade lite för länge på dig.”\n" +
                    "3) “Jag kom på att jag behöver ringa ett samtal idag.”\n" +
                    "4) Säg inget.");

                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Du lämnar bordet och hittar eran servitris. Du attackerar honom.");
                        Continue();

                        Player player = new("Du", 10, 1, 3, 10);
                        Enemy Servitrisen = new("Servitrisen", 10, 1, 2, 10, 6);
                        if (fIght.Fight(player, Servitrisen) == false)
                        {
                            return;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Svea gillar inte våld så hon går ut från resturangen och dejten är över.");
                        Continue();
                        return;

                    case "3":
                        Console.WriteLine("Svea förstår att du behöver göra det. Du lämnar bordet letar upp servitrisen och attackerar honom.");
                        Continue();

                        Player player1 = new("Du", 10, 1, 3, 10);
                        Enemy Servitrisen1 = new("Servitrisen", 10, 1, 2, 10, 6);
                        if (fIght.Fight(player1, Servitrisen1) == false)
                        {
                            return;
                        }
                        break;

                    case "4":
                        Console.WriteLine("Svea undrade vart du gick så hon följde med och såg att du attackerade servitrisen. Hon sprang ut ur resturangen och dejten avslutades.");
                        Continue();
                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4" && dejtVal != "5")
            {
                Console.WriteLine("När du kommer tillbaka till bordet så fortsätter ni att prata.\n" +
                    "Efter ett tag kommer samma servitris fram med era drickor och du tycker fortfarande att han kollar på Svea lite för länge.\n" +
                    "Efter att han har gått måste du komma på en ursäkt att lämna bordet igen.");
                Console.WriteLine("1) “Jag måste gå på toa.”\n" +
                    "2) Säg inget.\n" +
                    "3) “Oj någon ramlade där borta, jag ska gå och hjälpa den personen.”\n" +
                    "4) “Jag ska bara gå och slå den där servitrisen för att han kollade för länge på dig.”\n" +
                    "5) Spill din dricka över dig.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Svea förstår. Alla behöver ju gå på toa. När du har lämnat bordet så letar du upp servitrisen och attackerar han.");
                        Continue();

                        Player player2 = new("Du", 10, 1, 3, 10);
                        Enemy Servitrisen2 = new("Servitrisen", 10, 1, 2, 10, 6);
                        if (fIght.Fight(player2, Servitrisen2) == false)
                        {
                            return;
                        }
                        break;
                        
                    case "2":
                        Console.WriteLine("Hon undrade vart du tog vägen någon stans så hon letade upp dig och såg att du attackerade servitrisen. Hon gick fram och gav dig en ör fil. Dejten är över.");
                        Continue();
                        return;
                    case "3":
                        Console.WriteLine("Svea tycker att du är jätte snäll som är villig att hjälpa en person som du inte känner. När du länat bordet letar du upp servitrisen och attackerar honom.");
                        Continue();

                        Player player3 = new("Du", 10, 1, 3, 10);
                        Enemy Servitrisen3 = new("Servitrisen", 10, 1, 2, 10, 6);
                        if (fIght.Fight(player3, Servitrisen3) == false)
                        {
                            return;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Svea började gråta och sprang ut från resturangen. Dejten är över.");
                        Continue();
                        return;
                    case "5":
                        Console.WriteLine("Du spillde din dricka över dig. Svea gick med dig bort till köket för att fråga om en disktrasa.\n" +
                            "När ni kommer fram så kommer servitrisen och slår dig. Svea ger honom en ör fil och undrar vad för typ av resturang det här är.\n" +
                            "Ni går hem till henne beställer pizza och kollar på en romantisk film. Du klarade dejten.");
                        Continue();
                        return;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Du kommer tillbaka och fortsätter prata med Svea.\nSAMMA servitris kommer fram till er med eran mat. Du tycker att han pratar lite väl mycket med Svea.");
                Console.WriteLine("Vill du strida mot servitören?\n" +
                    "1) Ja.\n" +
                    "2) Nej, Svea gillar inte våld så jag följer efter honom och slås mot honom när hon inte ser.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Svea börjar skrika på dig. Dejten är över. Svea blev ihop med servitrisen efter att han berättat allt som hände.");
                        Continue();
                        return;

                    case "2":
                        Console.WriteLine("Svea följde efter dig utan att du viste det och såg när du attackerade servitrisen. Hon gick fram gav dig en ör fil.\n" +
                            "Du misslyckades med dejten. Svea blev ihop med servitrisen istället.");
                        Continue();
                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }
        }
}

    public void Noah() // startar när du startar dejten med Noah
    {
        dejtVal = "";
        while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
        {
            Console.WriteLine("Du och Noah är inne i spökhuset. Ni kommer in i första rummet. Det är lite blinkande lampor lite pumpor, spindel nät och en gigantisk ekorre.");
            Console.WriteLine("1) Du går rakt igenom utan att bry dig för du är inte rädd för sådant här.\n" +
                "2) Du slår den gigantiska ekorren.\n" +
                "3) Du låter Noah gå först.");

            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("Du går igenom utan problem, men Noah blir så rädd att han höll på att kissa på sig.");
                    Continue();
                    break;

                case "2":
                    Console.WriteLine("Ekorren var gjord av metall. Du fick väldigt ont i handen.");
                    Continue();
                    break;

                case "3":
                    Console.WriteLine("Noah blir inte glad med att du gjorde det här. Han blundar och försöker springa igenom rummet. Men han springer rakt in i ekorren.");
                    Continue();
                    break;

                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    Continue();
                    break;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Ni kommer in i nästa rum. Rummet är runt och när ni kommer in i mitten på rummet så stängs dörren ni kom in ignom.\n" +
                    "1) Stå still och se vad som händer.\n2) Var berädd att skydda Noah för vad som helst.");

                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Det kom en kort person klädd som en zombie ut från en av dörrarna. Han gick rakt förbi er och öppnade en annan dörr. Ni gick också ut genom samma dörr.");
                        Continue();
                        break;

                    case "2":
                        Console.WriteLine("Du berädde dig själv på vad som helst. En kort person utklädd till Zombie kom ut genom en dörr. Du attackerar honom.");
                        Continue();

                        Player player = new("Du", 10, 1, 3, 10);
                        Enemy Zombie = new("Zombie Skådespelaren", 10, 1, 3, 10, 4);
                        if (fIght.Fight(player, Zombie) == false)
                        {
                            return;
                        }
                        break;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4")
            {
                Console.WriteLine("Ni kommer in i nästa rum, nej det är inget rum det är en lång korridor med en massa dörrar på sidorna.");
                Console.WriteLine("1) Spring rakt igenom.\n" +
                    "2) Vänd om.\n" +
                    "3) Säg till Noah att gå först.\n" +
                    "4) Var berädd på att slå allt och alla som kommer ut genom dörrarna.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Ni sprang rakt igenom korridoren. Men när ni kom fram så stog det en ordnings vakt där som sa att man inte fick springa där inne.\n " +
                            "Ni blev utkastade och dejten misslyckades.");
                        Continue();
                        return;
                    case "2":
                        Console.WriteLine("Nej vända om går ju inte att göra. Ni gick igeom korridoren och ingenting hände.");
                        Continue();
                        break;
                    case "3":
                        Console.WriteLine("Noah blir skit sur och säger att han inte vill dejta mer. Dejten misslyckades.");
                        Continue();
                        return;
                    case "4":
                        Console.WriteLine("Du är berädd att slå allt och alla som kommer upp i korridoren. Men när ni har gått ignom den så var det inget som hände.\n" +
                            "Förutom att du såg ut som en idiot.");
                        Continue();
                        break;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            Console.WriteLine("Du och Noah blir tvugna att vänta lite pågrund av något fel som hade hänt lite längre fram.");
            Continue();

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Ni har nu kommit fram till sista rummet. Det ser ut som ett helt vanligt sov rum. Det finns ett fönster som Noah börjar gå upp till." +
                    "\n1) Låt Noah gå upp till fönstret och kolla ut." +
                    "\n2) Låt honom inte göra det.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Noah gick upp och kollad ut genom fönstret. Men det var inget vanligt fönster utan det var ett fake fönster och helt " +
                            "plötsligt så döck dett up en person bakom föntret och Noah blev så rädd att han fick en hjärt attack så han dog." +
                            "Dejten misslyckades.");
                        Continue();
                        return;

                    case "2":
                        Console.WriteLine("Noah gillade inte att han inte fick kolla ut genom föntret så han gick ut och sa att dejten var över. Du misslyckades med dejten.");
                        Continue();
                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }
        }
    }
    public void Eloise() // startar när du startar dejten med Eloise
    {
        Console.WriteLine("Du och Eloise bestämmer er för att gå till ett andra världskirgs museum som ingen av er har varit på.");

        dejtVal = "";
        while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
        {
            Console.WriteLine("Ni träffas på museumet och ni börjar gå runt. Eloise frågar dig vad din favorit bil är för något.");
            Console.WriteLine("1) Ferrari.\n" +
                "2) Audi.\n" +
                "3) Pontiac.");

            dejtVal = Console.ReadLine();
            Console.Clear();

            switch (dejtVal)
            {
                case "1":
                    Console.WriteLine("Ferrari? Verkligen? Den är väll okej antar jag.");
                    Continue();
                    break;

                case "2":
                    Console.WriteLine("Nae usch AUDI? Vet du vad... den här dejten är över. Du misslyckades med dejten.");
                    Continue();
                    return;

                case "3":
                    Console.WriteLine("Nu jävlar. Nu snackar vi bra bilar. Firebirden är så jäkla sexig.");
                    Continue();
                    break;

                default:
                    Console.WriteLine("Välj ett giltigt nummer.");
                    Continue();
                    break;
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3" && dejtVal != "4" && dejtVal != "5")
            {
                Console.WriteLine("Ni går runt och fortsätter prata. Du berättar att du gillar bågskytte och hon frågar dig vilken klass som är din favorit.\n" +
                    "1) Barebow.\n" +
                    "2) Recurve.\n" +
                    "3) Traditionel.\n" +
                    "4) Compound.\n" +
                    "5) Långbåge.");

                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("BB. Basic Bitch.");
                        Continue();
                        break;

                    case "2":
                        Console.WriteLine("Nae det är ju sämre än barebow och långbåge.");
                        Continue();
                        break;

                    case "3":
                        Console.WriteLine("Där det där är den bästa utav alla finns inget som slår den.");
                        Continue();
                        break;

                    case "4":
                        Console.WriteLine("Okej compund är ju näst bäst iallafall.");
                        Continue();
                        break;

                    case "5":
                        Console.WriteLine("Hej då. Du misslyckades med dejten.");
                        Continue();
                        return;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Du ser en person som försöker ta ner ett utav vapnena som hänger på väggen i museumet.");
                Console.WriteLine("1) Attackera personen.\n" +
                    "2) Gå fram och konfrontera personen.");
                    
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Du attackerade personen. Han är väldigt förvånad.");
                        Continue();

                        Player player = new("Du", 10, 1, 3, 10);
                        Enemy Noah = new("Noah Knutsson", 10, 1, 2, 10, 5);
                        if (fIght.Fight(player, Noah) == false)
                        {
                            return;
                        }
                        break;
                    case "2":
                        Console.WriteLine("han blev skit rädd tappade vapnet och sprang där ifrån. Du hängde upp det igen.");
                        Continue();
                        break;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2" && dejtVal != "3")
            {
                Console.WriteLine("Ni går runt där inne lite till innan ni känner er färdiga.\n" +
                    "1) Fråga vad som har varit det bästa med dejten.\n" +
                    "2) “Samlar mina tankar i ensamhet innan jag går ut. Trodde jag va' smart när jag gjorde slut ah. Längtar efter dig och nu står jag här utanför din dörr. När jag nu ringer på öppnar du då eller vill du att jag ska gå. Så jag ber dig kom ut till mig. Eloise är vi mer än bara vänner. Så visa vad du känner och sen får känslorna bestämma. Eloise även vindarna kan vända för mig är du den enda. Vår kärlek den är värd ett högre pris Eloise”\n" +
                    "3) Fortsätt med att små prata om allt möjligt.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Det bästa var när vi såg han som försökte sno ett vapen och du stoppade honom.");
                        Continue();
                        break;

                    case "2":
                        Console.WriteLine("Jag har väntat på att någon ska sjunga den på en dejt med mig. Du klarade dejten.");
                        Continue();
                        return;

                    case "3":
                        Console.WriteLine("Ni fortsatte att små prata.");
                        Continue();
                        break;

                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }

            dejtVal = "";
            while (dejtVal != "1" && dejtVal != "2")
            {
                Console.WriteLine("Ni känner er färdiga och går ut från museumet. När ni kommer ut blir ni mötta av en massa poliser som står och säger till er att ge upp." +
                    "\nEloise säger åt dig att ni borde springa.\n" +
                    "1) Spring iväg med Eloise.\n" +
                    "2) Ge upp till polisen.");
                dejtVal = Console.ReadLine();
                Console.Clear();

                switch (dejtVal)
                {
                    case "1":
                        Console.WriteLine("Du och Eloise sprang iväg och kom undan. Du klarade dejten.");
                        Continue();
                        return;
                    case "2":
                        Console.WriteLine("Du gav upp till polisen och Eloise sprang iväg. Du hamnade i fängelse. Du misslyckades med dejten.");
                        Continue();
                        return;
                    default:
                        Console.WriteLine("Välj ett giltigt nummer.");
                        Continue();
                        break;
                }
            }
        }
    }

    public void Continue()
    {
        Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT FORTSÄTTA.");
        Console.ReadLine();
        Console.Clear();
    }
}