// See https://aka.ms/new-console-template for more information

using PhoneTask;

PhoneBook phoneBook = new();

phoneBook.AddContact("Revan", "0503824649");
phoneBook.AddContact("Anar", "0506188731");
phoneBook.AddContact("Anar", "0506188731");

phoneBook.GetAllContacts();