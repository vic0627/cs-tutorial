class Array
{
    public Array()
    {
        /*
            Syntax:
            type[] arrayName;
         */
        int[] intArr;
        intArr = new int[5];
        // or
        int[] intArr2 = new int[5];
        // Both variables above haven't initialized, they will take the default value of the `int` type, which is `0`.

        intArr[0] = 1; // Use the square bracket `[]` with an index to access an element of an array.

        /*
            Array initialization expression
         */
        int[] scores = { 1, 2, 3, 4, 5 };

        Console.WriteLine(scores.Length); // get the size of an array

        /*
            Indices
            Indices allow you to reference the elements relative to the end of the array with the `^` operator and an index.
         */
        Console.WriteLine(scores[^1]); // => 5
        Console.WriteLine(scores[^2]); // => 4

        /*
            `Index` type allows you to access an array element using a variable instead of a literal integer.
         */
        Index lastIndex = ^1;
        Console.WriteLine(scores[lastIndex]); // => 5

        /*
            Ranges
            Slicing an array by using `..` operator, it will always return a new array.
            - arr[..N] - the first `N` elements
            - arr[N..] - all the elements starting from the `N` element to the end of the array.
            - arr[N..M] - the elements from the `N` to `M` element.
         */
        Console.WriteLine(scores[..2]); // => 1 2
        Console.WriteLine(scores[2..]); // => 3 4 5
        Console.WriteLine(scores[1..3]); // => 2 3

        /*
            `Range` type allows you to slice an array using a variable.
         */
        Range r = 1..3;
        Console.WriteLine(scores[r]); // => 2 3
    }

    public static void MultidimensionalArrays()
    {
        /*
            Syntax:
            type[commas] variableName = new type[lengthOfEachDimension]

            The comma `,` inside the square brackets denotes the number of dimensions.
         */

        // Two-dimensional array (or 2D array) of 2 rows and 3 columns.
        int[,] matrix = new int[2, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        // Three-dimensional array (or 3D array) without initialization.
        int[,,] tensor = new int[3, 3, 3];

        // Accessing array elements
        Console.WriteLine(matrix[0, 0]); // => 1

        // Getting dimension length
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Iterate through the first dimension of `matrix` here.
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Iterate through the second dimension of `matrix` here.
                matrix[i, j] = i + j;
            }
        }
    }

    public static void ForEach()
    {
        /*
            Syntax:
            foreach (type variableName in iterableObject)
            {
                statement
            }

            The `foreach` statement doesn't allow you to change the array elements, which means you can't reassign a value to `variableName`.
            If the mutation of elements is required, use the `for` statement instead.
         */

        int[] scores = { 5, 3, 4, 1, 2 };
        foreach (int score in scores)
        {
            Console.Write($"{score} "); // => 5 3 4 1 2
        }

        /*
            For a multidimensional array, the `foreach` statement increases the indices of the rightmost dimension first and then the next left dimension, and so on to the left.
         */
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        foreach (var e in matrix)
        {
            Console.Write($"{e} "); // => 1 2 3 4 5 6
        }
    }
}
