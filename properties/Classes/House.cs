using System;
using AbstractProperty;

namespace Hs
{
    class House : Property
    {

        public House() : base()
        {

        }

        public House(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc) : base(id, val, ar, loc, we, le, ge, inc, outc)
        {

        }

        ~House() { }
    }
}