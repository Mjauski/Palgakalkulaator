using System;

namespace Palgakalkulaator
{
    class Program
    {

        static void Main(string[] args)
        {
            int BrutoSalary = 0;

            Console.WriteLine("Please enter your bruto salary");
            BrutoSalary = Convert.ToInt32(Console.ReadLine());

            if (BrutoSalary >= 500 && BrutoSalary <= 1200)
            {
                CalculationType1(BrutoSalary);
            }

            if (BrutoSalary >= 1201 && BrutoSalary <= 2099)
            {
                CalculationType2(BrutoSalary);
            }

            if (BrutoSalary >= 2100)
            {
                CalculationType3(BrutoSalary);
            }

        }

        static void CalculationType1(double BrutoSalary)
        {
            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double Tax = (BrutoSalary - 500 - pensionFond - Insurance) * 0.2;

            double CalculationType1 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your net salary is = " + CalculationType1);
        }

        static void CalculationType2(double BrutoSalary)
        {
            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double TaxFreeInCome = 500 - 0.55556 * (BrutoSalary - 1200);

            double Tax = (BrutoSalary - pensionFond - Insurance - TaxFreeInCome) * 0.2;

            double CalculationType2 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your net salary is = " + CalculationType2);
        }
        static void CalculationType3(double BrutoSalary)
        {

            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double Tax = BrutoSalary * 0.2;

            double CalculationType3 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your net salary is = " + CalculationType3);
        }
    }
}