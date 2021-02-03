using System;
using System.Threading.Tasks;

namespace LazyInitializedSingletonImpl
{
    public sealed class LazyInitializedSingleton
    {
        private LazyInitializedSingleton()
        {
            Console.WriteLine("Hello Singleton");
        }

        public static LazyInitializedSingleton getInstance
        {
            get
            {             
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
                Console.WriteLine("Hello Singleton Nested");
            }

            internal static readonly LazyInitializedSingleton instance = new LazyInitializedSingleton();
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
    class LazyInitialization
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
            LazyInitializedSingleton fromTeacher = LazyInitializedSingleton.getInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentdetails()
        {
            LazyInitializedSingleton fromStudent = LazyInitializedSingleton.getInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
