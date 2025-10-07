using UnityEngine;

public class Fantasy : MonoBehaviour
{

    string MaakSpreukInfo(string name, int manaCost, string effect, bool isBeschikbaar)
    {

        return $"Spreuk: {name}, ManaCost: {manaCost}, Effect: {effect}, Beschikbaar: {isBeschikbaar}";
    }

    void Showspell()
    {

        string forrestflame = MaakSpreukInfo("Forrestflame", 50, "Surrounded by a thick mist, the fire burns fiercely.", true);
        Debug.Log(forrestflame);


        string CloudyMist = MaakSpreukInfo("Cloudymist", 25, "Creates a thick mist that prevents the target from being seen.", false);
        Debug.Log(CloudyMist);
    }

    void Start()
    {
        Showspell();
    }
}