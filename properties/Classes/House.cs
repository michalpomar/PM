//Single family house

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

        public override void Status()
        {
            Console.WriteLine(" House \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10}  ", this.idProperty, this.value, this.area, this.location, this.waterExpenses, this.lightExpenses, this.gasExpenses, this.incomes, this.outcomes, this.totalIncome, this.totalOutcome);
        }
       
    }
}