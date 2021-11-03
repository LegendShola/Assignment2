using Assignment2.Models;
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Customer Shola = new Customer();

            Shola.Login();
            Shola.CheckBVN("");
            Shola.CheckAccountBalance();



           
        }
    }
}
