using System;
using System.Collections.Generic;
using System.Text;

namespace GangofFour.CreationalDesingPatterns.Singleton
{
    //از خاصیت sealed استفاده شده تا کسی نتواند از کلاس ارث بری کند
    public sealed class UserState
    {
        private static UserState _instance;
        private static object _lock = new object();

        private UserState() { }

        public static UserState GetSingleton()
        {
            //این شرط باعث می شود اگر نمونه کلاس قبلا ایجاد شده است دیگر نخ ها بلاک نشوند
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new UserState();
                }
            }
            return _instance;
        }


        public string LoginName { get; set; }

        public short Age { get; set; }

        public string ShowInfo()
        {
            return $"{LoginName} {Age}";
        }
    }
}
