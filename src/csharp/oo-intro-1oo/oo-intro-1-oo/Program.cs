//Auteur : JMY
//Date   : 2018
//Lieu   : ETML

using System;

namespace object_oriented_introduction
{
    class Program
    {
        //nombre de notes possibles
        const int GRADE_COUNT = 10;
        
        //Données de traitement -> notes d'un élève
        static Grade[] gradesSkywalker = new Grade[GRADE_COUNT];

        static void Main(string[] args)
        {
            //Adapte la console du compactframework à l'environnement visualstudio par défaut
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Remplissage des données
            FillRandom(gradesSkywalker, 0, 6);

            //Affichage des notes et statistiques
            Console.Write("Skywalker a " + Count(gradesSkywalker) + " notes : ");
            Write(gradesSkywalker);
            Console.WriteLine();
            Console.WriteLine("Moyenne : "+Mean(gradesSkywalker));
            Console.WriteLine("Somme : "+Sum(gradesSkywalker));

            //Garde la console ouverte
            Console.ReadLine();
        }

        //Traitement 1
        /// <summary>
        /// Compte les éléments d'un tableau d'entiers
        /// </summary>
        /// <param name="data"></param>
        /// <returns>le nombre d'élément(s)</returns>
        static int Count(int[] data)
        {
            //Gestion d'un tableau non défini
            if (data == null)
                return 0;

            return data.Length;
        }

        //Traitement 2
        /// <summary>
        /// Remplit un tableau avec des valeurs aléatoire
        /// </summary>
        /// <param name="data">tableau à remplir (attention, sera écrasé)</param>
        /// <param name="min">Valeur minimale</param>
        /// <param name="max">Valeur maximale</param>
        static void FillRandom(int[] data, int min = Int32.MinValue, int max = Int32.MaxValue)
        {
            //TODO : implémenter cette méthode
        }

        //Traitement 3
        /// <summary>
        /// Retourne la somme des valeurs d'un tableau d'entiers
        /// </summary>
        /// <param name="data">tableau pour calcul</param>
        /// <returns>la somme</returns>
        static int Sum(int[] data)
        {
            //TODO : implémenter correctement cette méthode
            return -1;
        }

        //Traitement 4
        /// <summary>
        /// Calcule la moyenne d'un tableau d'entiers
        /// </summary>
        /// <param name="data">tableau</param>
        /// <returns>la moyenne arrondie à 2 décimales</returns>
        static float Mean(int[] data)
        {
            //TODO : implémenter correctement cette méthode
            return -1.0f;
        }

        /// <summary>
        /// Affiche le contenu d'an tableau d'entiers dans la console
        /// </summary>
        /// <param name="data">données à afficher</param>
        /// <param name="separator">séparateur</param>
        static void Write(int[] data,string separator=" ")
        {
            for(int i=0;i<data.Length;i++)
            {
                Console.Write(data[i]+separator);
            }
        }
    }
}
