using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DeleteContacts
    {
        List<ContactPerson> People = new List<ContactPerson>();


        
        public void Delete_Contact()
        {
            Console.WriteLine("Enter person name to remove from Address book");
            string name = Console.ReadLine();
            foreach(var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("Given person contact is exist.");
                    People.Remove(data);
                    Console.WriteLine("Contact deleted successfully.");
                }
                else
                    Console.WriteLine("Given name contact doesn't exist");
            }
        }
    }   
}