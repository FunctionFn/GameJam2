using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrandmasCode
{


    class NPC
    {

        public NPC(string inName)
        {
            this.name = inName;
            this.vit = (int)Constants.STARTING_VIT;
            this.curr_state = null;
            this.thresholds = null;
        }


        public void Update()
        {

        }


        public void ChangeState(_State newState)
        {
            this.curr_state.exit(this);
            this.curr_state = newState;
            this.curr_state.enter(this);

        }

        //----------------
        public string name;
        public _State curr_state;
        public Threshold thresholds;
        public int vit;


    }
}
