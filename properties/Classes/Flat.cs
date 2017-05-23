using System;
using AbstractProperty;

namespace Flt
{
    class Flat : Property
    {
       private short garages;
       private short nrApartments;
       private short nrFloors;
       private bool elevator;

        public Flat() : base()
        {

        }

        public Flat(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc, short gr, short na, short nf, Existence el) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {
            garages = gr;
            nrApartments = na;
            nrFloors = nf;

            if (el == Existence.yes)
            {

                elevator = true;
            }
            else
            {
                elevator = false;
            }
        }

         ~Flat() { }
    }
}
