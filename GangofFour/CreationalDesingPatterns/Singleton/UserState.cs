using System;
using System.Collections.Generic;
using System.Text;

namespace GangofFour.CreationalDesingPatterns.Singleton
{
    public sealed class UserState
    {
        private static UserState _instance;
        private static object _lock = new object();

        private UserState() { }


        public static UserState GetSingleton()
        {

            lock (_lock)
            {
                if (_instance is null)
                    _instance = new UserState();
            }

            return _instance;
        }


        public string LoginName { get; set; }

        public short Age { get; set; }
    }
}
