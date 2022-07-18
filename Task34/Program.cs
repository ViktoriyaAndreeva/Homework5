namespace Homework5
{
    class Task34
    {
    // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

        public static void Main()   
        {
                        
        PrintCount(Random()); 
        }

        static int[] Random()
        {
            int a = new Random().Next(5, 10);
            int[]array = new int[a];
                                                            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
                Console.WriteLine(array[i]);
            }
            return array;                   
        }
        static void PrintCount(int[] array)
        {
            int count = 0;
                   
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество четных числе: {count}");
        }
        
    }
}    