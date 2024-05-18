using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AätiKoK
{
    interface IEnd
    {
        void EndScene();
    }

    class End : IEnd
    {
        public void EndScene()
        {
            Console.Clear();
            Console.WriteLine("Grattis, du har nu upplevt alla dejter. Men vill du att ditt lilla äventyr ska sluta så här? Har du upplevt allt du villa uppleva?");
            Console.WriteLine("\nTRYCK PÅ ENTER FÖR ATT AVSLUTA.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
