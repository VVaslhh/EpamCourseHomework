using System;
using System.Collections.Generic;
using Classes;
using Inheritance;
using Collections;

namespace TaskRunner
{
    static class Program
    {
        static void Main()
        {
            bool endApp = false;
            Console.WriteLine("Viktoriia Vasyltsiv");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            while (!endApp)
            {
                Console.WriteLine("Choose task number from the following list:");
                Console.WriteLine("");
                Console.WriteLine("\t1   - Task1 HW1 Classes");
                Console.WriteLine("\t2   - Task2 HW1 Classes");
                Console.WriteLine("\t3   - Task3 HW1 Classes");
                Console.WriteLine("\t4.1 - Task4.Rectangle HW1 Classes");
                Console.WriteLine("\t4.2 - Task4.Circle HW1 Classes");
                Console.WriteLine("\t5   - Task5 HW1 Classes");
                Console.WriteLine("\t6   - Task1 HW2 Inheritance");
                Console.WriteLine("\t7   - Task2 HW2 Inheritance");
                Console.WriteLine("\t8   - Task3 HW2 Inheritance");
                Console.WriteLine("\t9   - Task4 HW2 Inheritance");
                Console.WriteLine("\t10   - Task1 HW3 Collections");
                Console.WriteLine("\t11   - Task2 HW3 Collections");
                Console.WriteLine("\t12   - Task3 HW3 Collections");
                Console.WriteLine("Your Option?");
                string option = Console.ReadLine();
                Console.WriteLine("\n");

                double radius;
                CoordsOfPoint b, d;

                switch (option)
                {
                    case "1":
                        // Coordinates of top-left corner of a rectange.
                        Console.Write("Enter top-left point of a rectangle:\n");
                        b = CoordsInput();

                        // Coordinates of bottom-right corner of a rectange.
                        Console.Write("Enter bottom-right point of a rectangle:\n");
                        d = CoordsInput();

                        while (!CoordsValidation(b, d))
                        {
                            Console.Write("This is not valid input\n");
                            Console.Write("Enter top-left point of a rectangle:\n");
                            b = CoordsInput();

                            Console.Write("Enter bottom-right point of a rectangle:\n");
                            d = CoordsInput();
                        }

                        Rectangle rectangle1 = new Rectangle(b, d);
                        rectangle1.Perimeter();
                        rectangle1.Area();
                        break;

                    case "2":
                        // Coordinates of top-left corner of a rectange.
                        Console.Write("Enter top-left point of a rectangle:\n");
                        b = CoordsInput();

                        // Coordinates of bottom-right corner of a rectange.
                        Console.Write("Enter bottom-right point of a rectangle:\n");
                        d = CoordsInput();

                        while (!CoordsValidation(b, d))
                        {
                            Console.Write("This is not valid input\n");
                            Console.Write("Enter top-left point of a rectangle:\n");
                            b = CoordsInput();

                            Console.Write("Enter bottom-right point of a rectangle:\n");
                            d = CoordsInput();
                        }

                        RectangleAutoImplementedProperties rectangle2 = new RectangleAutoImplementedProperties(b, d);
                        Console.WriteLine($"Perimeter of the rectangle is: {rectangle2.PerimeterProperty}");
                        Console.WriteLine($"Area of the rectangle is: {rectangle2.AreaProperty}");
                        break;

                    case "3":

                        Console.Write("\nEnter radius of circle = ");
                        radius = Convert.ToDouble(Console.ReadLine());
                        while (radius < 0)
                        {
                            Console.Write("This is not valid input.Please enter a positive value: ");
                            radius = Convert.ToDouble(Console.ReadLine());
                        }
                        Circle circle = new Circle();
                        Console.WriteLine($"Circumference of the circle is: {circle.CircumferenceOfCircle(radius)}");
                        Console.WriteLine($"Area of the circle is: {circle.AreaOfCircle(radius)}");
                        break;

                    case "4.1":
                        // Coordinates of top-left corner of a rectange.
                        Console.Write("Enter top-left point of a rectangle:\n");
                        b = CoordsInput();

                        // Coordinates of bottom-right corner of a rectange.
                        Console.Write("Enter bottom-right point of a rectangle:\n");
                        d = CoordsInput();

                        while (!CoordsValidation(b, d))
                        {
                            Console.Write("This is not valid input\n");
                            Console.Write("Enter top-left point of a rectangle:\n");
                            b = CoordsInput();

                            Console.Write("Enter bottom-right point of a rectangle:\n");
                            d = CoordsInput();
                        }

                        StaticRectangle.PerimeterStatic(b, d);
                        StaticRectangle.AreaStatic(b, d);
                        break;

                    case "4.2":

                        Console.Write("\nEnter radius of circle = ");
                        radius = Convert.ToDouble(Console.ReadLine());
                        while (radius < 0)
                        {
                            Console.Write("This is not valid input.Please enter a positive value: ");
                            radius = Convert.ToDouble(Console.ReadLine());
                        }

                        Console.WriteLine($"Circumference of the circle is: {StaticCircle.CircumferenceOfCircle(radius)}");
                        Console.WriteLine($"Area of the circle is: {StaticCircle.AreaOfCircle(radius)}");
                        break;

                    case "5":

                        Console.Write("Enter the real part of the first complex number: ");
                        double realPart1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the imaginary part of the first complex number: ");
                        double imaginaryPart1 = Convert.ToDouble(Console.ReadLine());
                        ComplexNumber num1 = new ComplexNumber(realPart1, imaginaryPart1);

                        Console.Write("Enter the real part of the second complex number: ");
                        double realPart2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the imaginary part of the second complex number: ");
                        double imaginaryPart2 = Convert.ToDouble(Console.ReadLine());
                        ComplexNumber num2 = new ComplexNumber(realPart2, imaginaryPart2);

                        var multiplicationResult = num1 * num2;
                        Console.WriteLine($"The result of multiplication: {multiplicationResult.realPart} + {multiplicationResult.imaginaryPart}i ");

                        try
                        {
                            var divisionResult = num1 / num2;
                            Console.WriteLine($"The result of division: {divisionResult.realPart} + {divisionResult.imaginaryPart}i ");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "6":
                        var s1 = new Inheritance.Task1.Square();
                        s1.Draw();

                        var r1 = new Inheritance.Task1.Rectangle();
                        r1.Draw();

                        break;

                    case "7":
                        var s2 = new Inheritance.Task2.Square(1, 5);
                        s2.Draw();

                        var r2 = new Inheritance.Task2.Rectangle(3, 4);
                        r2.Draw();
                        break;

                    case "8":
                        var f3 = new Inheritance.Task3.Figure(2, 3);
                        f3.Draw();

                        var s3 = new Inheritance.Task3.Square(8, 1);
                        s3.Draw();

                        var r3 = new Inheritance.Task3.Rectangle(5, 4);
                        r3.Draw();
                        break;

                    case "9":
                        var f4 = new Inheritance.Task4.Figure(7, 3);
                        var s4 = new Inheritance.Task4.Square(4, 1);
                        var r4 = new Inheritance.Task4.Rectangle(3, 4);

                        DrawAll(f4, s4, r4, r4, s4, f4);

                        break;
                    case "10":
                        Task12 person = new Task12();
                        person.DisplayNameAndAge();

                        break;

                    case "11":
                        Task12 personTwoMore = new Task12();
                        Person oneMore = new Person { Name = "Jess", Age = 45, PhoneNumbers = new List<string> { Task12.GetRandomPhoneNumber(), Task12.GetRandomPhoneNumber(), Task12.GetRandomPhoneNumber() } };
                        Person twoMore = new Person { Name = "Finn", Age = 51, PhoneNumbers = new List<string> { Task12.GetRandomPhoneNumber(), Task12.GetRandomPhoneNumber(), Task12.GetRandomPhoneNumber() } };
                        var temp = new List<Person>() { oneMore, twoMore };
                        personTwoMore.persons.AddRange(temp);

                        personTwoMore.DisplayPhoneNumbers();

                        break;

                    case "12":
                        Task3 list = new Task3();
                        List<string> initial = list.CreateList();
                        Console.WriteLine($"List before transformation:");
                        list.Display(initial);

                        List<string> listModify = list.ModifyList();
                        Console.WriteLine($"List after transformation:");
                        list.Display(listModify);

                        bool endTask = false;
                        while (!endTask)
                        {
                            try
                            {

                                Console.Write("Enter the number of page or Press any Not number key to close task: ");
                                bool pageNumber = int.TryParse(Console.ReadLine(), out int page);
                                if (!pageNumber) endTask = true;
                                list.DisplayPage(listModify, page);
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                                                        
                        }
                        break;
                    default:

                        break;


                }
                Console.WriteLine("-----------------------------------------------------------------------------------");
                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
        }
        public static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }

        public static bool CoordsValidation(CoordsOfPoint p1, CoordsOfPoint p2)
        {
            double side1, side2;
            side1 = p2.X - p1.X;
            side2 = p1.Y - p2.Y;
            if (side1 > 0 && side2 > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static CoordsOfPoint CoordsInput()
        {
            Console.Write("Enter X coordinate:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y coordinate:");
            double y = Convert.ToDouble(Console.ReadLine());
            return new CoordsOfPoint(x, y);
        }
    }
}
