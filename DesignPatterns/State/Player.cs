using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Player
    {
      private  IState currentState;

        private int health = 20;

        internal IState CurrentState
        {
            get
            {
                return currentState;
            }

            set
            {
                health--;
                Die();
                currentState = value;
            }
        }

        public Player()
        {
            this.currentState = new Sleep();
        }

        public void Execute()
        {
            CurrentState.Exeute();
        }

        public void ChangeState()
        {
            currentState.ChangeState(this);
        }

        public void Die()
        {
            if (health <= 0)
            {
                Console.WriteLine("I'm dead");
                Environment.Exit(0);
            }
        }

    }
}
