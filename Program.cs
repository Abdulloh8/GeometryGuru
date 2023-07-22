namespace Geometryguru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1 Rectangel of surface");
            Console.WriteLine("1 cubic of volume");

            string message = Console.ReadLine();
            int value = Convert.ToInt32(message);
            if(value == 1)
            {
                Console.Write("enter the first side of the Rectangel corner : ");
            decimal first = Convert.ToDecimal(Console.ReadLine());
            Console.Write("enter the second side of the Rectangel corner : ");
            decimal second = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Rectangel corner surface : {first * second}");
            }
            else if(value == 2)
            {
                Console.Write("enter the first side of the Rectangel corner : ");
                decimal first = Convert.ToDecimal(Console.ReadLine());
                Console.Write("enter the second side of the Rectangel corner : ");
                decimal second = Convert.ToDecimal(Console.ReadLine());
                Console.Write("enter the height side of the Rectangel corner : ");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Rectangel corner surface : {(first * second) * height}");
            }
            else
            {
                Console.Write("enter the first side of the Rectangel corner : ");
            }
        }
    }
}

