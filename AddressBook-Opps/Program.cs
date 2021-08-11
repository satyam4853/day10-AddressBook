using System;

namespace AddressBook_Opps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome to AddressBook problem------------");
            while (true)
            {

                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressBookDetails.AddMember();
                        break;
                    case 2:
                        AddressBookDetails.ViewContacts();
                        break;
                    case 3:
                        AddressBookDetails.EditDetails();
                        break;
                    case 4:
                        AddressBookDetails.DeleteDetails();
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
