using System;
using System.Collections.Generic;

namespace LesTableauxExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Créer une liste languages contenant les éléments suivants :
            //HTML
            //CSS
            //Javacrit
            //jQuery
            //PHP
            //Bootstrap
            //Java
            //Afficher toute la liste.
            //Afficher le 4ème élément de la liste.
            //Afficher l’élément à l’index 4 de la liste.
            //Supprimer Bootstrap de la liste.
            //Modifier Javacrit en Javascript.
            //Ajouter C dans la liste.
            //Afficher la liste.

            List<string> languages = new List<string> {"HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java"};
            Console.WriteLine("liste compléte des différents langauges : ");

            foreach(String language in languages)
            //for (int i = 0; i < languages.Count; i++)

            {
                Console.WriteLine(languages); //avec i pour FOR languages[i]
            }

            Console.WriteLine("4e élément de la liste : " + languages[3]); //4e élément donc index 3
            Console.WriteLine("index 4 de la liste : " + languages[4]); //index 4
            languages.Remove("Bootstrap");
            languages[2] = "Javascript";
            languages.Add("C");
            Console.WriteLine("Liste modifier : ");
            for (int i = 0; i < languages.Count; i++)

            {
                Console.WriteLine(languages[i]);

            }
        }
    }
}
