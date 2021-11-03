using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Bvn { get; set; }


        public void Login()
        {
            Console.WriteLine("Pls Enter Your UserName");
            UserName = Console.ReadLine();

            if (UserName == "Shola")
            {
                Console.WriteLine("Login Successful");

            }
        }
        public decimal CheckAccountBalance()
        {
            decimal balance = 1000;
            return balance;
            Console.WriteLine("Pls Enter Your Account Number");
            Console.ReadLine();
        }
        public string CheckBVN(string PhoneNumber)
        {
            string BVN = "22718794873";
            return BVN;
            Console.WriteLine("Pls Enter Your PhoneNumber");
            PhoneNumber = Console.ReadLine();
            if (PhoneNumber == "07033018078")
            {
                Console.WriteLine("22718794873");
            }
        }
    }
}
