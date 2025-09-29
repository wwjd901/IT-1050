namespace Lab4;

class Program
{
    static void Main(string[] args)

    {  // Print numbers from 1 to 10 Lab 4.1
        Console.WriteLine("Lab 4.1");
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
        // Print even numbers from 1 to 20  Lab 4.2
        Console.WriteLine("Lab 4.2");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Print numbers from n to 1 Lab 4.3
        Console.WriteLine("Lab 4.3");
        int n = 5;
        while (n >= 1)
        {
            Console.WriteLine(n);
            n--;
        }
        // Print User entered given number Lab 4.4
        Console.WriteLine("Lab 4.4");
        int number;

do
{
    Console.Write("Enter a number greater than 100: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number <= 100);

        Console.WriteLine("Thank you! You entered: " + number);

        // Print multiples of 10 from 10 to 1000 Lab 4.5  
        Console.WriteLine("Lab 4.5");

        int m = 10;

while (m <= 1000)
{
    Console.WriteLine(m);
    m += 10;
}
    // Lab 4.6
        Console.WriteLine("Lab 4.6");
        for (int l = 1; l <= 10; l++)
{
    for (int j = 1; j <= l; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
    }
}
