//not included functions yet: add administrator, modify administrator, delete administrator, link admin to property, unlink admin from property, search administrator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artificial_database;




namespace Main_namespace
{

    
    class Program
    {


        static int Main()
        {

            //Console.WriteLine(DummyClass.Properties[2].getId()); //accessed through the static database


            //DummyClass.Properties.Remove(DummyClass.Properties[2]);

            //for (int i = 0; i < DummyClass.Properties.Count; i++)
            //{
            //    DummyClass.Properties[i].Status();
            //    Console.WriteLine("\n");
            //}


            //if(DummyClass.Properties[0].GetType() == typeof(Rstrnt.Restaurant))
            //{
            //    Console.WriteLine("To jest restauracja");
            //}


            // DummyClass.SearchProperty("Hilton");

            DummyClass.AddProperty();




            Console.Read();
            return 0;
        }



    }

}