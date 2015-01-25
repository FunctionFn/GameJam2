using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC joe = new NPC("Joe");
            joe.thresholds = new Threshold(19, 88, 25, 75, 30, 66, 15, 80, 50, 80, 20, 80);
            NPC abe = new NPC("Abraham");
            abe.thresholds = new Threshold(17, 64, 19, 88, 25, 75, 30, 66, 15, 78, 19, 88);
            NPC ethel = new NPC("Ethel");
            ethel.thresholds = new Threshold(15, 77, 20, 68, 19, 88, 25, 75, 19, 88, 25, 75);
            NPC edgar = new NPC("Edgar");
            edgar.thresholds = new Threshold(22, 59, 21, 80, 20, 80, 19, 88, 25, 75, 30, 66);

            while (true)
            {
                World.getInstance().update();
                joe.Update();
                abe.Update();
                ethel.Update();
                edgar.Update();

                joe.isWalking = false;
                abe.isWalking = false;
                ethel.isWalking = false;
                edgar.isWalking = false;
            }
            //_State myState = new Decision_State().get;

            //NPC joe = new NPC("joe");

            //joe.ChangeState(myState);
        }
    }
}
