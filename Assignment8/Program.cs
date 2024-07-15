using Assignment8.Overriding;

namespace Assignment8
{
    internal class Program
    {
        #region Polymorphism - Overloading
        //public static int Sum(int x, int y) 
        //{
        //    return x + y;
        //}

        //public static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public static int Sum(int x, int y, int z, int d)
        //{
        //    return x + y + z + d;
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism - Overloading
            //int result = Sum(1, 2,3,4);
            //Console.WriteLine(result); 
            #endregion

            TypeA typeA = new TypeA(1);
            typeA.A = 2;

            typeA.MyFunc01();
            typeA.MyFunc02();
        }
    }
}
