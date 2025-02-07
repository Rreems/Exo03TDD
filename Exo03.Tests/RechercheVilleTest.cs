using Exo03.Core;
using static System.Formats.Asn1.AsnWriter;

namespace Exo03.Tests;


[TestFixture]
public sealed class RechercheVilleTest
{
    RechercheVille _rechercheVille;


    [SetUp]
    public void Setup()
    {
        _rechercheVille = new RechercheVille(
        new List<string>
        {   "Paris",
        "Budapest",
        "Skopje",
        "Rotterdam",
        "Valence",
        "Vancouver",
        "Amsterdam",
        "Vienne",
        "Sydney",
        "New York",
        "Londres",
        "Bangkok",
        "Hong Kong",
        "Dubaï",
        "Rome",
        "Istanbul"});
    }


    // RED 1
    [Test]
    public void When_RechercherLessThan2Char_Expect_NotFoundException()
    {
        // Arrange
        const string OneLetter = "a";

        // Act & Assert 
        Assert.Throws<RechercherVilleNotFoundException>(() => _rechercheVille.Rechercher(OneLetter));
    }

    // RED 2
    [Test]
    public void When_RechercherMot_Except_VillesConcernees()
    {
        // Arrange
        const string mot = "Va";
        List<String> excepted = new List<String>() { "Valence", "Vancouver" };

        // Act
        List<string> actual = _rechercheVille.Rechercher(mot);

        // Assert 
        CollectionAssert.AreEquivalent(excepted, actual);
    }

    // RED 3
    [Test]
    public void When_RechercherMot_Except_VillesConcerneesCasseRespectee()
    {
        // Arrange
        const string mot = "va";
        List<String> excepted = new List<String>() { "Valence", "Vancouver" };

        // Act
        List<string> actual = _rechercheVille.Rechercher(mot);

        // Assert 
        CollectionAssert.AreEquivalent(excepted, actual);
    }
}
