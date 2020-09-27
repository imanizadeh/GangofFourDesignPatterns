using System;
using System.Collections.Generic;
using System.Text;

namespace GangofFour.CreationalDesingPatterns.Singleton
{
    public sealed class GenericSingleton<T> where T : class, new()
    {
        private static T _singletoneInstance;
        private static object _lock = new object();

        public static T GetSingleton()
        {
            //این شرط باعث می شود اگر نمونه کلاس قبلا ایجاد شده است دیگر نخ ها بلاک نشوند
            if (_singletoneInstance == null)
            {
                lock (_lock)
                {
                    if (_singletoneInstance == null)
                        _singletoneInstance = new T();
                }
            }
            return _singletoneInstance;
        }
    }
}
