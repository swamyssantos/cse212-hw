using System.Collections.Generic;
        // The Arrays class contains methods for working with arrays and lists.
public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // To create a array to keep the results.
        double[] numbers = new double[length];

        // The array's multiples.
        // The variable i is used to keep track of the index of the array.
        for (int i = 0; i < length; i++)
        {
            numbers[i] = number * (i + 1);
        }
        // Return a result array with the multiples of the number.
        return numbers;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // To repeat the rotation.
        for (int i = 0; i < amount; i++)
        {
            // To keep the last number of the list.
            int last = data[data.Count - 1];

            // To move the numbers to the right. 
            for (int j = data.Count - 1; j > 0; j--)
            {
                data[j] = data[j - 1];
            }

            // To place the last number at the beginning.
            data[0] = last;
        }
    }
}