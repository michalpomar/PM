using System;
using AbstractProperty;

namespace Rstrnt
{
    class Restaurant : Property
    {


        public Restaurant() : base()
        {

        }


        public Restaurant(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {

        }

        ~Restaurant() { }
    }
}
