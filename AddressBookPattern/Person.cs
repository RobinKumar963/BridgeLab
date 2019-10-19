using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.AddressBookPattern
{
    class Person : IComparable
    {
        String firstName;
        String lastName;
        String address;
        String city;
        String state;
        String zip;
        String contact;

        public Person(string firstName, string lastName, string address, string city, string state, string zip, string contact)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.state = state ?? throw new ArgumentNullException(nameof(state));
            this.zip = zip ?? throw new ArgumentNullException(nameof(zip));
            this.contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public void UpdateAddrress(string address)
        {
            this.address = address;
        }
        public void UpdateCity(string city)
        {
            this.city = city;
        }
        public void UpdateState(string state)
        {
            this.state = state;
        }
        public void UpdateZip(string zip)
        {
            this.zip = zip;
        }
        public void UpdateContact(string contact)
        {
            this.contact = contact;
        }

    }
}
