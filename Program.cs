using System;

namespace PartialClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of user class which is partial.
            //This partial class is created in two different files as UserRegister.cs and UserLogin.cs.
            //At run time both classes are compiled as single class. So all methods of both classes can be accessed using User class object.

            User _user = new User();

            //Register user
            if (_user.Register("test", "test1234"))
            {
                Console.WriteLine("User Registered Successfully");
            }

            //Authenticate user
            if (_user.Login("test", "test1234"))
            {
                Console.WriteLine("User Authenticated Successfully");
            }

            Console.ReadLine();
        }
    }
}
