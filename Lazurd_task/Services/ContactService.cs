using System;
using Lazurd_task.Models;

namespace Lazurd_task.Services
{
        public class ContactService
        {
            private List<Contact> contacts = new List<Contact>();

            public ContactService()
            {
                contacts.Add(new Contact { Id = 1, FirstName = "Marwa", LastName = "Alahdab", Email = "marwa@example.com", PhoneNumber = "1234567890" });
                contacts.Add(new Contact { Id = 2, FirstName = "Eman", LastName = "Naem", Email = "jane@example.com", PhoneNumber = "9876543210" });
            }

            public List<Contact> GetAllContacts()
            {
                return contacts;
            }

            public Contact GetContactById(int id)
            {
                return contacts.FirstOrDefault(c => c.Id == id);
            }

            public void AddContact(Contact contact)
            {
                contact.Id = contacts.Count > 0 ? contacts.Max(c => c.Id) + 1 : 1;
                contacts.Add(contact);
            }

            public void UpdateContact(Contact contact)
            {
                var existingContact = contacts.FirstOrDefault(c => c.Id == contact.Id);
                if (existingContact != null)
                {
                    existingContact.FirstName = contact.FirstName;
                    existingContact.LastName = contact.LastName;
                    existingContact.Email = contact.Email;
                    existingContact.PhoneNumber = contact.PhoneNumber;
                }
            }

            public void DeleteContact(int id)
            {
                var contactToRemove = contacts.FirstOrDefault(c => c.Id == id);
                if (contactToRemove != null)
                {
                    contacts.Remove(contactToRemove);
                }
            }
        }
    }