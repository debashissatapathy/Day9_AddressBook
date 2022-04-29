using System;

namespace AddressBook
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to AddressBook Program");

            CreateContact contact = new CreateContact();



            while (true)
            {
                Console.WriteLine("Enter the number :\n1)Create contact\n2)Edit Contact\n3)Delete contact\n4)Person Detail");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact.contacts();
                        break;
                    case 2:
                        contact.Edit_Contact();
                        break;
                    case 3:
                        contact.Delete_Contact();
                        break;
                    case 4:
                        contact.PersonDetail();
                        break;
                    default:
                        Console.WriteLine("Please provide proper detail from above option");
                        break;
                }


            }
        }
    }
}