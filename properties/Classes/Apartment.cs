using System;
using AbstractProperty;

namespace Aprtmnt 
{
    class Apartment : Property 
    {
        private short floor;
        private short nrRooms;
        private short nrBathrooms;
        private bool balcony;
        private bool garage;


        public Apartment() : base()
        {

        }

        public Apartment(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc, short fl, short nr, short nb, Existence bal, Existence gr) : base (id, val, ar, loc, we, le, ge, inc, outc)
        {
            

            floor = fl;
            nrRooms = nr;
            nrBathrooms = nb;

            if (bal == Existence.yes)
            {

                balcony = true;
            }
            else
            {
                balcony = false;
            }

            if(gr == Existence.yes)
            {
                garage = true;
            }
            else
            {
                garage = false;
            }
        }

        ~Apartment() { }
    }
}
