using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
     class Program
    {
        static void Main(string[] args)
        {
            RunAccount();

            Console.ReadLine();
        }

        static void RunAccount()
        {
            ECommerceFacade eCommerceFacade = new ECommerceFacade();
            eCommerceFacade.UserStart();         
        }
    }
}
