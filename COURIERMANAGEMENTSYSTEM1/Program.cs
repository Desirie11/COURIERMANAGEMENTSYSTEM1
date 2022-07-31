using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURIERMANAGEMENTSYSTEM1
{
    abstract class TextWriter
    {
        internal abstract int ViewPickUpRequest();
        internal abstract int ViewAllQueries();
        internal abstract void GetInfoFromUser();
        internal abstract void ViewAllPickupRequest();
        internal abstract void GetQueryFromUser();
        internal abstract void AddnewAgent();
        internal abstract void AssignCourier();
    }

    public class Program

    {
        String Username, Password;

        public void validator1()
        {


            Console.WriteLine("---------------------------------");
            Console.WriteLine("\nUSER LOGIN");

            Console.WriteLine("\nUsername: ");
            Username = Console.ReadLine();

            Console.WriteLine("\nPassword: ");
            Password = Console.ReadLine();

            if (Username.Equals("User") && Password.Equals("User123"))
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("\nLogin Successfully ");

                Console.WriteLine("\nMenu/Option");

                Console.WriteLine("1.Pick-up Request" +
                                  "\n2.View my Pick-up Request" +
                                  "\n3.Contuct us");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("\nInput an Option");
                String UserOption = Console.ReadLine();
                int UserMenu = Int32.Parse(UserOption);
                Console.WriteLine("---------------------------------");

                if (UserMenu == 1)
                {
                    TextWriter tw = TextWriter();
                    tw.GetInfoFromUser();
                }
                if (UserMenu == 2)
                {

                    TextWriter tw = TextWriter();
                    tw.ViewAllPickupRequest();

                }
                if (UserMenu == 3)
                {
                    Console.WriteLine("--------CONTUCT US OPTION--------\n");

                    TextWriter tw = TextWriter();
                    tw.GetQueryFromUser();

                }
            }

            else
            {
                Console.WriteLine("\nInvalid username or password please try again");

            }

            ///////////////////////////Admin LOGIN//////////////////////////////////////      
            ///

        }

        private TextWriter TextWriter()
        {
            throw new NotImplementedException();
        }

        public void validator2()
        {
            Console.WriteLine("----------ADMIN LOGIN------------");
            Console.WriteLine("Username: ");
            Username = Console.ReadLine();

            Console.WriteLine("\nPassword: ");
            Password = Console.ReadLine();

            if (Username.Equals("Admin") && Password.Equals("Admin123"))
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("\nLogin Successfully ");

                Console.WriteLine("1.View Costumer Pick-up Request" +
                                  "\n2.View Costumer Query");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Select an Option");
                String AdminOption = Console.ReadLine();
                int AdminMenu = Int32.Parse(AdminOption);

                if (AdminMenu == 1)
                {

                    TextWriter tw = TextWriter();
                    tw.ViewPickUpRequest();


                }
                if (AdminMenu == 2)
                {

                    TextWriter tw = TextWriter();
                    tw.ViewAllQueries();

                }
            }
        }

        public void validator3()
        {

            Console.WriteLine("---------BRANCH LOGIN-----------");
            Console.WriteLine("\nUsername: ");
            Username = Console.ReadLine();

            Console.WriteLine("\nPassword: ");
            Password = Console.ReadLine();

            if (Username.Equals("Branch") && Password.Equals("Branch123"))
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Login Successfully");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Please select an Option");

                Console.WriteLine("1.ADD" +
                                  "\n2.VIEW PIC-UP REQUEST" +
                                  "\n3.BOOK COURIERS");

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Input an Option");
                String BranchOption = Console.ReadLine();
                int BranchMenu = Int32.Parse(BranchOption);

                if (BranchMenu == 1)
                {
                    Console.WriteLine("--------Add agent-----------");
                    TextWriter tw = TextWriter();
                    tw.AddnewAgent();
                }


                if (BranchMenu == 2)
                {

                    //ReadFile ng Book Courier

                    Console.WriteLine("---------------------------");

                    String filePath = @"C:\Users\MyPC\source\repos\COURIERMANAGEMENTSYSTEM1\TheDataLayer\CourierDetails.txt";

                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();

                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadLine();

                }

                if (BranchMenu == 3)
                {

                    Console.WriteLine("-------------BOOK COURIERS-----------");
                    Console.WriteLine("------------Courier Details----------");

                    TextWriter tw = TextWriter();
                    tw.AssignCourier();



                    Console.ReadLine();

                }
            }
        }
    }
}
