using System.Security.Cryptography.X509Certificates;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double initialPrice = 1000;

            
            Func<double, double> discountCalculator = (price) => price * 0.95;
            discountCalculator += (price) => price * 0.90;
            discountCalculator += (price) => price - 100;

            
            double currentPrice = initialPrice;

            
            foreach (var method in discountCalculator.GetInvocationList())
            {
               
                var func = (Func<double, double>)method;
                currentPrice = func(currentPrice); 
            }

            Console.WriteLine($"Початкова ціна: {initialPrice}");
            Console.WriteLine($"Ціна після всіх знижок: {currentPrice}");
        }

    }
}

