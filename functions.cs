class Functions
{
    public Functions()
    {
        /*
            Syntax:
            modifiers returnType functionName(argumentType argumentName)
            {
                statement
            }
         */
    }

    /*
        In order to create a comment section for a function, entering three forward slashes `///` right before the function header.
     */

    /// <summary>
    /// Calculate the body mass index (BMI) based on weight in kg and height in meter.
    /// </summary>
    /// <param name="weight">
    /// The weight in kilogram.
    /// </param>
    /// <param name="height">
    /// The height in meter.
    /// </param>
    /// <returns>
    /// The body mass index.
    /// </returns>
    public static double CalcBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    /* 
        Specifying the default arguments.
     */
    public static double CalcPrice(double sellingPrice, double salesTax = 0.08)
    {
        return sellingPrice * (1 + salesTax);
    }
}
