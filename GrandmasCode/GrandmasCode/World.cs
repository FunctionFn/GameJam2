using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class World
    {
        private static World instance;
        private List<Room> rooms;
        private int hungerLvl;
        private int healthLvl;
        private int entertainmentLvl;
        private int confortLvl;
        private int medsLvl;
        private int faithLvl;
        // Timer
        private Threshold modifier;

        private World()
        {
            // Do nothing
        }

        public static World getInstance()
        {
            if (instance == null)
            {
                instance = new World();
            }
            return instance;
        }


        public static void update()
        {
            getInstance();

            // Update things
            instance.hungerLvl--;
            instance.healthLvl--;
            instance.entertainmentLvl--;
            instance.confortLvl--;
            instance.medsLvl--;
            instance.faithLvl--;


        }

        public int getHungerLvl()
        {
            return this.hungerLvl;
        }

        public int getHealthLvl()
        {
            return this.healthLvl;
        }

        public int getEntertainmentLvl()
        {
            return this.entertainmentLvl;
        }

        public int getConfortLvl()
        {
            return this.confortLvl;
        }

        public int getMedsLvl()
        {
            return this.medsLvl;
        }

        public int getFaithLvl()
        {
            return this.faithLvl;
        }
    }
}
