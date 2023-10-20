using System.Data;
using System.Numerics;

namespace Indexer;

class Introduction
{
    /*
        An index allows an object of a class to be indexed like an array.

        Syntax:

        ```
        class MyClass
        {
            public type this[int index]
            {
                get { // return a value }
                set { // return a value }
            }
        }
        ```

        To define the indexer, using `this` keyword is required.
        The parameter's type of the indexer depends on how you design the look-up mechanism, so it doesn't have to be integer.
        Also, an indexer can have more than one parameter.
        Indexers can be overloaded. In other words, a class can have multiple indexers.

        If omiting the `set` accessor, the indexer becomes read-only.
        In this case, you can use expression-bodied syntax to shorten its definition:

        ```
        class MyClass
        {
            public type this[int index] => returnValue
        }
        ```

        Starting with C# 7, you can use expression-bodied syntax for both `get` and `set` accessors.

        ```
        class MyClass
        {
            public type this[int i]
            {
                get => member[i];
                set => member[i] = value;
            }
        }
        ```
     */
}

class Sentence
{
    // Indexer only with `get` accessor which is omited
    public string this[int index] => words[index];

    private string[] words;

    public Sentence(string s)
    {
        words = s.Split(' ');
    }
}

// Multidimensional array
class Matrix
{
    // Indexer with both `get` and `set` accessors
    public double this[int row, int column]
    {
        get => data[row, column];
        set { data[row, column] = value; }
    }

    private double[,] data;

    public Matrix(int row, int column)
    {
        data = new double[row, column];
    }
}

class ClientCode
{
    public ClientCode()
    {
        Sentence sentence = new("C# is awesome");

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine(sentence[i]);
            // => C#
            // => is
            // => awesome
        }

        Matrix matrix = new(3, 3);

        void SetMatrix(int i, int j)
        {
            matrix[i, j] = i + j;
        }

        void PrintMatrix(int i, int j)
        {
            Console.WriteLine(matrix[i, j]);
        }

        TraverseMatrix(3, SetMatrix);

        TraverseMatrix(3, PrintMatrix);

        /*
            Object initializer
         */
        Matrix matrix1 =
            new(2, 2)
            {
                [0, 0] = 0,
                [0, 1] = 1,
                [1, 0] = 2,
                [1, 1] = 3,
            };
    }

    private delegate void MatrixDelegate(int i, int j);

    private static void TraverseMatrix(int depth, MatrixDelegate action)
    {
        for (int i = 0; i < depth; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                action(i, j);
            }
        }
    }
}
