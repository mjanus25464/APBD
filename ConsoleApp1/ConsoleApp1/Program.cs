public class Program
{
    public static void Main(string[] args)
    {
        int[] data = {34,12,35,62,32,12,65,15,97,46,74};
        ArytmeticAverage(data);
        FindMax(data);
    }

    public static void ArytmeticAverage(int[] data)
    {
        int avr = 0;
        foreach (int number in data)
            avr += number;
        avr /= data.Length;
        Console.WriteLine("Average value: " + avr);
    }
    
    private static void FindMax(int[] data)
    {
        int maxVal = data[0];
        
        for(int i = 1; i<data.Length; i++)
            if (maxVal < data[i])
                maxVal = data[i];
        Console.WriteLine("Maximum value: " + maxVal);
    }
}