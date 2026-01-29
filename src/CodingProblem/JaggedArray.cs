namespace CodingProblem
{
    internal class JaggedArray
    {

        internal static void JaggedArrayDemo()
        {
            // Declare a jagged array with 3 rows
            int[][][] jaggedArray = new int[3][][];

            // Initialize the rows with different lengths
            jaggedArray[0] = new int[2][];
            jaggedArray[0][0] = new int[] { 1, 2, 3 };
            jaggedArray[0][1] = new int[] { 4, 5 };

            jaggedArray[1] = new int[1][];
            jaggedArray[1][0] = new int[] { 6, 7, 8, 9 };

            jaggedArray[2] = new int[3][];
            jaggedArray[2][0] = new int[] { 10 };
            jaggedArray[2][1] = new int[] { 11, 12 };
            jaggedArray[2][2] = new int[] { 13, 14, 15 };

            // Print the jagged array to the console
            Console.WriteLine("Jagged Array Contents:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i}:");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"  SubArray {j}: ");
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Console.Write($"{jaggedArray[i][j][k]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
