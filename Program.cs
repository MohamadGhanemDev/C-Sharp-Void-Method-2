// summation number between two numbers
class MyClass
{
    static void Main()
    {
        Console.Write("Enter the First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        summation(num1, num2);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter a number to see its factorial: ");
        int fct = Convert.ToInt32(Console.ReadLine());
        factorial(fct);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter the base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exp = Convert.ToInt32(Console.ReadLine());


        power(baseNum , exp );
    }

    static void summation(int num1, int num2)
    {
        int sum = 0;
        for (int i = num1; i <= num2; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("The summation from " + num1 + " to " + num2 + " is " + sum);
    }

    static void factorial(int num)
    {
        int fact = 1;
        for(int i = 1; i<=num; i++)
        {
            fact *=  i;
        }
        Console.WriteLine("The factorial is: " + fact);
    }

    static void power(int basNum, int exponent)
    {
        int result = 1;
        for(int i = 0 ; i< exponent; i++)
        {
            result = basNum * result;
        }
        Console.WriteLine( "the power " + exponent + " of this " + basNum + " is " + result );
    }
}
