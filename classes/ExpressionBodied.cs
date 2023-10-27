namespace ExpressionBodied;

class Introduction
{
    private string firstName;
    private string lastName;

    /*
        Purpose:
            To make the code concise and more readable.

        Syntax:

        ```
        member => expression;
        ```

        - `member` - It can be a method, a property, a constructor, a finalizer, or an indexer.
        - `expression` - It can be any valid expression.
     */

    /*
        [Methods]
        If a method has a single expression that returns a value whose type matches the method's return type,
        you can use an expression body definition.
     */
    public static string MergeTwoString(string str1, string str2) => $"{str1}{str2}";

    /*
        [Read-only properties]
        Starting with C#6, you can use expression body definition for a read-only property.
     */
    public string MyName => $"{firstName} {lastName}";

    /*
        [Constructors]
     */
    public Introduction(string firstName, string lastName) =>
        (this.firstName, this.lastName) = (firstName, lastName);

    /*
        [Indexers]
     */
    public string this[int offset] => MyName.Split(" ")[offset];
}
