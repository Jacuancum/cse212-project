public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Planing
        // Step 1. Create an array of doubles, and give it the size length
        // Step 2. Use a for loop
        // Step 3. In each number, multiplying the number with (i + 1)
        // Step 4. Return the result
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Planing
        // Step 1. Create a new list of integers, and give it the size data.Count
        // Step 2. Use a for loop
        // Step 3. if the index is less than amount, add the data at index to new list
        //         if it is not, add the data at index (i - amount) to new list
        // Step 4. Clear data
        // Step 5. Add the new list to data
        List<int> result = new List<int>(new int[data.Count]);
        for (int i = 0; i < data.Count; i++)
        {
            if (i < amount)
            {
                result[i] = data[data.Count - amount + i];
            }
            else
            {
                result[i] = data[i - amount];
            }
        }
        data.Clear();
        data.AddRange(result);
    }
}
