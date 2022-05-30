namespace NumMethLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Newton.RunMethod(11);
            Console.WriteLine();
            Console.Write("------------------------------");
            Console.WriteLine();
            Spline.RunMethod();
        }
    }
}