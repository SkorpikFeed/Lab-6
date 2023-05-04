using Lab_6_C_;

class Program
{
    static void Main()
    { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter 1 to select a pyramid, 2 to select a cone: ");
        Console.ResetColor();
        int choice = Convert.ToInt32(Console.ReadLine());
    Again:
        if (choice == 1)
        {
            Console.WriteLine("Enter the height of the pyramid: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side of the pyramid: ");
            double side = Convert.ToDouble(Console.ReadLine());
            RightPyramid pyramid = new RightPyramid(height, side, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 1 to get side area, 2 to get volume,3 to make a cone, 4 to stop");
            Console.ResetColor();
            ICalculatingFigureProperties prop = pyramid;
            while (true)
            {
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        Console.WriteLine("The side area of the pyramid is: " + prop.SideArea());
                        break;
                    case 2:
                        Console.WriteLine("The volume of the pyramid is: " + prop.Volume());
                        break;
                    case 3:
                        Console.Clear();
                        choice = 2;
                        goto Again;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Entered wrong number");
                        break;
                }
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter the height of the cone: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the radius of the cone: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Cone cone = new Cone(height, radius, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 1 to get side area, 2 to get volume, 3 to make a pyramid, 4 to stop");
            Console.ResetColor();
            ICalculatingFigureProperties prop = cone;
            while (true)
            {
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        Console.WriteLine("The side area of the cone is: " + prop.SideArea());
                        break;
                    case 2:
                        Console.WriteLine("The volume of the cone is: " + prop.Volume());
                        break;
                    case 3:
                        Console.Clear();
                        choice = 1; 
                        goto Again;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Entered wrong number");
                        break;
                }
            }
        }
        else
        {
             Console.WriteLine("Entered wrong number");
        }
    }
}