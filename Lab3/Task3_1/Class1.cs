using System;

namespace MyNamespace
{
    public class Numbers
    {
        public static int MyFunc(int x)
        {
            if (Math.Abs(x) > 9 && Math.Abs(x) < 100)
                return x % 10 * 10 + x / 10;
            return x;
        }
    }
}
