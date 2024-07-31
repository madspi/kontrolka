
public class HomeWork
{
    public static int Main()
    {
        var input = Console.ReadLine().Split(',');
        PrintLess4(input);
        return 0;
    }

    private static void PrintLess4(string[] input)
    {
        var count = input.Length - 1;
        for (int i  = 0; i < count; i++)
        {
            if (input[i].Length < 4)
            {
                Console.Write(input[i] + ",");
            }
        }
        if (count >= 0 && input[count].Length < 4)
        {
            Console.Write(input[count]);
        }
    }
}