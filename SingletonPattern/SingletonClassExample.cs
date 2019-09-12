using System;

namespace SingletonPattern
{
    class SingletonClassExample
    {
        private static SingletonClassExample _instance;
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
        }

        private SingletonClassExample(Guid id)
        {
            _id = id;
        }

        public static SingletonClassExample GetInstance()
        {
            if (_instance == null)
                _instance = new SingletonClassExample(Guid.NewGuid());

            return _instance;
        }
    }
}
