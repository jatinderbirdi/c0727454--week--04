using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0723381_WEEK_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Launch();
        }
    }

    class Village
    {
        // Node is an ADT
        // what KIND of DATA do we need in a nood?
        public Village nextVillage;
        public Village previousVillage;
        public String VillageName;
        public bool isAstrildeHere = false;

    }
    class Countryside
    {
        Village Maple = new Village();

        Village Toronto = new Village();

        Village Ajax = new Village();
        Village First;
        Village Last;
        Village Temp;


        public void Launch()
        {
            Village Temp;
            First = Maple;
            Last = Ajax;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.nextVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = Toronto;

            Console.WriteLine(this.displayMap());
            Console.ReadLine();


        }
        public string displayMap()
        {
            string listOfCities = "";
            // we need to print all the cities


            listOfCities = listOfCities + First.VillageName;
            Temp = First.nextVillage;
            listOfCities = listOfCities + Temp.VillageName;


            return listOfCities;
        }



    }
}


