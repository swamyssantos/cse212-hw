public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] result = new int[select.Length];
        int array1Index = 0;  // This variable receives the index of the next element to be selected from list1
        int array2Index = 0;
        for (int i = 0; i < select.Length; i++) // The loop  for array1 and array2 is controlled by the select array. 
        {
            if (select[i] == 1) // The condition that checks if the value of the select array 
                                // is 1 or 2. If it is 1, the next element from list1 is selected. 
                                // If it is 2, the next element from list2 is selected.
            {
                result[i] = list1[array1Index];
                array1Index++;
            }
            else if (select[i] == 2) // If it is 2, the next element from list2 is selected.
            {
                result[i] = list2[array2Index]; // The next element from list2 is selected and stored in the result array.
                array2Index++;
            }
        }
        return result; // The result array is returned after the loop is completed.
        
    }
}