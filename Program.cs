namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();

            for (int i = 1; i <= 5; i++)
            {
                int value = i;

                actions.Add(() => Console.WriteLine(value));
            }
            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
