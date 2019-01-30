using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEksempel
{
    // Singletons er bedre med en lås, da de ellers ikke er threadsafe. Er de ikke threadsafe kan 2 tråde på samme tid læse instance som null, og så laver begge to en instans af klassen hvilket totalt giver modsatte effekt end den man søger at opnå med singleton.
    public sealed class SomethingManager
    {
        private static SomethingManager instance = null;
        private static readonly object padlock = new object();

        SomethingManager()
        {
        }

        public static SomethingManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SomethingManager();
                    }
                    return instance;
                }
            }
        }
    }
}