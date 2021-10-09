using System;

namespace Day19_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1-----------------------------------------------------------------------------
            string name1;
            bool result1;

            UC1 firstname = new UC1();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the First Name");

            name1 = Console.ReadLine();

            result1 = firstname.FirstNameCheck(name1);
            Console.WriteLine(result1);

            Console.WriteLine("******************************************************");

            //UC2------------------------------------------------------------------------------------
            string name2;
            bool result2;


            Uc2 lastname = new Uc2();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the Last Name");

            name2 = Console.ReadLine();

            result2 = lastname.LastNameCheck(name2);
            Console.WriteLine(result2);

            Console.WriteLine("******************************************************");

            //UC3---------------------------------------------------------------------------------------------
            string name3;
            bool result3;


            UC3 email = new UC3();
            // Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the Email Address");

            name3 = Console.ReadLine();

            result3 = email.emailCheck(name3);
            Console.WriteLine(result3);

            Console.WriteLine("******************************************************");

            //UC4-------------------------------------------------------------------------------------
            string name4;
            bool result4;


            UC4 Email = new UC4();
            Console.WriteLine("Enter Country code in start  eg(91) for India");
            Console.WriteLine("Enter the Phone Number");

            name4 = Console.ReadLine();

            result4 = Email.PhonenumberCheck(name4);
            Console.WriteLine(result4);

            Console.WriteLine("******************************************************");

            //UC5--------------------------------------------------------------------------------------
            string name5;
            bool result5;

            UC5 Passwordchar = new UC5();
            // Console.WriteLine("Enter Country code in start  eg(91) for India");
            Console.WriteLine("Enter the Password");

            name5 = Console.ReadLine();

            result5 = Passwordchar.PasswordCheck(name5);
            Console.WriteLine(result5);

            Console.WriteLine("******************************************************");

            //UC6--------------------------------------------------------------------------------------------
            string name6;
            bool result6;


            UC6 Passwordupp = new UC6();
            Console.WriteLine("Password should contain 1 Upper Latter");
            Console.WriteLine("Enter the Password");

            name6 = Console.ReadLine();

            result6 = Passwordupp.PasswordUppCheck(name6);
            Console.WriteLine(result6);

            Console.WriteLine("******************************************************");

            //UC7---------------------------------------------------------------------------------------------------
            string name7;
            bool result7;


            UC7 Passwordnum = new UC7();
            Console.WriteLine("Password should contain 1 numric");
            Console.WriteLine("Enter the Password");

            name7 = Console.ReadLine();

            result7 = Passwordnum.PasswordnumCheck(name7);
            Console.WriteLine(result7);

            Console.WriteLine("******************************************************");

            //UC8-----------------------------------------------------------------------------------
            string name8;
            bool result8;


            UC8 Passwordspecial = new UC8();
            Console.WriteLine("Password should contain 1 Special Character");
            Console.WriteLine("Enter the Password");

            name8 = Console.ReadLine();

            result8 = Passwordspecial.PasswordSpecialCheck(name8);
            Console.WriteLine(result8);

        }   
    }
}
