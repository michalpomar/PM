//not included functions yet: add administrator, modify administrator, delete administrator, link admin to property, unlink admin from property, search administrator
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


//CHANGE

namespace Main_namespace
{

    
    class Program
    {

      


     



        static int Main()
        {
            List<Property> Properties = new List<Property>();
            Restaurant RestaurantMcRestaurantface = new Restaurant(2, 5000, 500, "rydzowa", 200, 300, 200, 1200, 700);
            Hotel Hilton = new Hotel(1, 9000, 250, "Traktorowa 42", 500, 700, 250, 5000, 2323, 15, Property.Existence.yes, RestaurantMcRestaurantface);

            

            





            Console.Read();
            return 0;
        }



    }

}