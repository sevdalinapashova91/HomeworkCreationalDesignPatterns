using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class UniqueIdGenerator
    {
        private static volatile UniqueIdGenerator uniqueIdInstance;
        private static object syncLock = new object();
        private int uniqueId = 0;
        private UniqueIdGenerator() { }
        public static UniqueIdGenerator Instance
        {
            get
                {
                if (uniqueIdInstance == null)
                {
                    lock (syncLock)
                    {
                        if (uniqueIdInstance == null)
                        {
                            uniqueIdInstance = new UniqueIdGenerator();
                        }
                    }
                }
                return uniqueIdInstance;
            }
        }
        public int GetUniqueId()
        {
            return uniqueId++;
        }
    }
}
