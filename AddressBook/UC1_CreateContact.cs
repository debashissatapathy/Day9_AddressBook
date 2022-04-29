using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class CreateContact
    {
        List<ContactPerson> People = new List<ContactPerson>();

        public void contacts()
        {
            ContactPerson contact = new ContactPerson();
            Console.WriteLine("Enter person contact detail\n");
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter Zip : ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("\n");
            People.Add(contact);

        }
        public void Edit_Contact()
        {
            Console.WriteLine("Enter person name for edit");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("choose the option for edit data: \n1. FirstName \n2. LastName \n3. Email \n4. PhoneNumber \n5. Address \n6. City \n7. State \n8.Zip");
                    int choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Please enter your FirstName");
                            string firstName = Console.ReadLine();
                            data.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter your LastName");
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Email");
                            string email = Console.ReadLine();
                            data.Email = email;
                            break;
                        case 4:
                            Console.WriteLine("Please enter your PhoneNumber");
                            string phoneNumber = Console.ReadLine();
                            data.PhoneNumber = phoneNumber;
                            break;
                        case 5:
                            Console.WriteLine("Please enter your Address");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 6:
                            Console.WriteLine("Please enter your City");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 7:
                            Console.WriteLine("Please enter your State");
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 8:
                            Console.WriteLine("Please enter your Zip");
                            string zip = Console.ReadLine();
                            data.Zip = zip;
                            break;
                        default:
                            Console.WriteLine("Given input {0} is incorrect, select from above option", name);
                            break;
                    }
                }
                else if (data.FirstName == null)
                {
                    Console.WriteLine("Given data {0} is not available in Address Book. Try Again!", name);
                }


            }
           

        }
        public void Delete_Contact()
        {
            Console.WriteLine("Enter person name to remove from Address book");
            string name = Console.ReadLine();
            

            
                foreach (var data in People)
                {
                    if (People.Contains(data))
                    {
                        if (data.FirstName == name)
                        {
                            Console.WriteLine("Given person contact is exist.");
                            People.Remove(data);
                            Console.WriteLine("Contact deleted successfully.");
                            return;
                        }
                    }                        
                }
                Console.WriteLine("Given name contact doesn't exist");
           
        }
        public void PersonDetail()
        {
            foreach (var data in People)
            {
                Console.WriteLine("Name of person: " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email Id: " + data.Email);
                Console.WriteLine("Contact Number: " + data.PhoneNumber);
                Console.WriteLine("Address: " + "At: " +data.Address + " City: " + data.City + " State: " + data.State + "-" + data.Zip); ;
            }
                
        }
    }
}
  