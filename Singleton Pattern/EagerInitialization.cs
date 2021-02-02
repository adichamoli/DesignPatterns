using System;
using System.Threading.Tasks;

namespace EagerInitialization
{
    public sealed class EagerInitializedSingleton
    {
        private static readonly EagerInitializedSingleton instance = new EagerInitializedSingleton();

        //private constructor to avoid client applications to use constructor
        private EagerInitializedSingleton() 
        {
            Console.WriteLine("Hello Singleton");
        }

        public static EagerInitializedSingleton getInstance
        {
            get
            {
                return instance;
            } 
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    class EagerInitialization
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
        }
        private static void PrintTeacherDetails()
        {
            EagerInitializedSingleton fromTeacher = EagerInitializedSingleton.getInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        
        private static void PrintStudentdetails()
        {
            EagerInitializedSingleton fromStudent = EagerInitializedSingleton.getInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
