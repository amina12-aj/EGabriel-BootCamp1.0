// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class program
{
    public static int p1 = 0;
    public static int p2 = 1;
    public static int p3;
    static void Main(string[] args)
    {
        static void fibo(int number)
        {
            for (int i = 2; i < number; i++)
            {
                p3 = p1 + p2;
                p1 = p2;
                p2 = p3;

            }
            fibo(10);

        }

    }
}

