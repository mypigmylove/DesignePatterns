using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单例模式.Models
{
    class LoaderBalence
    {
        private static LoaderBalence _instance = null;

        private List<CustomServer> _customServerList;


        private LoaderBalence()
        {
            _customServerList=new List<CustomServer>();
        }


        public static LoaderBalence GetInstance()
        {
            if (_instance==null)
            {
                _instance=new LoaderBalence();
            }

            return _instance;
        }


        public void AddCustom(CustomServer cs)
        {
            this._customServerList.Add(cs);
        }

        public void RemoveCustome(CustomServer cs)
        {

            _customServerList.Remove(_customServerList.Find(server => server.Name.Equals(cs.Name)));
        }


        private Random _random=new Random();

        public CustomServer GetServer()
        {
            int index = _random.Next(_customServerList.Count);
            return _customServerList[index];
        }

    }
}
