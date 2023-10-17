class Flow
{
    private bool condition = false;
    private int n = 0;
    private string str = "ABCDEFG";

    public Flow() { }

    public void If()
    {
        // single statement
        if (condition)
            condition = !condition;

        // multi statement
        if (condition)
        {
            condition = !condition;
            return;
        }
    }

    public void IfElse()
    {
        if (condition)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public void ElseIf()
    {
        if (n == 0)
        {
            n++;
        }
        else if (n < 0)
        {
            n = 0;
        }
        else
        {
            Console.WriteLine(n);
        }
    }

    public void Switch()
    {
        switch (n)
        {
            case < 0:
                n++;
                break;
            case > 0
            and < 10:
                n--;
                break;
            default:
                n = 100;
                break;
        }
    }

    public void While()
    {
        while (n < 0)
        {
            n++;
        }
    }

    public void DoWhile()
    {
        do
        {
            n++;
        } while (n < 0);
    }

    public void For()
    {
        /*
            Syntax:
            
            ```
            for (initializer; condition; iterator)
            {
                // statement
            }
            ```

            - initializer:
                The `for` statement executes the `initializer` only once before entering the loop.
                Typically, you declare and initialize a local loop variable in the initializer.
                You can't access the variable which you declare in the initializer outside the `for` statement.

            - condition:
                The `condition` is a boolean expression that determines whether the `for` statement should execute the next iteration.
                The `for` statement evaluates the `condition` before each iteration.

            - iterator:
                The `for` statement executes the `iterator` after each iteration.
         */
        for (var i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[i]);
        }

        /*
            The `initializer`, `condition`, and `iterator` are optional in the `for` statement.
            In this case, you need to use the `break` statement to terminate the loop at some point to avoid an indefinite loop.
         */
        int j = 0;
        for (; ; )
        {
            j++;
            if (j > 10)
                break;
        }
    }
}
