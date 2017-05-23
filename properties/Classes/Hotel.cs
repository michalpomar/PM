//need to adjust constructor to restaurant object

using System;
using AbstractProperty;
using Rstrnt;

namespace Htl
{
    class Hotel : Property
    {
        

        private Restaurant restaurant;
        private short nrRooms;
        private bool cafeteria;


        public Hotel() : base()
        {

        }

        public Hotel (int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc, short nr, Existence cf, Restaurant R) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {
            restaurant = R;
            nrRooms = nr;

            if (cf == Existence.yes)
            {
                cafeteria = true;
            }
            else
            {
                cafeteria = false;
            }
        }

        

        //constructor without restaurant
        public Hotel(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc, short nr, Existence cf) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {
            
            nrRooms = nr;

            if (cf == Existence.yes)
            {
                cafeteria = true;
            }
            else
            {
                cafeteria = false;
            }
        }



        ~Hotel() { }
    }
}
