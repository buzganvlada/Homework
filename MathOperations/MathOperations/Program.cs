using System;

public class MathOperations<T> where T : struct, IComparable, IComparable<T>, IEquatable<T>
{
   public T Add(T a, T b)
    {
        dynamic A = a;
        dynamic B = b;
        return A + B;
    }

    public T Substract(T a, T b)
    {
        dynamic A = a;
        dynamic B = b;
        return A - B;
    }
    
    public T Multiply(T a, T b)
    {
        dynamic A = a;
        dynamic B = b;
        return A * B;
    }

    public T Divide(T a, T b)
    {
        dynamic A = a;
        dynamic B = b;
        return A / B;

        if (B == 0)
        {
            throw new ArgumentException("Impartirea la 0 nu exista");
        }
        return A / B;
    }
}