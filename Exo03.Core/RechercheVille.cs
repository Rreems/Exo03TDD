using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace Exo03.Core;

public class RechercheVille
{
    private List<string> _villes = null!;

    public RechercheVille(List<string> villes) 
    {
        _villes = villes;
    }
    
    public List<string> Rechercher(string mot)
    {
        if (mot.Length < 2)
        {
            throw new RechercherVilleNotFoundException("Ville non trouvée.");
        }



        throw new NotImplementedException();
    }


// 1. Si le texte de la recherche contient moins de 2 caractères, Une exception est levée
// de type NotFoundException.



// 2. Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous
// les noms de ville commençant par le texte de recherche exact.



//Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et
//Vancouver
// 3. La fonctionnalité de recherche doit être insensible à la casse



// 4. La fonctionnalité de recherche devrait également fonctionner lorsque le texte de
// recherche n'est qu'une partie d'un nom de ville
//Par exemple "ape" devrait renvoyer la ville "Budapest"



// 5. Si le texte de recherche est un « * » (astérisque), il doit renvoyer tous les noms
// de ville.


}

