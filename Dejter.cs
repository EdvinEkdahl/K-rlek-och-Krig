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
        
        if(dejtVal == "1")
        {
            Console.WriteLine("Charizard");
        }
        if(dejtVal == "2")
        {
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Välj ett giltigt nummer. ");
        }
        
        //Test
        Player player = new("Rayan", 10, 1, 3, 10);
        Enemy Alicia = new("Alicia", 10, 1, 3, 10, 4);
        FIght fIght = new();
        
        while (player.IsAlive == true && Alicia.IsAlive == true)
        {
            fIght.Battle(player, Alicia);
            Console.ReadLine();
        }
        Console.Clear();
        //Test
        
        //Test
        Player player = new("Rayan", 10, 1, 3, 10);
        Enemy Alicia = new("Alicia", 10, 1, 3, 10, 4);
        FIght fIght = new();
        
        while (player.IsAlive == true && Alicia.IsAlive == true)
        {
            fIght.Battle(player, Alicia);
            Console.ReadLine();
        }
        Console.Clear();
        //Test
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

