using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Salle de Cinéma");
            // Création d'une instance de salle de cinéma et de spectateurs
            SalleCinema maSalle = new SalleCinema(200);

            Spectateur Realisateur = new Spectateur();
            Realisateur.AccesVip = true;
            Realisateur.Age = 45;

            Spectateur Secretaire = new Spectateur();
            Secretaire.Age = 30;

            // Tous les spectateurs entrent dans la salle
            maSalle.AjouterSpectateur(Realisateur);
            Console.WriteLine(String.Format("Nombre actuel de spectateurs 1 : {0}", maSalle.NombreActuelSpectateurs));

            maSalle.AjouterSpectateur(Secretaire);
            Console.WriteLine(String.Format("Nombre actuel de spectateurs 2 : {0}", maSalle.NombreActuelSpectateurs));

            // Vérifie si la salle a atteint sa capacité maximale
            Console.WriteLine(String.Format("La salle a-t-elle atteint sa capacité maximale ? : {0}", maSalle.VerifierNombreMaxAtteint()));

            // Vérifie si les spectateurs peuvent accéder à une séance VIP
            Console.WriteLine(String.Format("Ce spectateur peut-il accéder à la séance VIP ? : {0}", maSalle.AccederSeanceVip(Realisateur)));
            Console.WriteLine(String.Format("Ce spectateur peut-il accéder à la séance VIP ? : {0}", maSalle.AccederSeanceVip(Secretaire)));

            // Garde la fenêtre de la console ouverte en mode debug
            Console.WriteLine("Appuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
    }
}
