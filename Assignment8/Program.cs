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

            TypeB typeB = new TypeB(1,2);

            typeB.A = 3;
            typeB.B = 4;
            typeB.MyFunc01();
            typeB.MyFunc02();

            //binding 

            TypeA refbase = new TypeB(1, 2);
            refbase.MyFunc01();
            refbase.MyFunc02();


        }


    }
}
