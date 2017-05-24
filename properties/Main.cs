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
using Artificial_database;




namespace Main_namespace
{

    
    class Program
    {


        static int Main()
        {

            //Console.WriteLine(DummyClass.Properties[2].getId()); //accessed through the static database




            for ( int i = 0; i < DummyClass.Properties.Count; i++)
            {
                DummyClass.Properties[i].Status();
                Console.WriteLine("\n");
            }







            Console.Read();
            return 0;
        }



    }

}