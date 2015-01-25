public enum Conditions {
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
        private int comfortLvl;
        private int medsLvl;
        private int faithLvl;
        // Timer, should be fixed later on
        private int timer;
        private Threshold modifier;
		private int elderlyLeft;
		private System.Random random = new System.Random(System.DateTime.Today.Millisecond); 
        private World()
        {
            // Do nothing
            this.timer = 0;
            this.modifier = new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            this.hungerLvl = 60;
            this.healthLvl = 60;
            this.entertainmentLvl = 60;
            this.comfortLvl = 60;
            this.medsLvl = 60;
            this.faithLvl = 60;
			this.elderlyLeft = Constants.POPULATION;
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
            if (instance.hungerLvl < 0)
            {
                instance.hungerLvl = 0;
            }
            instance.healthLvl--;
            if (instance.healthLvl < 0)
            {
                instance.healthLvl = 0;
            }
            instance.entertainmentLvl--;
            if (instance.entertainmentLvl < 0)
            {
                instance.entertainmentLvl = 0;
            }
            instance.comfortLvl--;
            if (instance.comfortLvl < 0)
            {
                instance.comfortLvl = 0;
            }
            instance.medsLvl--;
            if (instance.medsLvl < 0)
            {
                instance.medsLvl = 0;
            }
            instance.faithLvl--;
            if (instance.faithLvl < 0)
            {
                instance.faithLvl = 0;
            }
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

        public int getComfortLvl()
        {
            return instance.comfortLvl;
        }

        public int getMedsLvl()
        {
            return instance.medsLvl;
        }

        public int getFaithLvl()
        {
            return instance.faithLvl;
        }

		public int getElderlyLeft()
		{
			return instance.elderlyLeft;
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
            if (instance.hungerLvl > 100)
            {
                instance.hungerLvl = 100;
            }
        }

        public void incrementHealth()
        {
            instance.healthLvl += INCREMENT;
            if (instance.healthLvl > 100)
            {
                instance.healthLvl = 100;
            }
        }

        public void incrementEntertainment()
        {
            instance.entertainmentLvl += INCREMENT;
            if (instance.entertainmentLvl > 100)
            {
                instance.entertainmentLvl = 100;
            }
        }

        public void incrementComfort()
        {
            instance.comfortLvl += INCREMENT;
            if (instance.comfortLvl > 100)
            {
                instance.comfortLvl = 100;
            }
        }

        public void incrementMeds()
        {
            instance.medsLvl += INCREMENT;
            if (instance.medsLvl > 100)
            {
                instance.medsLvl = 100;
            }
        }

        public void incrementFaith()
        {
            instance.faithLvl += INCREMENT;
            if (instance.faithLvl > 100)
            {
                instance.faithLvl = 100;
            }
        }

		public double getRandom()
		{
			return this.random.NextDouble();
		}

		public void reportDeath() 
		{
			instance.elderlyLeft--;
		}
		
		public Conditions getLeast()
		{
		    int[] decisionArray = new int[5];
			int min = int.MaxValue;
			int lowIndex = 0;
		
			decisionArray[0] = instance.hungerLvl;
			decisionArray[1] = instance.healthLvl;
			decisionArray[2] = instance.entertainmentLvl;
			decisionArray[3] = instance.comfortLvl;
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
    
