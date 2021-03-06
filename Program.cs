﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Entities;
using TP2.Utils;

namespace TP2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var item in FakeDb.Instance.Users)
            {
                Console.WriteLine(item);
            }



            #region Q1
            var countQ1 = FakeDb.Instance.Users.Count(x => x.Firstname.Equals("Dupont") || x.Firstname.Equals("Dupond"));
            Console.WriteLine("Question 1");
            // Afficher le nombre de personne s'appelant Dupond ou Dupont.

            Console.WriteLine(countQ1);

            #endregion
            var test = FakeDb.Instance.Roles.FindAll(x => x.Name.Equals("Automobiliste"));
            var Q2test = FakeDb.Instance.Users.Where(x => x.Roles.Any(p => p.Name == "Automobiliste"));
            #region Q2
            Console.WriteLine("Question 2");
            // Afficher les personnes enregistré avec le role Automobiliste.

            Console.WriteLine(Q2test);
            Console.WriteLine(test);

            #endregion
            #region Q3
            Console.WriteLine("Question 3");

          //  var test2 = FakeDb.Instance.Users.SelectMany(x => x.Cars.Select();

               // select registration
            // Afficher les plaques d'immatriculation de toutes les voitures (une seule fois par voiture) liées à au moins un utilisateur.

            #endregion
            #region Q4
            Console.WriteLine("Question 4");
            // Afficher la ou les voiture(s) avec le plus de kilomètre

            #endregion
            #region Q5
            Console.WriteLine("Question 5");
            // Afficher le classement des types de voiture par nombre de voiture unique présentes du plus grand au plus petit.

            #endregion
            #region Q6
            Console.WriteLine("Question 6");
            // Afficher les "Garagiste" liés à 4 voitures ou plus.

            #endregion
            #region Q7
            Console.WriteLine("Question 7");
            // Afficher les "Controlleur" et la liste des voitures aux quelles ils sont liés.

            #endregion
            Console.ReadKey();
        }
    }
}
