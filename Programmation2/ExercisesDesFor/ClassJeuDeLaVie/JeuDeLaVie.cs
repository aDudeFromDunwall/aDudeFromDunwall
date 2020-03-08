using System;

namespace ClassJeuDeLaVie
{
    public class JeuDeLaVie
    {
        private const int DEFAULT_TAILLEX = 50;
        private const int DEFAULT_TAILLEY = 50;
        private const int DEFAULT_CHANCE = 25;

        private int tailleX;
        private int tailleY;
        private int pourcentageChance;
        private Random r;
        




        public JeuDeLaVie() : this(DEFAULT_TAILLEX, DEFAULT_TAILLEY, DEFAULT_CHANCE)
        {
            
        }

        public JeuDeLaVie(int tailleX,int tailleY) : this(tailleX,tailleY,DEFAULT_CHANCE)
        {

        }

        public JeuDeLaVie(int pourcentageChance):this(DEFAULT_TAILLEX,DEFAULT_TAILLEY,pourcentageChance)
        {

        }

        public JeuDeLaVie(int tailleX,int tailleY,int pourcentageChance)
        {
            this.tailleX = tailleX;
            this.tailleY = tailleY;
            this.pourcentageChance = pourcentageChance;

            

        }

        

        
    }

    
}
