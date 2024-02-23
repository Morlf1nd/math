using System;
class Exam
{
    static void Main()
    {
        double y = 0;
        Console.WriteLine("Enter the x: ");
        string a = Console.ReadLine();
        int x = int.Parse(a);
        
        if (x > 40)
        {
            y = ((8 * x) - Math.Pow(7, x))/ (Math.Pow(6, x)- Math.Pow(5, x));
            Console.WriteLine("You y is: " + y);
        }
        if(x>=3 && x <= 40)
        {
            

            for (int i = 3; i <=x;i++)
            {
                y += 3 * x;
            }
            Console.WriteLine("You y is: " + y);
        }
        if (x < 3)
        {
            y = (Math.Pow(x, 1.0 / 4) - 1) / (x - 1);
            Console.WriteLine("You y is: " + y);
        }

    }
}