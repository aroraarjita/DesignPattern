using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without Design Pattern
            //string cardType = "MoneyBack";

            //CreditCard cardDetails = null;

            //if(cardType == "MoneyBack")
            //{
            //    cardDetails = new MoneyBack();
            //}
            //else if(cardType == "Titanium")
            //{
            //    cardDetails = new Titanium();
            //}
            //else if(cardType == "Platinum")
            //{
            //    cardDetails = new Platinum();
            //}


            //if(cardDetails != null)
            //{
            //    Console.WriteLine("CardType: " + cardDetails.GetCardType());
            //    Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
            //    Console.WriteLine("Annual Charges: " + cardDetails.GetAnnualCharge());

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card Type!!");
            //}

            //Console.ReadLine();


            //With Factory Design Pattern

            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if(cardDetails != null)
            {
                Console.WriteLine("CardType: " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
                Console.WriteLine("Annual Charges: " + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type!!");
            }
            Console.ReadLine();
        }



    }
}
