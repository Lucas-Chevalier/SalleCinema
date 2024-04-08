using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStarter
{
    public class SalleCinema
    {
        public int NombreMaxSpectateurs;
        public int NombreActuelSpectateurs;

        /// <summary>
        /// Constructeur : Initialise le nombre maximum de spectateurs et le nombre actuel de spectateurs
        /// </summary>
        public SalleCinema(int NombreMax)
        {
            NombreMaxSpectateurs = NombreMax;
            NombreActuelSpectateurs = 0;
        }

        /// <summary>
        /// Ajoute un spectateur à la salle
        /// </summary>
        /// <param name="Spectateur"></param>
        public bool AjouterSpectateur(Spectateur Spectateur)
        {
            if (NombreActuelSpectateurs < NombreMaxSpectateurs)
            {
                NombreActuelSpectateurs += 1;
                return true;
            }
            else
            {
                return false;
            }

            
        }

        /// <summary>
        /// Retire un spectateur de la salle
        /// </summary>
        /// <param name="Spectateur"></param>
        public bool RetirerSpectateur(Spectateur Spectateur)
        {
            
            if (NombreActuelSpectateurs > 0) 
            {
                NombreActuelSpectateurs -= 1;
                return true;
            }
            else { return false; }

        }

        /// <summary>
        /// Vérifie si le nombre maximum de spectateurs dans la salle est atteint
        /// </summary>
        /// <returns>vrai si le nombre maximum de spectateurs est atteint, faux sinon</returns>
        public bool VerifierNombreMaxAtteint()
        {
            return NombreActuelSpectateurs >= NombreMaxSpectateurs;
        }

        /// <summary>
        /// Vérifie si le spectateur a le droit d'accéder à une séance VIP et qu'il est le seul dans la salle (Uniquement pour un spectateur)
        /// </summary>
        /// <param name="Spectateur">Spectateur souhaitant accéder à la séance VIP</param>
        /// <returns>vrai s'il peut accéder à la séance VIP, faux sinon</returns>
        public bool AccederSeanceVip(Spectateur Spectateur)
        {
            return (NombreActuelSpectateurs > 0 && Spectateur.AccesVip);
        }
    }

    public class Spectateur
    {
        public bool AccesVip { get; set; }
        public int Age { get; set; }
    }
}
