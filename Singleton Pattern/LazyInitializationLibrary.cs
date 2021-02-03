using System;
using System.Threading.Tasks;

namespace LazyInitializedSingletonImpl
{
    public sealed class LazyInitializedSingleton
    {
        private static readonly Lazy<LazyInitializedSingleton> lazy =
                                new Lazy<LazyInitializedSingleton>
                                (() => new LazyInitializedSingleton());

        public static LazyInitializedSingleton getInstance 
        { 
            get 
            { 
                return lazy.Value; 
            } 
        }

        private LazyInitializedSingleton()
        {
            Console.WriteLine("Hello Singleton");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
    class LazyInitializationLibrary
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
