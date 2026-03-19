using System.Security.Cryptography.X509Certificates;

namespace lab8
{
    public class  BankTerminal
    {
        public event Action<int> OnMoneyWithdraw;

        public void Withdraw(int amount)
        {
            Console.WriteLine($"[Термінал]Виконую операцію: зняття {amount} грн.");

            OnMoneyWithdraw?.Invoke(amount);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTerminal terminal = new BankTerminal();

            terminal.OnMoneyWithdraw += (sum) => Console.WriteLine($"[СМС] З вашого рахунку знято {sum} грн.");
            terminal.Withdraw(100);

            //terminal.OnMoneyWithdraw = null;

            //terminal.OnMoneyWithdraw?.Invoke(1000000);

            Console.WriteLine("Злом завершено. Система сповіщень не працює або бреше.");
        }

    }
}

