using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypes
{
    class Program
    {
        interface baseInterface
        {
            // int fieldProtectedInterface { get; set; }
        }

        public class classBase1: baseInterface
        {
            internal int fieldProtected;

           // public int fieldProtectedInterface { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class childClass1 : classBase1
        {
            
        }

        class child2 : childClass1
        {

        }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            childClass1 child1 = new childClass1();
            child1.fieldProtected = 65;

            child2 child2 = new child2();
            //child2.fieldProtectedInterface = 3232;


            float typeFloat = 54.97494595f;
            double typeDouble ;
            decimal typeDecimal;
            typeDouble = typeFloat;
            typeDecimal = (decimal) (typeFloat);
           // typeDecimal = Convert.ToDecimal( typeFloat);


            Console.WriteLine($"Float: {typeFloat}");
            Console.WriteLine($"Double: {typeDouble}");
            Console.WriteLine($"Decimal: {typeDecimal}");
            // Console.WriteLine(typeDouble);
            Console.WriteLine();

            //double to float
            double typeDouble2 = 77.45962;
            float typeFloat2;
            // explicit :   double -> float
            typeFloat = (float)(typeDouble2);

            //implicit: -> float to double
            typeDouble2 = typeFloat;

            // Decimal to double
            decimal typeDecimal2;

            typeDecimal2 =(decimal) typeDouble2;


            // all integrap convertedt to all floating points
            int i = 1;
            float f = i;

            //reverse
            int i2 = (int) f;

            //Double to int
            double varDouble = 45.55;
           
            // explicit :  double -> int
            int varInt = (int) varDouble;
            Console.WriteLine(varInt);

            // implicit> int -> double
            int intVarD = 48;
            varDouble = intVarD;


            // floating poitn number to integral ANY FRACTION PORTION IS TRUNCATED
            // No rounding is performed
            // ** System.Convert -> method to Round while converting

            int x = int.MaxValue;
            int y = x + 1; // unchecked(x + 1);

           // int xx = int.MaxValue + 1;  // complilte time error

            int a = 1000000;
            int b = 1000000;
           // ommmited int c = checked(a * b); // Checks just the expression.

            // / -16 Bit Integrals
            // The 8 - and 16 - bit integral types are byte, sbyte, short, and ushort.
            // These types LACK their own arithmetic operators, 
            // so C# implicitly converts them to larger types as required. This can cause a compile-time error when trying to assign the result back to a small integral

            short xxx = 1, yyy = 1;
            // short z = xxx + yyy; // Compile-time error

            // case, xxx and yyy are implicitly converted to int so that the addition can be performed.
            // To make this compile, we must add an explicit cast:
            short zz = (short)(xxx + yyy); // OK


            //Special float 
            Console.WriteLine(double.NegativeInfinity); // -Infinity

            Console.WriteLine(1.0 / 0.0); // Infinity
            Console.WriteLine (-1.0 / 0.0); // -Infinity 
            Console.WriteLine (1.0 / -0.0); // -Infinity
            Console.WriteLine (-1.0 / -0.0); // Infinity

            Console.WriteLine(0.0 / 0.0); // NaN 
            Console.WriteLine (( 1.0 / 0.0)- (1.0 / 0.0)); // NaN

            // When using = =, a NaN value is never equal to another value, even another NaN value: 
            Console.WriteLine(0.0 / 0.0 == double.NaN); // False

            //
            Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True

            // When using object.Equals, however, two NaN values are equal: 
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); // True


            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

           
        }
        //vversion 7.2
        //void  Foo(in int x)
        //{

        //}
        int a;
        void Foo (int a, int x)
            {
            }



    }
}
