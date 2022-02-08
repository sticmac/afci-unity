using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicule { // classe abstraite = on ne pourra jamais faire new Vehicule()
    protected int roues;

    public Vehicule(int roues) {
        this.roues = roues;
    }

    public abstract void Afficher();
}

public class Voiture : Vehicule {
    public Voiture() : base(4) {
    }

    public override void Afficher() {
        Debug.Log("Ceci est une voiture");
    }

    public void Klaxonner() {

    }
}

public class Moto : Vehicule {
    public Moto() : base(2) {

    }

    public override void Afficher() {
        Debug.Log("Ceci est une moto");
    }
}

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Polymorphisme
        Vehicule vehicule1 = new Voiture();
        vehicule1.Afficher(); // Ceci est une voiture
        // On ne peut pas écrire « vehicule1.Klaxonner(); » car Vehicule ne contient pas la méthode Klaxonner

        Vehicule vehicule2 = new Moto();
        vehicule2.Afficher();

        // Grâce au polymorphisme, on peut stocker les classes filles dans un tableau du type de la classe mère
        Vehicule[] vehicules = {
            new Voiture(),
            new Moto(),
            new Voiture(),
            new Voiture()
        };

        for (int i = 0 ; i < vehicules.Length ; i++) {
            vehicules[i].Afficher();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}