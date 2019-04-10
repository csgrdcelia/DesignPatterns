using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Sun
    {
        private static Sun instance = null;
        private static readonly object padlock = new object();

        private Sun()
        {
        }

        public static Sun Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Sun();
                    }
                    return instance;
                }
            }
        }
    }
}
