using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class EditContact
    {
        List<ContactPerson> People = new List<ContactPerson>();


        
        public void Edit_Contact()
        {
            Console.WriteLine("Enter person name for edit");
            string name = Console.ReadLine();
            foreach(var data in People)
            {
                if(data.FirstName == name )
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
                else if(data.FirstName == null)
                {
                    Console.WriteLine("Given data {0} is not available in Address Book. Try Again!", name);
                }


            }

            
        }
        
            
        

        
    }
}