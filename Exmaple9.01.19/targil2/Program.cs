using System;

namespace targil2
{
    class Program
    {
        static void Update(int[] a)
        {
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
            
        }
    }
    // Lo biglal a hu sheve 0
}
