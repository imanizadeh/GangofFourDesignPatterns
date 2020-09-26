using GangofFour.CreationalDesingPatterns.Singleton;
using System;

namespace GangofFour
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Singleton

            UserState user = UserState.GetSingleton();
            user.LoginName = "imanizadeh.me";
            user.Age = 28;


            UserState user2 = UserState.GetSingleton();
            Console.WriteLine(user2.LoginName);
            Console.WriteLine(user2.Age);
            Console.WriteLine(user == user2); 

            #endregion






            Console.ReadKey();
        }
    }
}
