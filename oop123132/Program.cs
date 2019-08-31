using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop123132
{
    class MyList
    {
        private int _i;
        private object[] _objects;
        object[] objects = new object[9];
        public void Add(object obj)
        {
            int i = 0;
            objects[i] = obj;
            i++;
        }
        public void Insert(int i, object obj)
        {
            objects[i] = obj;
        }
        public void Remove(int i, object obj)
        {
            foreach(object a in objects)
            {
                if (objects[i] == obj)
                {
                    objects[i] = null;
                }
            }
        }
        public void RemoveAt(int i)
        {
            objects[i] = null;
        }
        public void Clear()
        {
            objects = null;
        }
        public bool Contains(object obj)
        {
            foreach( var i in objects)
            {
                if(i == obj)
                {
                    return true;
                }
            }
        return false;
        }
        public int IndexOf(object obj)
        {
            for(int i = 0; i <= 9; i++)
            {
                if (obj == objects[i])
                {
                    return i;
                }
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
