using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CegepVicto.TechInfo.H2020.P2.DA1839212.JeuxVie;

namespace CegepVicto.TechInfo.H2020.P2.DA1839212.JeuxVie
{
    class Program
    {
        static void Main(string[] args)
        {

            // + ou 1 = en train de naitre 
            // % ou 2 = vivant
            // - ou 3 = en train de mourir
            // " " ou 4 = mort

            JeuDeLaVie j = new JeuDeLaVie();

            int compteur = 0 ;

            //Dans le fond.  vieuxtab est le tableau avec les valeurs qui ne changeront pas mais qui permettra
            //de connaitre le nbdevoisin.
            //l'altération d'état changera les valeurs du tab selon le nb de voisin qu'il a récupérer sur le 
            //vieuxtab

            //Toute les valeurs dans le tableau qui sont morte sont =4
            //Et celle qui ne sont pas devenus vivantes à cause du MettreValeurRandomDansTableau() ont aussi
            //une valeur de 4


            //à faire:
            //Inclure un singleton (voir photo cell pour plan)   Singleton:fonction que l'on utilise qu'une seule fois qui est private.
            //le singleton sera appeler a partir d'une fonction qui est dans la classe

            //Voir les photos Pour la checklist du code et donc ce que tu dois faire avant de le remettre

            //Pousser sur github l'url pour avoir accès au dossier du programme jeu de la vie
            //Voir ancien projet sur phpstorm pour plus de précision de comment push quelque chose
            //tu devra utiliser gitbash


            j.MettreValeurRandomDanstableau();  //Mais les valeurs de vivant ou vide selon les chances entrer dans le constrcteur
            
            Console.SetCursorPosition(0, 0);
            compteur = 1;
            j.TraduireTabBrut();
            Console.WriteLine(j.AfficherTabTraduit()); 
            Thread.Sleep(3000);

            while(true)
            {
                
                j.BougerDansLeTableau(compteur);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(j.AfficherTabTraduit());
                Thread.Sleep(3000);
                compteur++;
                if (compteur == 3)
                {
                    compteur = 1;
                }
                
            }
        }
    }
}
