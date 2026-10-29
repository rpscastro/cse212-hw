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

        // 1. Create an array of doubles with the size of 'length'.
        double[] multiples = new double[length];
        // 2. Use a for loop to iterate from 0 to length - 1.
        for (int i = 0; i < length; i++)
        {
            // 3. Inside the loop, calculate the multiple by multiplying 'number' with (i + 1) and assign it to the current index of the array.
            multiples[i] = number * (i + 1);
        }
        // 4. After the loop, return the array.
        return multiples; // replace this return statement with your own
   
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

        // 1. Create a new list to hold the last 'amount' elements of the original list.
        List<int> lastElements = data.GetRange(data.Count - amount, amount);
        // 2. Create a new list to hold the first 'data.Count - amount' elements of the original list.
        List<int> firstElements = data.GetRange(0, data.Count - amount);
        // 3. Clear the original list.
        data.Clear();
        // 4. Add the last elements to the original list.
        data.AddRange(lastElements);
        // 5. Add the first elements to the original list.
        data.AddRange(firstElements);

    }
}
