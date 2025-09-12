// HW1a Sales Total

// Your Name: Robert LeBlanc
// Did you seek help ? If yes, specify the helper or web link here: Max Ngo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double price;

            double subtotal;
            double saletax;
            double bill;
            const double tax = 0.085;

            string amountAsString;
            string priceAsString;


            Console.WriteLine("What is the product name of the item you are purchasing?");
            String item = Console.ReadLine();

            Console.WriteLine("How many items do you want to buy?");
            //int.Parse(Console.ReadLine()) lets you use readline with int variables.  
            amountAsString = Console.ReadLine();

            Console.WriteLine("What is the price for each " + item);
            priceAsString = Console.ReadLine();

            amount = Convert.ToDouble(amountAsString);
            price = Convert.ToDouble(priceAsString);

            subtotal = amount * price;
            saletax = subtotal * tax;
            bill = subtotal + saletax;

            Console.WriteLine($"Your subtotal for your bill is {subtotal.ToString("C2")}");
            Console.WriteLine($"Your sale tax for your bill is {saletax.ToString("C2")}");
            Console.WriteLine($"Your total for your bill is {bill.ToString("C2")}");
            Console.ReadKey();



        }
    }
}
