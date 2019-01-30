using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Move : IState
    {
        private static Random rnd = new Random();
        public void ChangeState(Player player)
        {
            int number = rnd.Next(0, 2);

            switch (number)
            {
                case 0:
                    player.CurrentState = new Aggresive();
                    break;
                case 1:
                    player.CurrentState = new Sleep();
                    break;
            }

        

        
        }

        public void Exeute()
        {
            Console.WriteLine("I'm moving");
        }
    }
}
