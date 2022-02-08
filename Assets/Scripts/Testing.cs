using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] string text = "Voix ambigue d'un cœur qui au zéphyr préfère les jattes de kiwi.";

    // Écrire la fonction WordCount qui compte le nombre de mots dans une variable string donnée
    // Indice : les variables string ont une fonction « Split » divise en un tableau en fonction d'un caractère donnéez
    // Exemple : text.Split(' ') => {"Hello", "world!"}
    int WordCount(string t) {
        string[] words = t.Split(' ');
        return words.Length;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(WordCount(text));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
