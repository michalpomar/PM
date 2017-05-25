using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractProperty;
using Hs;
using Frm;
using Aprtmnt;
using Rstrnt;
using Htl;
using Flt;



namespace Artificial_database
{


    static class DummyClass //static means that you do not create any instances of the class on your own.

    {
        static private Restaurant Gessler = new Restaurant( "Gessler",5000, 500, "Nowomiejska, Warszawa", 200, 300, 200, 1200, 700);
        static private Hotel Hilton = new Hotel( "Hilton",9000, 250, "Drewnowska 36, Lodz", 500, 700, 250, 5000, 2323, 15, Property.Existence.yes, Gessler);
        static private Apartment Penthouse = new Apartment("Penthouse", 1500000, 300,"Mostowa 42, Poznan", 400, 400, 400, 1600, 1350, 1, 3, 1,Property.Existence.yes, Property.Existence.yes);
        static private Farm McDonald = new Farm("McDonald", 30000, 1500, "Hektarowa 4, Nieznajdowy Duze", 650, 300, 250, 3500, 1410);
        static private House Gregory = new House("Gregory", 1600485, 150, "Baker Street, London", 300, 300, 300, 0, 1000);
        static private Flat Ataner = new Flat("Ataner", 20000000, 5000, "Marcelinska 96, Poznan", 2000, 2300, 1337, 25000, 12500, 22, 45, 5, Property.Existence.yes);
        


      static public List<Property> Properties = new List<Property>() { Gessler, Hilton, Penthouse, McDonald, Gregory, Ataner };



       static public void SearchProperty(string propName)
        {
            bool found = false;
            for(int i = 0; i < Properties.Count(); i++)
            {
                if (Properties[i].getName() == propName)
                {
                    Properties[i].Status();
                    found = true;
                }                   
            }
            
            if(!found)
            {
                Console.WriteLine("Property was not found");
            }
        }


        static public void AddProperty()
        {

        }





    }
}
