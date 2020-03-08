using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOUdevoirH2020Prog2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choisir un chiffre (positif x>0 S.V.P)");
            ushort chiffre= ushort.Parse(Console.ReadLine());

            

            if(chiffre<=0)
            {
                Console.WriteLine("Je t'ai demander de mettre un chiffre positif plus grand que 0.");
            }
            else
            {

                Console.WriteLine(FabriquerLigne(chiffre));
                Console.WriteLine(FabriquerColonne(chiffre));
                Console.WriteLine(FabriquerTriangle1(chiffre));
                Console.WriteLine(FabriquerTriangle2(chiffre));
                Console.WriteLine(FabriquerTriangle3(chiffre));
                Console.WriteLine(FabriquerTriangle4(chiffre));
                Console.WriteLine(FabriquerTriangle5(chiffre));
                Console.WriteLine(FabriquerTriangle6(chiffre));
            }

            Console.ReadLine();
        }

        public static string FabriquerLigne(ushort chiffre)
        {
            StringBuilder sbDeLigne = new StringBuilder();

            sbDeLigne.AppendLine("\nVersion ligne\n");
      

            for (int i = 0; i < chiffre; i++)
            {
                sbDeLigne.Append(" * ");
            }

            string ligne = sbDeLigne.ToString();
            return ligne;
        }



        public static string FabriquerColonne(ushort chiffre)
        {
            StringBuilder sbDeColonne = new StringBuilder();

            sbDeColonne.AppendLine("\nVersion  colonne\n");

            for (int i = 0; i < chiffre; i++)
            {
                sbDeColonne.AppendLine(" * ");
            }

            string colonne = sbDeColonne.ToString();
            return colonne;
        }

        public static string FabriquerCarre(ushort chiffre)
        {
            StringBuilder sbDeCarre = new StringBuilder();

            sbDeCarre.AppendLine("\nVersion  carré\n");
            

            for (int i = 0; i < chiffre; i++)
            {
                for (int j = 0; j < chiffre; j++)
                {
                    sbDeCarre.Append(" * ");
                }
                sbDeCarre.AppendLine();
            }

            string carre = sbDeCarre.ToString();
            return carre;
        }

        public static string FabriquerTriangle1(ushort chiffre)
        {
            StringBuilder sbDeTriangle1 = new StringBuilder();

            sbDeTriangle1.AppendLine("\nVersion triangle rectangle 1\n");
            
            for (int i = 1; i <= chiffre; i++) //ligne
            {
                for (int j = 0; j < i; j++) //colonne
                {
                    sbDeTriangle1.Append(" * ");
                }

                sbDeTriangle1.AppendLine();
            }
            string triangle1 = sbDeTriangle1.ToString();
            return triangle1;
        }

        public static string FabriquerTriangle2(ushort chiffre)
        {
            StringBuilder sbDeTriangle2 = new StringBuilder();
            

            sbDeTriangle2.AppendLine("\nVersion  triangle 2\n");
           

            for (int i = chiffre; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    sbDeTriangle2.Append(" * ");
                }
                sbDeTriangle2.AppendLine();
            }

            string triangle2 = sbDeTriangle2.ToString();
            return triangle2;
        }

        public static string FabriquerTriangle3(ushort chiffre)
        {
            StringBuilder sbDeTriangle3 = new StringBuilder();


            sbDeTriangle3.AppendLine("\nVersion triangle 3\n");
           
            for (int i = 1; i <= chiffre; i++)
            {
                for (int j = chiffre; j > 0; j--)
                {
                    if (j == i || j < i)
                    {
                        sbDeTriangle3.Append(" * ");
                    }
                    else
                    {
                        sbDeTriangle3.Append(" - ");
                    }
                }
                sbDeTriangle3.AppendLine();
            }


            string triangle3 = sbDeTriangle3.ToString();
            return triangle3;
        }

        public static string FabriquerTriangle4(ushort chiffre)
        {
            StringBuilder sbDeTriangle4 = new StringBuilder();

            
            sbDeTriangle4.AppendLine("\nVersion triangle 4\n");

            for (int i = chiffre; i > 0; i--)
            {
                for (int j = chiffre; j > 0; j--)
                {
                    if (j <= i)
                    {
                        sbDeTriangle4.Append(" * ");
                    }
                    else
                    {
                        sbDeTriangle4.Append(" - ");
                    }
                }
                sbDeTriangle4.AppendLine("\n");
            }

            string triangle4 = sbDeTriangle4.ToString();
            return triangle4;
        }

        public static string FabriquerTriangle5(ushort chiffre)
        {
            StringBuilder sbDeTriangle5 = new StringBuilder();

           
            sbDeTriangle5.AppendLine("\nVersion  triangle 5\n");
            


            for (int i = 0; i < 2; i++)
            {
                if (i < 1)
                {
                    for (int j = 1; j <= chiffre; j++)
                    {
                        for (int m = 0; m < j; m++)
                        {
                            sbDeTriangle5.Append(" * ");
                        }
                        sbDeTriangle5.AppendLine();
                    }
                }
                else
                {
                    for (int k = chiffre - 1; k > 0; k--)
                    {
                        for (int o = 0; o < k; o++)
                        {
                            sbDeTriangle5.Append(" * ");
                        }
                        sbDeTriangle5.AppendLine();
                    }
                }
            }


            string triangle5 = sbDeTriangle5.ToString();
            return triangle5;
        }

        public static string FabriquerTriangle6(ushort chiffre)
        {
            StringBuilder sbDeTriangle6 = new StringBuilder();

            sbDeTriangle6.AppendLine("\nVersion triangle 6\n");

            for (int i = 0; i < 2; i++)
            {
                if (i < 1)
                {
                    for (int j = 1; j <= chiffre; j++)
                    {
                        for (int k = chiffre; k > 0; k--)
                        {
                            if (k <= j)
                            {
                                sbDeTriangle6.Append(" * ");
                            }
                            else
                            {
                                sbDeTriangle6.Append(" - ");
                            }
                        }
                        sbDeTriangle6.AppendLine();
                    }
                }
                else
                {
                    for (int l = chiffre - 1; l > 0; l--)
                    {
                        for (int p = chiffre; p > 0; p--)
                        {
                            if (p <= l)
                            {
                                sbDeTriangle6.Append(" * ");
                            }
                            else
                            {
                                sbDeTriangle6.Append(" - ");
                            }
                        }
                        sbDeTriangle6.AppendLine();
                    }
                }
            }

            string triangle6 = sbDeTriangle6.ToString();
            return triangle6;
        }
    }
}
