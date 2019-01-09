using System;

namespace Targil3
{
    class Program
    {
        static void Update(int[] a)
        {
            a = new int[3];
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
            
        }

    }
    // Lo biglal she new int = a, a = la 0
}
