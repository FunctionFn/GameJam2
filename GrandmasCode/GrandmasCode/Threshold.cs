using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Threshold
    {
        /*
         * Hunger
         * Health
         * Entertainment
         * Confort
         * Meds
         * Faith
         */

        private int lowHunger;
        private int hiHunger;
        private int lowHealth;
        private int hiHealth;
        private int lowEntertainment;
        private int hiEntertainment;
        private int lowConfort;
        private int hiConfort;
        private int lowMeds;
        private int hiMeds;
        private int lowFaith;
        private int hiFaith;

        public Threshold(int lowHunger,
                         int hiHunger,
                         int lowHealth,
                         int hiHealth,
                         int lowEntertainment,
                         int hiEntertainment,
                         int lowConfort,
                         int hiConfort,
                         int lowMeds,
                         int hiMeds,
                         int lowFaith,
                         int hiFaith
            )
        {
            this.lowHunger = lowHunger;
            this.hiHunger = hiHunger;
            this.lowHealth = lowHealth;
            this.hiHealth = hiHealth;
            this.lowEntertainment = lowEntertainment;
            this.hiEntertainment = hiEntertainment;
            this.lowConfort = lowConfort;
            this.hiConfort = hiConfort;
            this.lowMeds = lowMeds;
            this.hiMeds = hiMeds;
            this.lowFaith = lowFaith;
            this.hiFaith = hiFaith;
        }

        public void set(int lowHunger,
                         int hiHunger,
                         int lowHealth,
                         int hiHealth,
                         int lowEntertainment,
                         int hiEntertainment,
                         int lowConfort,
                         int hiConfort,
                         int lowMeds,
                         int hiMeds,
                         int lowFaith,
                         int hiFaith
            )
        {
            this.lowHunger = lowHunger;
            this.hiHunger = hiHunger;
            this.lowHealth = lowHealth;
            this.hiHealth = hiHealth;
            this.lowEntertainment = lowEntertainment;
            this.hiEntertainment = hiEntertainment;
            this.lowConfort = lowConfort;
            this.hiConfort = hiConfort;
            this.lowMeds = lowMeds;
            this.hiMeds = hiMeds;
            this.lowFaith = lowFaith;
            this.hiFaith = hiFaith;
        }

        public int getLowHunger()
        {
            return this.lowHunger;
        }

        public int getHiHunger()
        {
            return this.hiHunger;
        }

        public int getLowHealth()
        {
            return this.lowHealth;
        }

        public int getHiHealth()
        {
            return this.hiHealth;
        }

        public int getLowEntertainment()
        {
            return this.lowEntertainment;
        }

        public int getHiEntertainment()
        {
            return this.hiEntertainment;
        }

        public int getLowConfort()
        {
            return this.lowConfort;
        }

        public int getHiConfort()
        {
            return this.hiConfort;
        }

        public int getLowMeds()
        {
            return this.lowMeds;
        }

        public int getHiMeds()
        {
            return this.hiMeds;
        }

        public int getLowFaith()
        {
            return this.lowFaith;
        }

        public int getHiFaith()
        {
            return this.hiFaith;
        }
    }
}
