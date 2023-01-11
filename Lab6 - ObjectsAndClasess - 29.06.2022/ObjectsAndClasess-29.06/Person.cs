using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasess_29._06
{
    internal class Person
    {
        private string firstName; //полета данни за този клас
        private string lastName;  //полета данни за този клас 



        //public string FirstName 
        //{ 
        //    get 

        //    {
        //      return firstName; //запис на property, трябва да има Private полета с public property
        //    }

        //    set 
        //    {
        //      lastName = value;
        //    }

        //} //property - публични неща
        //public string LastName  { get; set; }  //property - публични неща

        public string GetFirstName()
        { 
           return firstName;
        }

        public void SetFirstName(string value) 
        {
            if (value == "")
            {
                Console.WriteLine("You are lying!");
                return;
            }
        
            firstName = value;
        }

    }
}
