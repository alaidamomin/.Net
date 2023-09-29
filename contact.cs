using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string MobileNumber { get; set; }

    public Contact(string name, string mobileNumber)
    {
        Name = name;
        MobileNumber = mobileNumber;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nMobile Number: {MobileNumber}";
    }
}

class ContactBook
{
    private List<Contact> contacts;

    public ContactBook()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully!");
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Contact book is empty.");
        }
        else
        {
            Console.WriteLine("Contacts in the contact book:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ContactBook contactBook = new ContactBook();

        while (true)
        {
            Console.WriteLine("Contact Book Menu:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Mobile Number: ");
                        string mobileNumber = Console.ReadLine();
                        Contact newContact = new Contact(name, mobileNumber);
                        contactBook.AddContact(newContact);
                        break;
                    case 2:
                        contactBook.DisplayContacts();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
    }
}