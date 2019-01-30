using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Aggresive : IState
    {
        public void ChangeState(Player player)
        {
            player.CurrentState = new Move();
        }

        public void Exeute()
        {
            Console.WriteLine("I'm attacking");   
        }
    }
}
