using System;

namespace Singleton
{
    public class Administrator
    {
        static Administrator administrator;
        protected Administrator()
        {
            Console.WriteLine("Hi! New administrator");
        }
        public static Administrator Instance()
        {
            if (administrator == null)
                administrator = new Administrator();
            else
                Console.WriteLine("The administrator is already registered");
            return administrator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Administrator u = new Administrator();
            Administrator a = Administrator.Instance();
            Administrator b = Administrator.Instance();
        }
    }
}
