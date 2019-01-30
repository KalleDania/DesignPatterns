using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Showcase_State
    {
        void Main()
        {

            Player p = new Player();

            for (int i = 0; i < 20; i++)
            {
                p.Execute();
                p.ChangeState();
            }
        }
    }
}
