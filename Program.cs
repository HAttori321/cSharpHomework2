namespace cSharpHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int[]array= {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int CountEven = 0;
            int CountOdd = 0;
            int UniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    CountEven++;
                }
                else
                {
                    CountOdd++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    UniqueCount++;
                }
            }
            Console.WriteLine("Even numbers count: " + CountEven);
            Console.WriteLine("Odd numbers count: " + CountOdd);
            Console.WriteLine("Unique numbers count: " + UniqueCount);

            //****************************TASK2*******************************

            int[]array1= {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Enter the threshold value : ");

            int threshold = int.Parse(Console.ReadLine());

            int LessThanThreshold = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < threshold)
                {
                    LessThanThreshold++;
                }
            }
            Console.WriteLine("Numbers less than threshold: " + LessThanThreshold);

            //****************************TASK3*******************************

            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Random random = new Random();

            Console.WriteLine("Enter 5 integers for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * 100;
                }
            }

            Console.WriteLine("Array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            double maxElement = double.MinValue;
            double minElement = double.MaxValue;
            double totalSum = 0;
            double totalProduct = 1;

            foreach (int value in A)
            {
                if (value > maxElement) maxElement = value;
                if (value < minElement) minElement = value;
                totalSum += value;
                totalProduct *= value;
            }

            foreach (double value in B)
            {
                if (value > maxElement) maxElement = value;
                if (value < minElement) minElement = value;
                totalSum += value;
                totalProduct *= value;
            }

            int sumEvenA = 0;
            foreach (int value in A)
            {
                if (value % 2 == 0)
                {
                    sumEvenA += value;
                }
            }

            double sumOddColumnsB = 0;
            for (int j = 1; j < B.GetLength(1); j += 2)
            {
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine("Max element: " + maxElement);
            Console.WriteLine("Min element: " + minElement);
            Console.WriteLine("Total sum: " + totalSum);
            Console.WriteLine("Total product: " + totalProduct);
            Console.WriteLine("Sum of even elements in A: " + sumEvenA);
            Console.WriteLine("Sum of odd columns in B: " + sumOddColumnsB);







        }
    }
}
