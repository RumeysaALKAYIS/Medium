namespace SteakHeapRef
{
    public static class Methots
    {
        public static void Methot(int number, double decimalNumber, char a, string text, int[] array ,MyClass myClass)
        {
            Console.WriteLine($"Int          :{number}");
            Console.WriteLine($"Double       :{decimalNumber}");
            Console.WriteLine($"Char         :{a}");
            Console.WriteLine($"String       :{text}");
            Console.WriteLine($"Array        :{array[0]}");
            Console.WriteLine($"Array        :{array[1]}");
            Console.WriteLine($"Array        :{array[2]}");
            Console.WriteLine($"Class.Number :{myClass.Number}");
            Console.WriteLine($"Class.Text   :{myClass.Text}");

            number = 3;
            decimalNumber = 3.03;
            a = 'b';
            text = "second value";
            array[0] = 100;
            array[1] = 110;
            array[2] = 120;
            myClass.Number = 10;
            myClass.Text = "second value";
        }

        public static void Methot(ref int number, ref double decimalNumber, ref char a,  ref string text, ref int[] array, ref MyClass myClass)
        {
            Console.WriteLine($"Real Value for adress Int          :{number}");
            Console.WriteLine($"Real Value for adress Double       :{decimalNumber}");
            Console.WriteLine($"Real Value for adress Char         :{a}");
            Console.WriteLine($"Real Value for adress String       :{text}");
            Console.WriteLine($"Real Value for adress Array        :{array[0]}");
            Console.WriteLine($"Real Value for adress Array        :{array[1]}");
            Console.WriteLine($"Real Value for adress Array        :{array[2]}");
            Console.WriteLine($"Real Value for adress Class.Number :{myClass.Number}");
            Console.WriteLine($"Real Value for adress Class.Text   :{myClass.Text}");
        }
    }


}
