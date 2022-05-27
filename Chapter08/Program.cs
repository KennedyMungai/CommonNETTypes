using System.Numerics;

using static System.Console;

namespace CommonNETTypes.Chapter08;

public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Working with large integers");
        WriteLine("----------------------------");

        ulong big = ulong.MaxValue;
        WriteLine($"{big,40:N0}");

        BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");

        WriteLine($"{bigger,40:N0}");
    }
}