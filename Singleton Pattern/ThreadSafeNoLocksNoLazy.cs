using System;
using System.Threading.Tasks;

namespace ThreadSafeSingletonImpl
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = new ThreadSafeSingleton();
        
        static ThreadSafeSingleton()
        {
            Console.WriteLine("Hello Singleton Static");
        }

        private ThreadSafeSingleton()
        {
            Console.WriteLine("Hello Singleton");
        }

        public static ThreadSafeSingleton getInstance
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
    class ThreadSafeNoLocksNoLazy
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
            ThreadSafeSingleton fromTeacher = ThreadSafeSingleton.getInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentdetails()
        {
            ThreadSafeSingleton fromStudent = ThreadSafeSingleton.getInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
