using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer
{
    public class TextWriter
    {

        public void GetInfoFromUser()
        {
            Console.WriteLine("Pick-up Request Option\n");
            Console.WriteLine("//////////SENDERS INFO///////////\n");
            Console.WriteLine("Senders name: ");
            String SenderName = Console.ReadLine();

            Console.WriteLine("\nAddress: ");
            String SenderAddress = Console.ReadLine();

            Console.WriteLine("\nPhone number: ");
            String Pnumber = Console.ReadLine();
            long SenderPhonenumber = long.Parse(Pnumber);

            Console.WriteLine("\nEmail: ");
            String SenderEmail = Console.ReadLine();

            Console.WriteLine("\nState: ");
            String SenderState = Console.ReadLine();

            Console.WriteLine("\nCity: ");
            String SenderCity = Console.ReadLine();

            Console.WriteLine("\nZipcode: ");
            String Zipcode = Console.ReadLine();
            int SenderZipcode = Int32.Parse(Zipcode);

            ///////////////////recievers info/////////////////

            Console.WriteLine("//////////RECIEVERS INFO///////////\n");

            Console.WriteLine("\nRecievers name: ");
            String RecieverName = Console.ReadLine();

            Console.WriteLine("\nAddress: ");
            String RecieverAddress = Console.ReadLine();

            Console.WriteLine("\nPhone number: ");
            String Pnum = Console.ReadLine();
            long RecieverPhonenumber = long.Parse(Pnum);

            Console.WriteLine("\nEmail: ");
            String RecieverEmail = Console.ReadLine();

            Console.WriteLine("\nState: ");
            String RecieverState = Console.ReadLine();

            Console.WriteLine("\nCity: ");
            String RecieverCity = Console.ReadLine();

            Console.WriteLine("\nZipcode: ");
            String rZipcode = Console.ReadLine();
            long RecieverZipcode = long.Parse(Zipcode);

            Console.WriteLine("----------PACKAGE OPTION----------\n");

            Console.WriteLine("\nPackage Type:");
            Console.WriteLine("\n1.Documents" +
                              "\n2.Parcel\n");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Input an Option");
            String Package = Console.ReadLine();
            long PackageOption = long.Parse(Package);
            Console.WriteLine("----------------------------------");

            if (PackageOption == 1)
            {
                int Documents = 20;
                int Chargefee = 30;
                int total;

                Console.WriteLine("weight (kg): ");
                String kg = Console.ReadLine();
                int kilogram = Int32.Parse(kg);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("------------RECIEPT----------------");

                total = Documents * kilogram + Chargefee;




                string path = @"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\Reciept.txt";

                File.WriteAllText(path, "Senders Info\n\n" + "Senders Name: " + SenderName + "\n" + "Address: " + SenderAddress + "\n" + "Phone Number: " + SenderPhonenumber + "\n" + "Email: " + SenderEmail + "\n" + "State: " + SenderState + "\n" + "City: " + SenderCity + "\n" + "Zipcode: " + SenderZipcode + "\n\n" +
                                        "Recievers Info\n\n" + "Recievers Name: " + RecieverName + "\n" + "Address" + RecieverAddress + "\n" + "Phone Number: " + RecieverPhonenumber + "\n" + "Email: " + RecieverEmail + "\n" + "State: " + RecieverState + "\n" + "City: " + RecieverCity + "\n" + "Zipcode: " + RecieverZipcode + "\n" + "Weight (kg): " + kilogram +
                                        "\nTotal cost\n" + total);

                Console.WriteLine("Senders Info\n" + SenderName + "\n" + SenderAddress + "\n" + SenderPhonenumber + "\n" + SenderEmail + "\n" + SenderState + "\n" + SenderCity + "\n" + SenderZipcode);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Reciecers Info\n" + RecieverName + "\n" + RecieverAddress + "\n" + RecieverPhonenumber + "\n" + RecieverEmail + "\n" + RecieverState + "\n" + RecieverCity + "\n" + RecieverZipcode);

                Console.WriteLine("Final Cost " + total);

                File.AppendAllText(@"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\AllPickupRequest.txt", File.ReadAllText(@"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\Reciept.txt"));
            }

            if (PackageOption == 2)
            {

                int parcel = 50;
                int Chargefee = 30;
                int total;

                Console.WriteLine("weight (kg): ");
                String kg = Console.ReadLine();
                int knum = Int32.Parse(kg);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("------------RECIEPT----------------");

                total = parcel * knum + Chargefee;

                string path = @"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\Reciept.txt";

                File.WriteAllText(path, "Senders Info\n" + "Senders Name: " + SenderName + "\n" + "Address: " + SenderAddress + "\n" + "Phone Number: " + SenderPhonenumber + "\n" + "Email: " + SenderEmail + "\n" + "State: " + SenderState + "\n" + "City: " + SenderCity + "\n" + "Zipcode: " + SenderZipcode + "\n\n" +
                                        "Recievers Info\n" + "Recievers Name: " + RecieverName + "\n" + "Address" + RecieverAddress + "\n" + "Phone Number: " + RecieverPhonenumber + "\n" + "Email: " + RecieverEmail + "\n" + "State: " + RecieverState + "\n" + "City: " + RecieverCity + "\n" + "Zipcode: " + RecieverZipcode + "\n" + "Weight (kg): " + knum +
                                        "\nTotal cost\n" + total);

                Console.WriteLine("Senders Info\n" + SenderName + "\n" + SenderAddress + "\n" + SenderPhonenumber + "\n" + SenderEmail + "\n" + SenderState + "\n" + SenderCity + "\n" + SenderZipcode);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Reciecers Info\n" + RecieverName + "\n" + RecieverAddress + "\n" + RecieverPhonenumber + "\n" + RecieverEmail + "\n" + RecieverState + "\n" + RecieverCity + "\n" + RecieverZipcode);

                Console.WriteLine("Final Cost " + total);

                File.AppendAllText(@"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\AllPickupRequest.txt", File.ReadAllText(@"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\Reciept.txt"));

            }


        }

        public void ViewAllPickupRequest()
        {

            String filePath = @"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\AllPickupRequest.txt";
            //String[] lines = File.

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();


        }

        public void GetQueryFromUser()
        {
            Console.WriteLine("\nName: ");
            String name = Console.ReadLine();

            Console.WriteLine("\nEmail: ");
            String email = Console.ReadLine();

            Console.WriteLine("\nPhone number: ");
            String Phonenumber = Console.ReadLine();
            long number3 = long.Parse(Phonenumber);

            Console.WriteLine("\nQuery: ");
            String Query = Console.ReadLine();

            string path = @"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\Query.txt";

            File.WriteAllText(path, "Name: " + name + "\n\n" + "Email: " + email + "\n\n" + "Phone number: " + "\n\n" + number3 + "\n\n" + "Query: " + Query + "\n");
            File.AppendAllText(@"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\AllQuery.txt", File.ReadAllText(path));

        }

        public void ViewPickUpRequest()
        {
            String filePath = @"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\Reciept.txt";
            //String[] lines = File.

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

        }

        public void ViewAllQueries()
        {

            String filePath = @"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\AllQuery.txt";
            //String[] lines = File.

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();


        }

        public void AddnewAgent()
        {
            Console.WriteLine("State: ");
            String state = Console.ReadLine();

            Console.WriteLine("City: ");
            String city = Console.ReadLine();

            Console.WriteLine("Agent Name: ");
            String AgentName = Console.ReadLine();

            Console.WriteLine("Email: ");
            String email = Console.ReadLine();

            Console.WriteLine("Agent Code: ");
            String AgentCode = Console.ReadLine();

            Console.WriteLine("Gender: ");
            String gender = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            String phonenumber = Console.ReadLine();
            long pnumber = long.Parse(phonenumber);

            Console.WriteLine("Address: ");
            String address = Console.ReadLine();

            string path = @"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\AgentDetails.txt";

            File.WriteAllText(path, "\n" + "State: " + state + "\n" + "City: " + city + "\n" + "Agent Name: " + AgentName + "\n"
                               + "Email: " + email + "\n" + "Agent Code: " + AgentCode + "\n" + "Gender: " + gender
                               + "\n" + "Phone Number: " + phonenumber + "\n" + "Address: " + address + "\n");

            Console.WriteLine("State" + state + "\n" + "City: " + city + "\n" + "Agent Name: " + AgentName + "\n"
                               + "Email" + email + "\n" + "Password: " + AgentCode + "\n" + "Gender: " + gender
                               + "\n" + "Phone Number: " + phonenumber + "\n" + "Address: " + address);
        }

        public void AssignCourier()
        {
            Console.WriteLine("Courier Number: ");
            String Cnumber = Console.ReadLine();
            int cnumber = Int32.Parse(Cnumber);

            Console.WriteLine("Agent Name: ");
            String aname = Console.ReadLine();

            string path = @"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\CourierDetails.txt";

            File.WriteAllText(path, "Agent Name: " + aname + "\n" + "Courier Number: " + cnumber + "\n");


            String filePath = @"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\Reciept.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {

                Console.WriteLine(line);
            }

            File.AppendAllText(@"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\CourierDetails.txt", File.ReadAllText(@"C:\Users\MyPC\source\repos\CourierManagemnentSYSTEM\TheDataLayer\Reciept.txt"));

           
        }
    }
}
