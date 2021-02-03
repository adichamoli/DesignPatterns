using System;
using System.Threading.Tasks;

namespace ThreadSafeSingletonImpl
{
    public sealed class ThreadSafeSingleton
    {
        ThreadSafeSingleton()
        {
            Console.WriteLine("Hello Singleton");
        }

        private static readonly object padlock = new object();
        private static ThreadSafeSingleton instance = null;

        public static ThreadSafeSingleton getInstance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
    class ThreadSafe
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
