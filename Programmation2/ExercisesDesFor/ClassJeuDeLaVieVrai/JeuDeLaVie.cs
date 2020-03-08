using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegepVicto.TechInfo.H2020.P2.DA1839212.JeuxVie
{
    public class JeuDeLaVie
    {
        private const int DEFAULT_TAILLEX =20;
        private const int DEFAULT_TAILLEY = 20;
        private const int DEFAULT_CHANCE = 25;
        private int tailleX;
        private int tailleY;
        private int pourcentageChance;
        private int[,] tab;
        private int[,] vieuxTab;
        private string[,] tabtraduit;
        /// <summary>
        /// Constructeur d'un jeu de la vie Vide.  Il a donc les valeurs par défaut si haut
        /// </summary>
        public JeuDeLaVie() : this(DEFAULT_TAILLEX, DEFAULT_TAILLEY, DEFAULT_CHANCE) //Je fais comment pour déterminer la longueur du tableau avec DEFAULT_TAILLEX et Y       
        {
            tab = new int[DEFAULT_TAILLEX, DEFAULT_TAILLEY];
            tabtraduit = new string[DEFAULT_TAILLEX, DEFAULT_TAILLEY];
            pourcentageChance = DEFAULT_CHANCE;
        }
        /// <summary>
        /// Constructeur d'un jeu de la vie avec la longueur et la largeur. 
        /// Seul le pourcentagedeChance est par défaut
        /// </summary>
        /// <param name="tailleX">Détermine la taille du tableau en X</param>
        /// <param name="tailleY">Détermine la taille du tableau en Y</param>
        public JeuDeLaVie(int tailleX, int tailleY) : this(tailleX, tailleY, DEFAULT_CHANCE)
        {
            tab = new int[tailleX, tailleY];
            tabtraduit = new string[tailleX, tailleY];
        }
        /// <summary>
        /// Constructeur d'un jeu de la vie avec le pourcentage de chance. Seul la taille en X et en Y
        /// on la valeur par défault
        /// </summary>
        /// <param name="pourcentageChance">Pourcentage de chance qu'une case soit naissante au début du programme</param>
        public JeuDeLaVie(int pourcentageChance) : this(DEFAULT_TAILLEX, DEFAULT_TAILLEY, pourcentageChance)
        {
            tab = new int[DEFAULT_TAILLEX, DEFAULT_TAILLEY];
            tabtraduit = new string[DEFAULT_TAILLEX, DEFAULT_TAILLEY];
        }
        /// <summary>
        /// Constructeur de jeu de la vie plein. Aucune valeur par défault
        /// </summary>
        /// <param name="tailleX">Taille du tableau en X</param>
        /// <param name="tailleY">Taille du tableau en Y</param>
        /// <param name="pourcentageChance">PourcentageDeChance pour qu'une case soit naissante au début du programme </param>
        public JeuDeLaVie(int tailleX, int tailleY, int pourcentageChance)
        {
            this.tailleX = tailleX;
            this.tailleY = tailleY;
            this.pourcentageChance = pourcentageChance;
            tab = new int[tailleX, tailleY];
            tabtraduit = new string[tailleX, tailleY];
        }
        /// <summary>
        /// Sert a bouger dans le tableau. Se déplacer de case en case en utilisant AltérationÉtat()
        /// Le compteur sers uniquement à alterner entre les fonctions AlterationEtat() et Transitions()
        /// </summary>
        public void BougerDansLeTableau(int compteur)
        {
            vieuxTab = (int[,])tab.Clone();
                for (int i = 0; i < tab.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < tab.GetLength(1) - 1; j++)
                    {
                        if (compteur == 1)
                        {
                            Transition(i, j);
                        }
                        else
                        {
                            AlterationEtat(i, j);
                        }
                    }
                }
        }
        /// <summary>
        /// Si une case à la valeur 1 elle devient vivante
        /// Et si une case à la valeur 3 elle devient mort
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        private void Transition(int x,int y)
        {
            if(vieuxTab[x,y]==1)
            {
                tab[x, y] = 2;
            }
            if(vieuxTab[x,y]==3)
            {
                tab[x, y] = 4;
            }
            TraduireTabBrut();
        }
        /// <summary>
        /// Détermine le nb de voisin immédiat autour de lui (droite-gauche, haut-bas, diagonales)
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Le nombre de voisin immédiat</returns>
        private int NbDeVoisin(int x,int y) 
        {
            int resultat = NbDeVoisinHautEtBas(x,y) + NbVoisinDroiteGauche(x,y) + NbVoisinDiago(x,y);
            return resultat;
        }
        /// <summary>
        /// Détermine le nombre de voisin immédiat en haut et en bas. Prend en compte les cas ou tu est au sommet et au bas du tableau
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Le nombre de voisin immédiat en haut et en bas</returns>
        private int NbDeVoisinHautEtBas(int x, int y)
        {
            int compteur = 0;
            if(y==0) //Si la case est en haut du tableau
            {
                y++;
                if(vieuxTab[x,y]<4)
                {
                    compteur++;
                }
                return compteur;
            }
            if(y==tab.GetLength(0)-1)//Si la case est au bas du tableau
            {
                y--;
                if(vieuxTab[x,y]<4)
                {
                    compteur++;
                }
                return compteur;
            }
            y--;
            if (vieuxTab[x, y] < 4)
            {
                compteur++;
            }
            y += 2;
            if (vieuxTab[x, y] < 4)
            {
                compteur++;
            }
            return compteur;
        }
        /// <summary>
        /// Détermine le nb de voisin de gauche et droite immédiat
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Le nombre de voisin immédiat à gauche et à droite</returns>
        private int NbVoisinDroiteGauche(int x,int y)
        {
            int compteur = 0;
            if (x == 0) //Si la case est à gauche tu tableau
            {
                x++;
                if (vieuxTab[x, y] < 4)
                {
                    compteur++;
                }
                return compteur;
            }
            if (x == tab.GetLength(0) - 1) //si la case est à droite du tableau
            {
                x--;
                if (vieuxTab[x, y] < 4)
                {
                    compteur++;
                }
                return compteur;
            }
            x--;
            if (vieuxTab[x, y] < 4)
            {
                compteur++;
            }
            x+=2;
            if (vieuxTab[x, y] < 4)
            {
                compteur++;
            }
            return compteur;
        }
        /// <summary>
        /// Détermine le nombre de voisin en diagonale immédiat
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Le nombre de voisin immédiat en diagonales</returns>
        private int NbVoisinDiago(int x, int y)
        {
            int nbvoisin=0;
            if (x == 0 && y == 0) //Check le coin en haut a droite
            {
                if (vieuxTab[x + 1, y + 1] < 4)
                {
                    return 1;
                }
                return 0;
            }
            if (x == tab.GetLength(0) - 1 && y == 0) //Check le coin en haut à droite
            {
                if (vieuxTab[x - 1, y + 1] < 4)
                {
                    return 1;
                }
                return 0;
            }
            if (x == tab.GetLength(0) - 1 && y == tab.GetLength(1) - 1) //Check le coin en bas a droite
            {
                if (vieuxTab[x - 1, y - 1] < 4)
                {
                    return 1;
                }
                    return 0;
            }
            if(x==0 && y==tab.GetLength(1)-1) //Check le coin en bas à gauche
            {
                if (vieuxTab[x + 1, y - 1] < 4)
                {
                    return 1;
                }
                    return 0;
            }
            ////////////////////////////Les coins (voir plus haut). Les bords et les autres(voir plus bas)
            if(y==0)//Si la case est au sommet
            {
                return VoisindiagoSommet(x,y);
            }
            if(x==tab.GetLength(0)-1)//Si la case est au bord droite 
            {
                return Voisindiagodroite(x,y);
            }
            if(y==tab.GetLength(1)-1)//Si la case est au bas
            {
                return Voisindiagobas(x, y);
            }
            if(x==0 &&y!=0 &&y!=tab.GetLength(1)-1)//Si la case est au bord gauche
            {
                return Voisindiagogauche(x, y);
            }
            ////////////////////////////// si ta case ne touche pas au bord
            else     
            {
                if(vieuxTab[x - 1, y - 1] < 4) //Diagonales vers haut-gauche
                {
                    nbvoisin++;
                }
                if(vieuxTab[x - 1, y + 1] < 4)//Diagonales vers bas-gauche
                {
                    nbvoisin++;
                }
                if(vieuxTab[x + 1, y + 1] < 4)//Diagonales vers bas-droite
                {
                    nbvoisin++;
                }
                if(vieuxTab[x + 1, y - 1] < 4)//Diagonales vers haut-droite
                {
                    nbvoisin++;
                }
            }
            return nbvoisin;
        }
        /// <summary>
        /// Détermine le nombre de voisin en diagonales si la case concernées est au sommet du tableau
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Retourne le nb de voisin diagonales sans sortir du tableau</returns>
        private int VoisindiagoSommet(int x,int y)
        {
            int compteur = 0;
            if(vieuxTab[x + 1, y + 1] < 4)
            {
                compteur++;
            }
            if(vieuxTab[x - 1, y + 1] < 4)
            {
                compteur++;
            }
            return compteur;
        }
        /// <summary>
        /// Détermine le nombre de voisin en diagonales si la case concernées est à la droite du tableau
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Retourne le nb de voisin diagonales sans sortir du tableau</returns>
        private int Voisindiagodroite(int x, int y) //si le point est au fond a droite
        {
            int compteur = 0;
            if(vieuxTab[x-1,y-1]<4)
            {
                compteur++;
            }
            if(vieuxTab[x-1,y+1]<4)
            {
                compteur++;
            }
            return compteur;
        }
        /// <summary>
        /// Détermine le nombre de voisin en diagonales si la case concernées est au bas du tableau
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>Retourne le nb de voisin diagonales sans sortir du tableau</returns>
        private int Voisindiagobas(int x, int y)//Si le point est en bas
        {
            int compteur = 0;
            if(vieuxTab[x-1,y-1]<4)
            {
                compteur++;
            }
            if(vieuxTab[x+1,y-1]<4)
            {
                compteur++;
            }
            return compteur;
        }
        /// <summary>
        /// Détermine le nombre de voisin en diagonales si la case concernées est à la gauche du tableau
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en y</param>
        /// <returns>>Retourne le nb de voisin diagonales sans sortir du tableau</returns>
        private int Voisindiagogauche(int x, int y)//Si le point est a gauche
        {
            int compteur = 0;
            if(vieuxTab[x+1,y+1]<4)
            {
                compteur++;
            }
            if(vieuxTab[x+1,y-1]<4)
            {
                compteur++;
            }
            return compteur;
        }

        /// <summary>
        /// Change la Valeur d'une case dans le tab selon son nombre de voisin dans le Vieuxtab
        /// </summary>
        /// <param name="x">Position dans les tableaux en x</param>
        /// <param name="y">Position dans les tableaux en x</param>
        private void AlterationEtat(int x,int y) 
        {
            if (NbDeVoisin(x, y) < 2 || NbDeVoisin(x, y) > 3) //Si tu meurt
            {
                if (vieuxTab[x, y] == 2) //si vivant elle est en train de mourir
                {
                    tab[x, y] = 3;//mourrant
                }
            }
            else if (NbDeVoisin(x, y) == 3)//tu gagne la vie
            {
                if (vieuxTab[x, y] == 4) //si case morte
                {
                    tab[x, y] = 1;//Naissant
                }
            }
            TraduireTabBrut();
        }
        /// <summary>
        /// Prend le tab(rempli de chiffre) et le traduit pour des symboles
        /// </summary>
        private void TraduireTabBrut()
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if(tab[i, j] == 1)
                    {
                        tabtraduit[i, j] = "+"; //Traduit pour naissant        
                    }
                    if(tab[i, j] == 2)
                    {
                        tabtraduit[i, j] = "%"; //Traduit pour Vivant        
                    }
                    if(tab[i, j] == 3)
                    {
                        tabtraduit[i, j] = "-"; //Traduit pour mourrant        
                    }
                    if(tab[i, j] == 4)
                    {
                        tabtraduit[i, j] = " "; //Traduit pour Mort        
                    }
                }
            }
        }
        /// <summary>
        /// Affiche le tabtraduit
        /// </summary>
        /// <returns>Le tabtraduit en string</returns>
        public string AfficherTabTraduit()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tabtraduit.GetLength(0); i++)
            {
                for (int j = 0; j < tabtraduit.GetLength(1); j++)
                {
                    sb.Append(tabtraduit[i,j]+"  ");
                }
                sb.AppendLine("\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Met les valeurs naissante dans tab pour le pourcentagedechance et met le reste mort
        /// </summary>
        public void MettreValeurRandomDanstableau()
        {
            Random r = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    int monchiffre= r.Next(0, 101);
                    if(monchiffre<pourcentageChance)
                    {
                        tab[i, j] = 1;
                    }
                    else
                    {
                        tab[i, j] = 4;
                    }
                }
            }
        }

        /// <summary>
        /// Génère un pattern simple pour tester la logique du code. Dans ce cas-ci ca créer ***  dans tab
        /// </summary>
        public void Genererpatern()
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 4;
                }
            }
            tab[5, 5] = 1;
            tab[5, 6] = 1;
            tab[5, 7] = 1;
        }
    }
}
