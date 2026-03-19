namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();

            for (int i = 1; i <= 5; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
