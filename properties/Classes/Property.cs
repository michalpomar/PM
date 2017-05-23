using System;




namespace AbstractProperty
{


    abstract class Property
    {
        public enum Existence
        {
            no,
            yes
        }


        protected int idProperty;
        protected float value;
        protected float area;
        protected string location;
        protected float waterExpenses;
        protected float lightExpenses;
        protected float gasExpenses;
        protected float incomes;
        protected float outcomes;
        protected float totalIncome;
        protected float totalOutcome;


        protected Property()
        {
            idProperty = 0;
            value = 0;
            area = 0;
            location = "null";
            waterExpenses = 0;
            lightExpenses = 0;
            gasExpenses = 0;
            incomes = 0;
            outcomes = 0;
            totalIncome = 0;
            totalOutcome = 0;
        }


        protected Property(int id, float val, float ar, string loc, float we, float le, float ge, float inc, float outc)
        {
            idProperty = id;
            value = val;
            area = ar;
            location = loc;
            waterExpenses = we;
            lightExpenses = le;
            gasExpenses = ge;
            incomes = inc;
            outcomes = outc;
            totalIncome = inc;
            totalOutcome = outc;
        }

        



        public void ModifyProperty() //Edits existing information about property, overwrites data in database.
        {

        }

        public void DeleteProperty() //Removes information containing specified property from database, and not showing it anymore in the GUI.

        {

        }

        public void SearchProperty() //Allows to all the users to search a specific property taking in count some characteristics as : id, area, value, type, owner or administrator

        {

        }
    }

}

    
        
        
        









