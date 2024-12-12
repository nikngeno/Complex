public struct Complex
{
    public int Real;
    public int Imaginary;

    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public double Abs()
    {
        return Math.Sqrt(Real * Real + Imaginary * Imaginary);
    }

    public static bool Compare(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imaginary == b.Imaginary;
    }
}
