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


        protected int idProperty; //number for identification
        protected double value; //value in hypothetical currency 
        protected float area; //physical area measured in square meters
        protected string location; //address of given property
        protected float waterExpenses; //monthly outcome regarding water expenses
        protected float lightExpenses; //monthly outcome regarding light expenses
        protected float gasExpenses; //monthly outcome regarding gas expenses
        protected float incomes; //general monthly income
        protected float outcomes; //general monthly outcome
        protected float totalIncome; // total income counted since creating property object in program 
        protected float totalOutcome; //total outcome counter since creating property object in program


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

        public abstract void Status(); //overloaded function showing status of property
        

        
        
        public int getId()
        {
            return this.idProperty;
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

    
        
        
        









