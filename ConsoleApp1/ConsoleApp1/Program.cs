public class Program
{
    public static void Main(string[] args)
    {
        int[] data = {34,12,35,62,32,12,65,15,97,46,74};
        ArytmeticAverage(data);
    }

    public static void ArytmeticAverage(int[] data)
    {
        int avr = 0;
        foreach (int number in data)
            avr += number;
        avr /= data.Length;
        Console.WriteLine("Average value: " + avr);
    }
}