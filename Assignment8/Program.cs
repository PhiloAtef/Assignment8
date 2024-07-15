using Assignment8.Binding;
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

        public static void ProcessEmployee(Employee employee)
        {
            if (employee != null) 
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }

        static void Main(string[] args)
        {
            #region Polymorphism - Overloading
            //int result = Sum(1, 2,3,4);
            //Console.WriteLine(result); 
            #endregion

            #region Binding
            //TypeA typeA = new TypeA(1);
            //typeA.A = 2;

            //typeA.MyFunc01();
            //typeA.MyFunc02();

            //TypeB typeB = new TypeB(1,2);

            //typeB.A = 3;
            //typeB.B = 4;
            //typeB.MyFunc01();
            //typeB.MyFunc02();

            ////binding 

            //TypeA refbase = new TypeB(1, 2);
            //refbase.MyFunc01();
            //refbase.MyFunc02(); 
            #endregion

            #region Not Binding
            //TypeA typeA = new TypeB(1, 2);
            //typeA = new TypeA(1);

            //TypeB typeB = (TypeB)typeA; //casting 
            #endregion

            Employee fullTimeEmployee = new FullTimeEmployee() { Name = "example", ID = 10, Age = 20, Salary = 3000 };

            Employee partTimeEmployee = new PartTimeEmployee() { Name = "example2", ID = 12, Age = 22, HourRate = 3200 };

            ProcessEmployee(fullTimeEmployee);
            ProcessEmployee(partTimeEmployee);

            Employee employee = new Employee();
            FullTimeEmployee fullTimeEmployee2 = new FullTimeEmployee();
            PartTimeEmployee partTimeEmployee2 = new PartTimeEmployee();
            Employee employee1 = new FullTimeEmployee();
            Employee employee2 = new PartTimeEmployee();

            ProcessEmployee(employee);
            ProcessEmployee(fullTimeEmployee2);
            ProcessEmployee(partTimeEmployee2);
            ProcessEmployee(employee1);
            ProcessEmployee(employee2);


            

        }


    }
}
