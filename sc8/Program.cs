namespace sc8
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        IOutput output = new Array();
                        output.Show();
                        output.Show("Hello!");
                        break;
                    case 2:
                        IMath math = new Array();
                        Console.WriteLine($"Max: {math.Max()}\nMin: {math.Min()}");
                        Console.WriteLine($"Avg: {math.Avg()}\nSearch: {math.Search(8)}");
                        break;
                    case 3:
                        ISort sort = new Array();
                        sort.SortAsc();
                        sort.SortDesc();
                        sort.SortByParam(true);
                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
