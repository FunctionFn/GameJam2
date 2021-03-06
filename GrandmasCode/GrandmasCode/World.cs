﻿public enum Conditions {
	HUNGER,
	HEALTH,
	ENTERTAINMENT,
	COMFORT,
	MEDS
};
    public class World
    {
        private const int INCREMENT = 2;
        private static World instance;
        //private List<Room> rooms;
        private int hungerLvl;
        private int healthLvl;
        private int entertainmentLvl;
        private int confortLvl;
        private int medsLvl;
        private int faithLvl;
        // Timer, should be fixed later on
        private int timer;
        private Threshold modifier;
        private System.Random random;

        private World()
        {
            // Do nothing
            this.timer = 0;
            this.modifier = new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            this.hungerLvl = 60;
            this.healthLvl = 60;
            this.entertainmentLvl = 60;
            this.confortLvl = 60;
            this.medsLvl = 60;
            this.faithLvl = 60;
            this.random = new System.Random(14);
        }

        public static World getInstance()
        {
            if (instance == null)
            {
                instance = new World();
            }
            return instance;
        }

        public void update()
        {
            // Update things
            instance.hungerLvl--;
            instance.healthLvl--;
            instance.entertainmentLvl--;
            instance.confortLvl--;
            instance.medsLvl--;
            instance.faithLvl--;
            // Must stop at zero

            instance.timer++;
            if (instance.timer == 86400)
            {
                instance.timer = 0;
            }
        }

        public bool isNight()
        {
		    return false;
            return instance.timer > 72000 || instance.timer < 10;
        }

        public int getHungerLvl()
        {
            return instance.hungerLvl;
        }

        public int getHealthLvl()
        {
            return instance.healthLvl;
        }

        public int getEntertainmentLvl()
        {
            return instance.entertainmentLvl;
        }

        public int getConfortLvl()
        {
            return instance.confortLvl;
        }

        public int getMedsLvl()
        {
            return instance.medsLvl;
        }

        public int getFaithLvl()
        {
            return instance.faithLvl;
        }

        public Threshold getModifier()
        {
            return instance.modifier;
        }

        public void setModifier(Threshold threshold)
        {
            instance.modifier = threshold;
        }

        public void incrementHunger()
        {
            instance.hungerLvl += INCREMENT;
        }

        public void incrementHealth()
        {
            instance.healthLvl += INCREMENT;
        }

        public void incrementEntertainment()
        {
            instance.entertainmentLvl += INCREMENT;
        }

        public void incrementComfort()
        {
            instance.confortLvl += INCREMENT;
        }

        public void incrementMeds()
        {
            instance.medsLvl += INCREMENT;
        }

        public void incrementFaith()
        {
            instance.faithLvl += INCREMENT;
        }

        public double getRandom()
        {
            return this.random.NextDouble();
        }
		
		public Conditions getLeast()
		{
		    int[] decisionArray = new int[5];
			int min = int.MaxValue;
			int lowIndex = 0;
		
			decisionArray[0] = instance.hungerLvl;
			decisionArray[1] = instance.healthLvl;
			decisionArray[2] = instance.entertainmentLvl;
			decisionArray[3] = instance.confortLvl;
			decisionArray[4] = instance.medsLvl;
			
			for (int i = 0; i <= 4; i++)
			{
				if (decisionArray[i] < min)
				{
					min = decisionArray[i];
					lowIndex = i;
				}
			}

			switch (lowIndex)
			{
				case 0:
					return Conditions.HUNGER;

				case 1:
					return Conditions.HEALTH;

				case 2:
					return Conditions.ENTERTAINMENT;

				case 3:
					return Conditions.COMFORT;

				default:
					return Conditions.MEDS;
			}
			
    }


}
    
