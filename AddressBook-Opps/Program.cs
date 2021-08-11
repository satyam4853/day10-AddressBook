using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t \t \t Welcome to the Address Book Program");
            AddressBookDetails Add = new AddressBookDetails();

            while (true)
            {


                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Add.AddMember();
                        break;
                    case 2:
                        Add.ViewContacts();
                        break;
                    case 3:
                        Add.EditDetails();
                        break;
                    case 4:
                        Add.DeleteDetails();
                        break;
                    case 5:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }

            }
        }
    }
}