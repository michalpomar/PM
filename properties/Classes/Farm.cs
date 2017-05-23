using System;
using AbstractProperty;

namespace Frm
{
    class Farm : Property
    {

        public Farm() : base()
        {

        }


        public Farm(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {

        }

        ~Farm() { }
    }
}