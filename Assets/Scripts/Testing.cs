using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] names = {"El Hocine", "Thibaut", "Soraya", "Alexandre", "Vibol", "Bastien", "Khalid", "Enzo", "Anthony"};

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i].ToUpper();
        }

        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
