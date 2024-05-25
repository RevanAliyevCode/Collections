using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTask
{
    public class PhoneBook
    {
        Dictionary<string, string> Contacts { get; } = [];
        
        public void AddContact(string key, string value)
        {
            if (Contacts.ContainsKey(key))
            {
                Console.WriteLine("There is contact with this name");
            }
            else Contacts.Add(key, value);
        }

        public void RemoveContact(string key)
        {
            if (Contacts.ContainsKey(key)) Contacts.Remove(key);
            else Console.WriteLine("There is no such a contact");
        }

        public void GetAllContacts()
        {
            foreach (var kvp in Contacts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public string? FindByConactName(string conactName)
        {
            if (Contacts.ContainsKey(conactName)) return Contacts[conactName];
            else return null;
        }
    }
}
