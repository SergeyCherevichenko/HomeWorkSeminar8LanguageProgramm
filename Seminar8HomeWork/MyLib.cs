namespace Seminar8HomeWork;
class MyLib
{

 public static int[,] FillMultArray(int height, int width)
    {
        Random random = new Random();
        int[,] multArray = new int[height, width];
        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                multArray[i, j] = random.Next(0, 10);
            }
        }
        return multArray;
    }
    public static void PrintMultArray(int[,] multArray)
    {
        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                Console.Write(multArray[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] SpiralMultArray(int height, int width)
    {
        int[,] multArray = new int[height, width];
        int num = 1;
        int max = multArray.GetLength(0) * multArray.GetLength(1);
        int rowMin = 0;
        int rowMax = multArray.GetLength(0) - 1;
        int columnMin = 0;
        int columnMax = multArray.GetLength(1) - 1;
        while (num <= max)
        {
            for (int i = columnMin; num <= max && i <= columnMax; i++)
            {
                multArray[rowMin, i] = num;
                num++;
            }
            rowMin++;
            for (int i = rowMin; i <= rowMax && num <= max; i++)
            {
                multArray[i, columnMax] = num;
                num++;
            }
            columnMax--;
            for (int i = columnMax; i >= columnMin && num <= max; i--)
            {
                multArray[rowMax, i] = num;
                num++;
            }
            rowMax--;
            for (int i = rowMax; i >= rowMin && num <= max; i--)
            {
                multArray[i, columnMin] = num;
                num++;
            }
            columnMin++;
        }
        return multArray;
    }
    public static int Input(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
}
