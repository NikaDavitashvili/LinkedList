using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL_1
{
    //      1
    //  Interface - Abstract
    //Tanxebis dabrunebistvis -- decimal
    //C#-NET-&-FUN -- discord
    //interface -- dinamiuri programirebistvis, interfacit ver qmni obietqs, sheudzlia daavaldebulos shvilobili klasi konkretuli wesebit, sheudzlia kompleqsuri iyos: obieqtebis dabrunebit da a.s. tu xshirad xdeba base klasis shecvla interface gamoyeneba jobia. 
    //abstract -- ragac funqcias aqvs base implementacia anu tu rames ar dawer tavisit defaultad aqvs, abstractit ver qmni obieqts,  sheudzlia daavaldebulos shvilobili klasi konkretuli wesebit, gamoiyeneba dziritadad base klasis implementaciistvis da unda ganvsazgvrot ramdenad xshirad icvleba logika. am dros araa base gamoyeneba mizanshewonili.
    //this - mimdinare, base - mshoblis
    //IEnumerable -- sia romlis wevrebsac ver miwvdebi indeqsebit da aris readonly anu ver chaamateb,washli da a.s.
    //aris tipebi da generic-tipebi, romelic icvleba dinamiurad araa konkretuli, mag double, int an sxva ( List<T> )
    //where T : IWheelTable -- es generic T tipi daaimplementirebs im wesebis mixedvit romelic IWheelTable dan mouva
    //where T1 : Betting 
    //List -- dinamiuria da ar gaachnia winaswari raodenoba, amit gansxvavdeba Array -sgan
    //Ras gulisxmobs IEnumerator -i 
    //Rogor axerxebs list rom ase swrafi iyos da tan dinamiuri, qondes lists indeqsit wvdomadoba, amoshla washla, 
    
    //davaleba -- sheqvmnat List<> -is analogi tu shevdzlebt da qondes funqciebi : count, remove, indeqsit mimartva, add
    //amoxsna -- array -it sheidzleboda mara nelia radgan gadasxma xdeba axal array -shi
    //swori amoxsna -- klasi da reference, tito obieqts unda qonoda mimtitebeli shemdeg da wina obieqtze, anu winas eqneboda shemdegis misamarti ( Linked List )
    //List<T> klashi iqneba kidev erti klasi private ListItem (nested class) rata wvdoma gvqondes titoeul obieqtze
    //klasebi aketebs amas. solution daideba driveze.

    //      2
    //  Reflections
    //Mravari gamoyenebaa is, rom tu vinmes daaviwydeba klasis sheqmna tavisit daagenerirebs es.
    //prezentacia daideba, screenshots 
    //Using.System.Reflection gamodzaxeba
    //Assembly -- Leqsikoni, assembly aris .DLL an .EXE
    //Module -- zogadad erti assembly-is qvesh gvaq erti moduli, da gaachnia rogor avagebt modulic sheidzleba iyos .DLL
    //Types -- 
    //Member -- Funqciebi
    //Assembly.GetExecutingAssembly();  assembly-is gashveba

    //davaleba: araferi
    //shemdeg shexvedraze aq gavaketebt reflecionebze rame kods

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();
            Random numb = new Random();
            for(int i=0; i<10; i++)
            {
                int n = numb.Next(100);
                lst.Insert(n);
            }
            Console.WriteLine("\tList");
            lst.PrintInfo();

            Console.WriteLine("\n\tDelete operation");
            lst.Delete(74);
            lst.Delete(62);
            Console.WriteLine("\nList after Delete operation");
            lst.PrintInfo();

            Console.WriteLine("\tFind By Value operation");
            lst.FindByValue(42);
            lst.FindByValue(422);

            Console.WriteLine("\n\tFind By Index operation");
            lst.FindByIndex(11);
            lst.FindByIndex(2);

            Console.WriteLine("\n\tCount operation");
            lst.Count();

            Console.WriteLine();

        }
    }
}
