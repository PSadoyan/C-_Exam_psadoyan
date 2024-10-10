using System;
using System.Collections.Generic;

class main 
{
    public static void Main(string[] args)
    {
        
        //Problem #1
        Console.WriteLine("Problem #1:");
        Primes P1 = new Primes();
        P1.primes(237);

        //Problem #2
        //Showing both an array with more than 5 and an empty array
        Console.WriteLine("\n");
        Console.WriteLine("Problem #2:");
        string[] P2_names = new string[5] {"Alice", "Bob", "Cathy", "David", "Ella"};
        string[] P2_namesEmpty = new string[0];
        FB_Likes P2 = new FB_Likes();
        P2.likes(P2_names);
        P2.likes(P2_namesEmpty);

        //Problem #3
        //We'll create multiple objects and iterate over them in a List
        Console.Write("\n");
        Console.WriteLine("Problem #3:");
        Rectangle R1 = new Rectangle(3,5);
        Rectangle R2 = new Rectangle(12,52);
        Triangle T1 = new Triangle(5,4);
        Triangle T2 = new Triangle(10,10);
        Circle C1 = new Circle(5);
        Circle C2 = new Circle(13);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(R1);
        shapes.Add(R2);
        shapes.Add(T1);
        shapes.Add(T2);
        shapes.Add(C1);
        shapes.Add(C2);

        Console.WriteLine("Area of Rectangle 1: " + R1.Area());

        for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine("Area of shape " + shapes[i] + ": " + shapes[i].Area());
            }

        //Problem #4
        //Created a string array and a string to search for
        Console.Write("\n");
        Console.WriteLine("Problem #4:");
        //string array below
        string[] P4_Strings = {"Hello", "World", "Jello", "Micheal", "ello", ""};
        string[] P4_Empty = {};
        StringSearch P4 = new StringSearch();

        Console.WriteLine("First the Full Array: ");
        for (int i = 0; i < P4.strSearch("ello", P4_Strings).Length; i++)
        {
            Console.WriteLine(P4.strSearch("ello", P4_Strings)[i]);
        }

        Console.Write("\n");
        Console.WriteLine("And now the Empty Array: ");
        for (int i = 0; i < P4.strSearch("ello", P4_Empty).Length; i++)
        {
            Console.WriteLine(P4.strSearch("ello", P4_Empty)[i]);
        }

        //Problem #5
        //Created a list of integers, added a few numbers that (should) show-case all possibilities
        Console.Write("\n");
        Console.WriteLine("Problem #5:");
        List<int> nums = new List<int>();
        nums.Add(-1);
        nums.Add(71);
        nums.Add(60);
        nums.Add(20);
        nums.Add(0);
        nums.Add(112);
        nums.Add(23);
        Linqing P5 = new Linqing();
        Console.WriteLine(P5.SumOver50(nums));
        
    }
}