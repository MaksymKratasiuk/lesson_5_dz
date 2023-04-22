namespace lesson_5_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch = -1;
            do
            {
                Console.WriteLine("enter task num (0 to exit) -> ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Task1.task1();
                        break;
                    case 2:
                        Task2.task2();
                        break;
                    case 3:
                        Task3.task3();
                        break;

                }
            } while (ch != 0);
        }
    }
}