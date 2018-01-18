using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式.Models
{
    class Singleton
    {

        private static Singleton _singleton;

        public static Singleton GetSingleton()
        {
            if (_singleton==null)
            {
                _singleton=new Singleton();
            }

            return _singleton;
        }



        private Singleton()
        {
            
        }
    }
}
