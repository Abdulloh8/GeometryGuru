namespace Geometryguru
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1 Rectangel of surface");
            Console.WriteLine("2 cubic of volume");

            string message = Console.ReadLine();
            int value = Convert.ToInt32(message);
            
            switch(value)
            {
                case 1: Console.Write("enter the first side of the Rectangel corner : ");
                        decimal first = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("enter the second side of the Rectangel corner : ");
                        decimal second = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Rectangel corner surface : {first * second}");
                    break;
                case 2: Console.Write("enter the first side of the Rectangel corner : ");
                        decimal first_ = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("enter the second side of the Rectangel corner : ");
                        decimal second_ = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("enter the height side of the Rectangel corner : ");
                        decimal height = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Rectangel corner surface : {(first_ * second_) * height}");   
                    break;  
                default :   Console.Write("enter the first side of the Rectangel corner : ");
                    break;    
            }
        }
    }
}

