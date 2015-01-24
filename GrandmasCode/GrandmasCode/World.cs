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
        // Timer, should be fixed later on
        private int timer;
        private Threshold modifier;

        private World()
        {
            // Do nothing
            this.timer = 0;
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

            instance.timer++;
            if (instance.timer == 86400)
            {
                instance.timer = 0;
            }
        }

        public static bool isNight()
        {
            getInstance();
            return instance.timer > 72000 && instance.timer < 25200;
        }

        public int getHungerLvl()
        {
            getInstance();
            return this.hungerLvl;
        }

        public int getHealthLvl()
        {
            getInstance();
            return this.healthLvl;
        }

        public int getEntertainmentLvl()
        {
            getInstance();
            return this.entertainmentLvl;
        }

        public int getConfortLvl()
        {
            getInstance();
            return this.confortLvl;
        }

        public int getMedsLvl()
        {
            getInstance();
            return this.medsLvl;
        }

        public int getFaithLvl()
        {
            getInstance();
            return this.faithLvl;
        }
    }
}
