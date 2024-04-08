using System.Numerics;
using UnitTestStarter;

namespace UnitTestStarterTests
{
    [TestFixture]
    public class Tests
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void VerifierNombreMaxAtteint_SalleVide_RetourneFaux()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            // Act
            var resultat = salle.VerifierNombreMaxAtteint();
            // Assert
            Assert.IsFalse(resultat, "La salle est vide, donc elle ne devrait pas considérée comme pleine.");
        }
        [Test]

        public void VerifierNombreMaxAtteint_SallePleine_RetourneVrai()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            salle.NombreActuelSpectateurs = 10;
            // Act
            var resultat = salle.VerifierNombreMaxAtteint();
            // Assert
            Assert.IsTrue(resultat, "La salle est pleine, donc elle ne devrait pas considérée comme non pleine.");
        }

        [Test]
        public void AjouterUnSpectateurDansUneSallePleine_RetourneFaux()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            salle.NombreActuelSpectateurs = 10;
            // Act
            
            var resultat = salle.AjouterSpectateur(new Spectateur());
            //var resultat = salle.VerifierNombreMaxAtteint();
            // Assert
            Assert.IsFalse(resultat, "La salle est pleine, donc elle ne devrait pouvoir prendre plus de spéctateur.");
        }
        
        [Test]
        public void AjouterUnSpectateurDansUneSalleVide_RetourneVrai()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            // Act
            salle.AjouterSpectateur(new Spectateur());
            var resultat = salle.NombreActuelSpectateurs;
            // Assert
            Assert.That(resultat, Is.EqualTo(1), "La salle étant vide, il ne devrait y avoir qu'une seule personne.");
        }
        [Test]
        public void EnleverUnSpectateurDansUneSalleVide_RetourneFaux()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            // Act
            var resultat = salle.RetirerSpectateur(new Spectateur());
            // Assert
            Assert.IsFalse(resultat, "La salle est vide, donc on ne devrait pas pouvoir .");
        }

        [Test]
        public void EnleverUnSpectateurDansUneSallePleine_RetourneVrai()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            salle.NombreActuelSpectateurs = 10;
            // Act
            salle.RetirerSpectateur(new Spectateur());
            var resultat = salle.NombreActuelSpectateurs;
            // Assert
            Assert.That(resultat, Is.EqualTo(9), "La salle étant pleine, donc on devrait avoir neuf spectateurs.");
        }

        [Test]
        public void VerifierAccesALaSeanceVipAUnSpectateurVip_RetourneVrai()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            Spectateur Realisateur = new Spectateur { AccesVip = true };
            // Act
            salle.AjouterSpectateur(Realisateur);
            var resultat = salle.AccederSeanceVip(Realisateur);
            // Assert
            Assert.IsTrue(resultat, "Le spectateur devrait être VIP.");
        }
        [Test]
        public void VerifierAccesALaSeanceVipAUnSpectateurNonVip_RetourneVrai()
        {
            // Arrange
            var salle = new SalleCinema(10); // Supposons une capacité max de 10 spectateurs
            Spectateur spectateur = new Spectateur();
            // Act
            salle.AjouterSpectateur(spectateur);
            var resultat = salle.AccederSeanceVip(spectateur);
            // Assert
            Assert.IsFalse(resultat, "Le spectateur ne devrait pas être VIP.");
        }


    }
}



        