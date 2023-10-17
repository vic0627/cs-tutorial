class Float
{
    public Float()
    {
        /*
            The characteristics of the floating-point types:
         */
        float a = 0.34f; // ±1.5 x 10^-45 ~ ±3.4 x 10^38 | ~6-9 digits | 4 bytes
        double b = 2.5d; // ±5.0 × 10^-324 ~ ±1.7 × 10^308 | ~15-17 digits | 8 bytes
        decimal c = 3.158m; // 	±1.0 x 10^-28 ~ ±7.9228 x 10~28 | 28-29 digits | 16 bytes

        /*
            Equality test
            The following expression should return `true`, but it returns `false` instead
            The reason is that the expression returns a value that is approximately equal to 0.3, not 0.3
         */
        bool res = 0.3 == 0.1 + 0.1 + 01;
        Console.WriteLine(res);
        Console.WriteLine(0.1 + 0.1 + 0.1); // 0.30000000000000004
    }

    public static void FloatLiterals()
    {
        /*
            The float literals have the `f` or `F` suffix
         */
        float rate = 5.2F;
        float amount = 10_000.5f;

        /*
            The double literals could have the `d` or `D` for suffix
         */
        double dimension = 3.14;
        double radius = 1_000.5d;

        /*
            The decimal literals have `m` or `M` suffix
         */
        decimal amount2 = 0.99m;
        decimal tax = 0.08M;
    }
}
