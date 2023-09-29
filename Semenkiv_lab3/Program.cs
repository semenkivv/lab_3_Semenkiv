using System;

namespace Laba_3_V_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 907:");
            Task_907();
            Console.WriteLine();

            Console.WriteLine("Задание 914");
            Task_914();
            Console.WriteLine();

            Console.WriteLine("Задание 933");
            Task_933();
            Console.WriteLine();

            Console.WriteLine("Задание 970");
            Task_970();
            Console.WriteLine();

        }
        /// <summary>
        ///  Найти суммы элементов Двумерного массива целых чисел, расположенных на линиях, 
        ///  параллельных главной диагонали, и ниже нее.
        /// </summary>
        private static void Task_907()
        {
            Random random = new();
            int rows = 4;
            int cols = 6;
            int[,] array = new int[rows, cols];
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            Console.WriteLine("Линиии паралельные под главной диагональю:");
            for (int i = 1 ; i < rows-1; i++)
            {
                Console.Write("Линия:");

                for (int j = 0; j < cols && i+j<rows; j++)
                {
                    Console.Write($"{array[i+j, 0+j]} ;");
                    sum += array[i + j, 0 + j];
                }
                Console.WriteLine("");
                Console.WriteLine("Сумма елементов = "+sum);
                sum = 0;
            }

            Console.WriteLine("Линиии паралельные над главной диагональю:");
            for (int i = 1; i < cols - 1; i++)
            {
                Console.Write("Line:");

                for (int j = 0; j < rows && i + j < cols; j++)
                {
                    Console.Write($"{array[0 + j, i + j]} ;");
                    sum += array[0 + j, i + j];
                }
                Console.WriteLine("");
                Console.WriteLine("Сумма елементов = " + sum);
                sum = 0;
            }
        }
        /// <summary>
        ///  Найти номер столбца Двумерного массива целых чисел, для которого среднеарифметическое значение 
        ///  его элементов максимально.
        /// </summary>
        private static void Task_914()
        {
            Random random = new();
            int rows = 4;
            int cols = 6;
            int[,] array = new int[rows, cols];
            double[] arrayAverageColumns = new double[cols];
            double sumElements = 0;
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    sumElements += array[i, j];
                }
                arrayAverageColumns[j] = sumElements / rows;
                sumElements = 0;
            }

            int maxIndex = 0; 
            double maxValue = arrayAverageColumns[0]; 
            for (int i = 1; i < arrayAverageColumns.Length; i++)
            {
                if (arrayAverageColumns[i] > maxValue)
                {
                    maxValue = arrayAverageColumns[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine("Индекс столбца двумерного массива , для которого среднеарифметическое значение  его элементов максимально = "+maxIndex);
        }
        /// <summary>
        /// Отсортировать нечетные столбцы массива по возрастанию.
        /// </summary>
        private static void Task_933()
        {
            Random random = new();
            int rows = 4;
            int cols = 6;
            int[,] array = new int[rows, cols];
            double[] arrayAverageColumns = new double[cols];
            Console.WriteLine("Двумерный массив до:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < cols; i += 2)
            {
                int[] columnToSort = new int[rows];
                for (int j = 0; j < rows; j++)
                {
                    columnToSort[j] = array[j, i];
                }
                Array.Sort(columnToSort);
                for (int j = 0; j < rows; j++)
                {
                    array[j, i] = columnToSort[j];
                }
            }

            Console.WriteLine("Двумерный массив после:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// В Двумерном массиве хранится информация о зарплате 18 человек за каждый месяц года 
        /// (в первом столбце — зарплата за январь, во втором — за февраль и т. д.). 
        /// Составить программу для расчета средней зарплаты за любой месяц.
        /// </summary>
        private static void Task_970()
        {
            Random random = new();
            int rows = 18;
            int cols = 12;
            int[,] array = new int[rows, cols];
            Console.WriteLine("Информация о зарплате 18 человек за каждый месяц года");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1000, 15000);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            int countMonth = random.Next(1, 12);
            int sumElements = 0;

            for (int i = 0; i < rows; i++)
            {
                sumElements += array[ i, countMonth - 1]; 
            }
            double averageSalary = Math.Round((double)sumElements / rows,1);

            Console.WriteLine($"Средняя зарплата за месяц {countMonth}: {averageSalary}");
        }

    }
}
