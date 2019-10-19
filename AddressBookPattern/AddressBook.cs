using System;
using System.Collections.Generic;
using System.Text;
using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.AddressBookPattern
{
    class AddressBook 
    {
        DataStructure.Utility.UnOrderedList<Person> personDetail;

        public AddressBook(Utility.UnOrderedList<Person> personDetail)
        {
            this.personDetail = personDetail;
        }

        public AddressBook()
        {
            this.personDetail = new DataStructure.Utility.UnOrderedList<Person>();
        }
        public AddressBook(Person person)
        {
            this.personDetail = new DataStructure.Utility.UnOrderedList<Person>(person);
        }


        public void SortByLastName()
        {

        }
        public void SortByZip()
        {

        }
        public void Print()
        {

        }



    }
}
