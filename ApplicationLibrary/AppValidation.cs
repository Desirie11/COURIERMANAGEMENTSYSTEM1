using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLibrary

{
    public class AppValidation
    {
        internal class Validation
        {
            public static void Main(string[] args)
            {
                {
                    Console.WriteLine("Login Type please select an option\n");

                    Console.WriteLine("1.User" +
                                      "\n2.Admin" +
                                      "\n3.Branch\n");

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Input an Option: ");
                    String Option = Console.ReadLine();
                    int num = Int32.Parse(Option);



                    if (num == 1)
                    {

                        AppValidation validation = new AppValidation();
                        object value = validation.validator1();
                    }
                    if (num == 2)

                    {

                        AppValidation validation2 = new AppValidation();
                        object value = validation2.validator2();

                    }

                    if (num == 3)

                    {
                        Validation validation3 = new Validation();
                        object value = validation3.validator3();
                    }

                    Console.ReadKey();

                }


            }

            private object validator3()
            {
                throw new Exception();
            }



        }

        private object validator2()
        {
            throw new Exception();
        }

        private object validator1()
        {
            throw new Exception();
        }
    }
}
