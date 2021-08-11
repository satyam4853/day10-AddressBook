using AddressBook_Opps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookDetails
    {

        private List<Person> contacts;
        //address book dictioanry to store values
        private static Dictionary<string, List<Person>> addressBookDictionary = new Dictionary<string, List<Person>>();
        public void AddMember()
        {
            string addressBookName;
            contacts = new List<Person>();
            while (true)
            {
                Console.WriteLine("Enter The Name of the Address Book");
                addressBookName = Console.ReadLine();
                //Checking uniqueness of address books
                if (addressBookDictionary.Count > 0)
                {
                    if (addressBookDictionary.ContainsKey(addressBookName))
                    {
                        Console.WriteLine("This name of address book already exists");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write("Enter Number of contacts you want to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)
            {
                //object for person class
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.lastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                person.address = Console.ReadLine();
                Console.Write("Enter City: ");
                person.city = Console.ReadLine();
                Console.Write("Enter State: ");
                person.state = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                person.zipCode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                double phNo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                contacts.Add(person);
                Console.WriteLine("***************************************");
                numOfContacts--;
            }
            //adding into address book dictionary
            addressBookDictionary.Add(addressBookName, contacts);
            Console.WriteLine("\t \t \tSuccessfully Added");
        }

        //method for view Contacts
        public void ViewContacts()
        {
            if (addressBookDictionary.Count > 0)
            {
                //printing the values in address book
                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    Console.WriteLine($"\t \t \t{dict.Key}");
                    foreach (var addressBook in dict.Value)
                    {
                        PrintValues(addressBook);

                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }

        //Printing values
        public static void PrintValues(Person x)
        {
            Console.WriteLine($"First Name : {x.firstName}");
            Console.WriteLine($"Last Name : {x.lastName}");
            Console.WriteLine($"Address : {x.address}");
            Console.WriteLine($"City : {x.city}");
            Console.WriteLine($"State : {x.state}");
            Console.WriteLine($"Zip Code: {x.zipCode}");
            Console.WriteLine($"Phone Number: {x.phoneNumber}");
            Console.WriteLine($"Email: {x.email}");
        }

        //method for editing details
        public void EditDetails()
        {
            int f;//flag variable
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (editName.ToLower() == x.firstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.firstName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.lastName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.address = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.city = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.state = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.zipCode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 7:

                                    Console.Write("Enter new Phone Number: ");
                                    double phNo = Convert.ToDouble(Console.ReadLine());
                                    break;
                                case 8:

                                    Console.Write("Enter new Email-id: ");
                                    string emailId = Console.ReadLine();
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Exited");
                                    f = 1;
                                    break;

                            }
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }

        //method for deleting conatcts
        public void DeleteDetails()
        {
            int f = 0;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (deleteName.ToLower() == x.firstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("\t \t \t DELETED");
                        Console.WriteLine($"You have deleted {x.firstName} contact");
                        contacts.Remove(x);
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.WriteLine("The name you have entered not in the address book");
                }

            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
    }
}