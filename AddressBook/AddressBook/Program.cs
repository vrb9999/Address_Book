using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Address Book Program!");
            CreateContact contact = new CreateContact();
            while (true)
            {
                Console.WriteLine("\nEnter the number :\n1)Create contact\n2)Edit Details\n3)Remove Contacts\n4)Display contacts\n5)Exit\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact.Contacts();
                        break;
                    case 2:
                        contact.EditDetails();
                        break;
                    case 3:
                        contact.RemoveContact();
                        break;
                    case 4:
                        contact.output();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
