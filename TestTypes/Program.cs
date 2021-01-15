using System;
using System.Collections.Generic;
using System.Globalization;
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

            string[] fullnames = { "Anne Williams", "John SOTO", "Juan Perez" };

            IEnumerable<string> queryMany = from full in fullnames
                                        from name2 in full.Split()
                                        select name2;

            IEnumerable<string> queryMany2 = fullnames.SelectMany(nn => nn.Split());



            foreach (var item in queryMany)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

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

            Console.WriteLine((1.0 / 0.0) - (-1.0 )); // ??


            // When using = =, a NaN value is never equal to another value, even another NaN value: 
            Console.WriteLine(0.0 / 0.0 == double.NaN); // False

            //
            Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True

            // When using object.Equals, however, two NaN values are equal: 
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); // True


            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            // get vowels
            string[] list = { "ABC", "Francisco" };
            IEnumerable<string> query = from n in list
                                        where n[0] ==  "F".ToCharArray()[0]
                                        select n;


            //OTHER FORMATS
            decimal value = 123.456m;
            Console.WriteLine("Your account balance is {0:C3}.", value);

            Console.ReadKey();


            string name = "Rob";
            int age = 21;
            Console.WriteLine("Your name is {0} and your age is {1,15:D}", name, age);



            decimal[] amounts = { 16305.32m, 18794.16m };
            Console.WriteLine("   Beginning Balance           Ending Balance");
            Console.WriteLine("   {0,-28:C2}{1,14:C2}", amounts[0], amounts[1]);


            // FORMAT:

            Temperature temp1 = new Temperature(0);
            Console.WriteLine("{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1);
            Console.ReadKey();


            // Use composite formatting with a format provider.
            temp1 = new Temperature(-40);
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)", temp1));
            Console.WriteLine(String.Format(new CultureInfo("fr-FR"), "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1));

            // Call ToString method with format string.
            temp1 = new Temperature(32);
            Console.WriteLine("{0} (Celsius) = {1} (Kelvin) = {2} (Fahrenheit)\n",
                              temp1.ToString("C"), temp1.ToString("K"), temp1.ToString("F"));


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

    public class Temperature : IFormattable
    {
        private decimal temp;

        public Temperature(decimal temperature)
        {
            if (temperature < -273.15m)
                throw new ArgumentOutOfRangeException(String.Format("{0} is less than absolute zero.",
                                                      temperature));
            this.temp = temperature;
        }

        public decimal Celsius
        {
            get { return temp; }
        }

        public decimal Fahrenheit
        {
            get { return temp * 9 / 5 + 32; }
        }

        public decimal Kelvin
        {
            get { return temp + 273.15m; }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    return temp.ToString("F2", provider) + " °C";
                case "F":
                    return Fahrenheit.ToString("F2", provider) + " °F";
                case "K":
                    return Kelvin.ToString("F2", provider) + " K";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
    }

}
