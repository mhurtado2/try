using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        // In C#, a Dictionary is much like the objects that you used in JavaScript.
        //  They are collections of a key/value pairs - just strongly typed.
        Dictionary<string, Contact> Contacts = new();

//method
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
            // which does the same thing as this:
            // Contacts[contact.Email] = contact;
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email]; //why is email here written like an index
        }
    }
}