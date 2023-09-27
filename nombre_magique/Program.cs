using System;

namespace nombre_magique
{
    internal class Program
    {
        // DEMANDER NOMBRE
        // Afficher si ce nombre est valide -> ERREUR: ce nombre n'est pas valide
        // Recboucler tant que le nombre n'est pas valide 
        // Considérer que 0 est invalide 
        // Retourner la valeur (int)

      
        static int DemanderNombre(int min , int max)
        {

            //  int nombreUtilisateur = 0; // = inputNbr;
            int nombreUtilisateur = min - 1; 


            while ((nombreUtilisateur < min) || (nombreUtilisateur > max)) 
            {
                try 
                {
                    Console.WriteLine($"Rentrez un nombre entre {min} et {max}");
                    string response = Console.ReadLine();

                    nombreUtilisateur = int.Parse(response);

                    if((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine($"ERREUR: Le nombre doit être compris entre {min} et {max}");
                      //  nombreUtilisateur = 0; // Pour forcer à reboucler
                    }

                }  catch 
                {
                    Console.WriteLine("Entrer un nombre correct !");
                }
              
            }
            return nombreUtilisateur;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MAGIQUE + 1;

            #region Avec la boucle while
            //int nbrVie = 4 ;
           
            //while (nbrVie > 0)  
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("nombre magique " + NOMBRE_MAGIQUE);
            //    Console.WriteLine("Nombre de vies restantes: " +nbrVie);
            //    nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);



            //    if (NOMBRE_MAGIQUE > nombre)
            //    {
            //        Console.WriteLine("Le nombre magique est plus grand ");
            //    //    nbrVie--;
            //    }
            //    else if (NOMBRE_MAGIQUE < nombre)
            //    {
            //        Console.WriteLine("Le nombre magique est plus petit ");
            //    //    nbrVie--;
            //    }
            //    else
            //    {
            //        Console.WriteLine("BRAVOS, vous avez trouvé le nombre magique ");
            //        break;
            //    }
            //    nbrVie--;
            //}

            //if( nbrVie == 0 ) 
            //{
            //    Console.WriteLine("Vous avez perdu, le nombre magique était: " + NOMBRE_MAGIQUE);
            //}
            #endregion


            #region Avec la boucle For
            for  (int nbrVie = 4; nbrVie > 0; nbrVie--)
            {
                Console.WriteLine();
                //Console.WriteLine("nombre magique " + NOMBRE_MAGIQUE);
                Console.WriteLine("Nombre de vies restantes: " + nbrVie);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

  
                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand ");     
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit ");                
                }
                else
                {
                    Console.WriteLine("BRAVOS, vous avez trouvé le nombre magique ");
                    break;
                }
            }

            if (nombre != NOMBRE_MAGIQUE)
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était: " + NOMBRE_MAGIQUE);
            }
            #endregion

            // Afiicher le nombre de la console 
            // Console.WriteLine("La valeur que vous avez entré est : "+nombre);

            // 1- Rentrer un nombre entre 1 et 10 <- dépen de min et de max
            // 2- Rentrer un nombre entre 1 et 10 
            // 3 - Tester si nombreUtlisateur est bien entre min et max: ERREUR: Le nombre doit êttre entre 
            //Console.WriteLine("Votre nombre est:" + nombre);

            // Random rand = new Random ();

            // int index = 0;

            //for (index = 0; index < 10; index++)
            // {
            //     int valeurAleatoire = rand.Next(1, 11);
            //     Console.WriteLine("Nombre aléatoire" + valeurAleatoire);
            // }

            //if( index != 0)
            // {
            //     Console.WriteLine(index);
            // }

        }
    }
}
