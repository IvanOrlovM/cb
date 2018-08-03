using System;

namespace UserProfileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Login = "QWERTY",
                Name = "Vasya",
                SName = "Pumpkin",
                Age = 33,
            };
            Console.WriteLine(user);

            Console.ReadKey();
        }
    }
}
