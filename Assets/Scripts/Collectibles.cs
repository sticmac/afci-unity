using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    [SerializeField] GameObject[] collectibles;
    [SerializeField] Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int points = 0;
        for (int i = 0 ; i < collectibles.Length ; i++) {
            // Est-ce que le collectable est désactivé (ramassé) ?
            if (!collectibles[i].activeInHierarchy) {
                points++;
            }
        }
        scoreText.text = "" + points;
    }
}
