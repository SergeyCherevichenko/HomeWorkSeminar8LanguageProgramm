namespace Seminar8HomeWork;
class Program
{
        static void Main(string[] args)
    {
        void task54()
        {
            // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
            // двумерного массива.
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // В итоге получается вот такой массив:
            // 7 4 2 1
            // 9 5 3 2
            // 8 4 4 2

            int[,] multarray = MyLib.FillMultArray(3, 4);
            MyLib.PrintMultArray(multarray);
            Console.WriteLine("-----------------------");

            for (int i = 0; i < multarray.GetLength(0); i++)
            {


                for (int j = 0; j < multarray.GetLength(1); j++)

                {
                    int max = multarray[i, j];
                    for (int k = 0; k < multarray.GetLength(1); k++)
                    {
                        if (max > multarray[i, k])
                        {
                            max = multarray[i, j];
                            multarray[i, j] = multarray[i, k];
                            multarray[i, k] = max;
                        }
                    }

                }
            }
            MyLib.PrintMultArray(multarray);


        }

        void task56()
        {
            // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
            // суммой элементов.
            // Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //5 2 6 7
            //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

            int[,] multArray = MyLib.FillMultArray(3, 5);
            MyLib.PrintMultArray(multArray);
            Console.WriteLine("---------------------");
            int minSum = Int32.MaxValue;
            int index = 0;

            for (int i = 0; i < multArray.GetLength(0); i++)
            {
                int sum = 0;


                for (int j = 0; j < multArray.GetLength(1); j++)

                {
                    sum += multArray[i, j];

                }
                if (sum < minSum)
                {
                    minSum = sum;
                    index = i;
                }

            }
            Console.WriteLine($"{index} строка с наименьшей суммой элементов {minSum} ");
        }

        void task58()
        {
            // Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
            // 01 02 03 04
            // 12 13 14 05
            // 11 16 15 06
            // 10 09 08 07

            int height = MyLib.Input("Введите ширину массива: ");
            int weight = MyLib.Input("Введите длинну массива: ");
            int[,] spiralArray = MyLib.SpiralMultArray(height, weight);
            MyLib.PrintMultArray(spiralArray);
        }

        int task = MyLib.Input("Введи номер задачи 54, 56 или 58:");
        switch (task)
        {
            case 54:task54();break;
            case 56:task56();break;
            case 58:task58();break;
            
            default:Console.WriteLine("Такой задачи не сущестыует!");break;
        }
    }
}
