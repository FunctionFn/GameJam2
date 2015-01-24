using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrandmasCode
{

    public enum Constants
    {
        STARTING_VIT = 70
    }

    class NPC
    {

        public NPC(string inName)
        {
            this.name = inName;
            this.vit = (int)Constants.STARTING_VIT;
            this.curr_state = null;
            //this.thresholds = null;
        }


        public void Update()
        {

        }


        public void ChangeState(_State newState)
        {
            this.curr_state = newState;
        }

        //----------------
        public string name;
        public _State curr_state;
        // public Threshold tresholds;
        public int vit;


    }
}
