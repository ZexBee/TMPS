using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
       class logginUser
        {
            private volatile static logginUser obj = null;

            private static readonly object SyncLock = new object();
            public logginUser()
            {
            /* ... */
            }
            public static logginUser Initialise()
            {
                if (obj == null)
                {
                    lock (SyncLock)
                    {
                        if (obj == null)
                        {
                            obj = new logginUser();
                        }
                    }
                }
                return obj;
            }
        }




}